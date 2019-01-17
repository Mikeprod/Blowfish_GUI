using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.MemoryMappedFiles;
using BlowFishCS;
using Microsoft.VisualBasic.Devices;

namespace Blowfish_GUI
{
    public partial class MainForm : Form
    {
        private byte[] fileInMemory;
        private byte[] keyInMemory;
        private long fileSize = -1;
        private long keySize = -1;
        private MemoryMappedFile mmf_file;
        private MemoryMappedFile mmf_key;
        private string outputPath = "";
        private bool currentCompatMode;

        public MainForm()
        {
            InitializeComponent();
        }

        private void compatModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compatModeToolStripMenuItem.Checked = !compatModeToolStripMenuItem.Checked;
            currentCompatMode = compatModeToolStripMenuItem.Checked;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportFile_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
        }

        private void ImportKey_Click(object sender, EventArgs e)
        {
            KeyDialog.ShowDialog();
        }

        private void ouputButton_Click(object sender, EventArgs e)
        {
            outputDialog.ShowDialog();
        }

        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var importFilePath = FileDialog.FileName;
            fileSize = new FileInfo(importFilePath).Length;

            mmf_file = MemoryMappedFile.CreateFromFile(importFilePath, FileMode.Open);
            logBox.Text += string.Format("File loaded : {0}\r\n", importFilePath);
        }

        private void KeyDialog_FileOk(object sender, CancelEventArgs e)
        {
            var importKeyPath = KeyDialog.FileName;
            keySize = new FileInfo(importKeyPath).Length;

            mmf_key = MemoryMappedFile.CreateFromFile(importKeyPath, FileMode.Open);
            logBox.Text += string.Format("Key loaded : {0}\r\n", importKeyPath);
        }

        private void outputDialog_FileOk(object sender, CancelEventArgs e)
        {
            outputPath = outputDialog.FileName;
            logBox.Text += string.Format("Output file selected : {0}\r\n", outputPath);
        }

        private void encodingListFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = (ListBox)sender;
            var selectedValue = combo.SelectedItem;

            logBox.Text += string.Format("{0} text type set to {1}\r\n", combo.Name.ToLower().Contains("key") ? "Key" : "File", selectedValue);

        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (beforeConverting())
            {
                backgroundDecrypt.RunWorkerAsync();
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (beforeConverting())
            {
                backgroundEncrypt.RunWorkerAsync();
            }
        }

        private void backgroundDecrypt_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            StatusLabel.Text = "Converting";
            progressBar.Increment(e.ProgressPercentage * progressBar.Maximum / 100);
        }

        private void backgroundEncrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (mmf_file != null)
                mmf_file.Dispose();
            if (mmf_key != null)
                mmf_key.Dispose();
            StatusLabel.Text = "File encrypted";
            System.Threading.Thread.Sleep(700);
            progressBar.Value = 0;
        }

        private void backgroundDecrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (mmf_file != null)
                mmf_file.Dispose();
            if (mmf_key != null)
                mmf_key.Dispose();
            StatusLabel.Text = "File decrypted";
            System.Threading.Thread.Sleep(700);
            progressBar.Value = 0;
        }

        private void backgroundDecrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            var availableBytesMem = (long)new ComputerInfo().AvailablePhysicalMemory;

            loadingFilesWorker(worker, e);

            if (fileSize < availableBytesMem)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    if (mmf_file != null)
                        mmf_file.Dispose();
                    if (mmf_key != null)
                        mmf_key.Dispose();
                }
                else
                {
                    var bl = new BlowFish(keyInMemory);
                    bl.compatMode = currentCompatMode;
                    worker.ReportProgress(25);
                    var decryptedBytes = bl.Decrypt_ECB(fileInMemory);
                    worker.ReportProgress(25);
                    File.WriteAllBytes(outputPath, decryptedBytes);
                    worker.ReportProgress(25);
                }
            }
            else
                StatusLabel.Text = "Not converting (oom)";
        }

        private void backgroundEncrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            var availableBytesMem = (long)new ComputerInfo().AvailablePhysicalMemory;

            loadingFilesWorker(worker, e);

            if (fileSize < availableBytesMem)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    if (mmf_file != null)
                        mmf_file.Dispose();
                    if (mmf_key != null)
                        mmf_key.Dispose();
                }
                else
                {
                    var bl = new BlowFish(keyTextBox.Text);
                    bl.compatMode = currentCompatMode;
                    worker.ReportProgress(25);
                    var decryptedBytes = bl.Encrypt_ECB(fileInMemory);
                    worker.ReportProgress(25);
                    File.WriteAllBytes(outputPath, decryptedBytes);
                    worker.ReportProgress(25);
                }
            }
            else
                StatusLabel.Text = "Not converting (oom)";
        }

        private bool beforeConverting()
        {
            if (outputPath.Equals(string.Empty))
            {
                MessageBox.Show("You must set an output file", "You missed something", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return false;
            }

            if (mmf_file == null && mmf_key == null)
            {
                switch (encodingListFile.Text)
                {
                    case "ASCII":
                        fileInMemory = Encoding.ASCII.GetBytes(fileTextBox.Text);
                        break;
                    case "Hex":
                        fileInMemory = HexToByte(fileTextBox.Text);
                        break;
                    default:
                        MessageBox.Show("You must import a file or set the text encoding in the list before performing any action", "You missed something", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return false;
                }

                switch (encodingListKey.Text)
                {
                    case "ASCII":
                        keyInMemory = Encoding.ASCII.GetBytes(keyTextBox.Text);
                        break;
                    case "Hex":
                        keyInMemory = HexToByte(keyTextBox.Text);
                        break;
                    default:
                        MessageBox.Show("You must import a file or set the text encoding in the list before performing any action", "You missed something", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return false;
                }
                return true;
            }

            if (mmf_file == null)
            {
                switch (encodingListFile.Text)
                {
                    case "ASCII":
                        fileInMemory = Encoding.ASCII.GetBytes(fileTextBox.Text);
                        return true;
                    case "Hex":
                        fileInMemory = HexToByte(fileTextBox.Text);
                        return true;
                    default:
                        MessageBox.Show("You must import a file or set the text encoding in the list before performing any action", "You missed something", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return false;
                }
            }

            if (mmf_key == null)
            {
                switch (encodingListFile.Text)
                {
                    case "ASCII":
                        keyInMemory = Encoding.ASCII.GetBytes(keyTextBox.Text);
                        return true;
                    case "Hex":
                        keyInMemory = HexToByte(keyTextBox.Text);
                        return true;
                    default:
                        MessageBox.Show("You must import a file or set the text encoding in the list before performing any action", "You missed something", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return false;
                }
            }
            return false;
        }

        private void loadingFilesWorker(BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
                if (mmf_file != null)
                    mmf_file.Dispose();
                if (mmf_key != null)
                    mmf_key.Dispose();

            }
            else
            {
                if (mmf_file != null)
                {
                    var mmfAccessor = mmf_file.CreateViewAccessor();
                    fileInMemory = new byte[fileSize];
                    mmfAccessor.ReadArray<byte>(0, fileInMemory, 0, (int)fileSize);
                    if (mmf_key == null)
                        worker.ReportProgress(12);
                    else
                        worker.ReportProgress(25);
                }

                if (mmf_key != null)
                {
                    var mmfAccessor = mmf_key.CreateViewAccessor();
                    keyInMemory = new byte[keySize];
                    mmfAccessor.ReadArray<byte>(0, keyInMemory, 0, (int)keySize);

                    if (mmf_file == null)
                        worker.ReportProgress(13);
                    else
                        worker.ReportProgress(25);
                }
                worker.ReportProgress(25);
            } 
        }

        //converts a hex string to a byte array
        private byte[] HexToByte(string hex)
        {
            hex = hex.Replace(" ", string.Empty);
            byte[] r = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length - 1; i += 2)
            {
                byte a = GetHex(hex[i]);
                byte b = GetHex(hex[i + 1]);
                r[i / 2] = (byte)(a * 16 + b);
            }
            return r;
        }

        //converts a single hex character to it's decimal value
        private byte GetHex(char x)
        {
            if (x <= '9' && x >= '0')
            {
                return (byte)(x - '0');
            }
            else if (x <= 'z' && x >= 'a')
            {
                return (byte)(x - 'a' + 10);
            }
            else if (x <= 'Z' && x >= 'A')
            {
                return (byte)(x - 'A' + 10);
            }
            return 0;
        }
    }
}
