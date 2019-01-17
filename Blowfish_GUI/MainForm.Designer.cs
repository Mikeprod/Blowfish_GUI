namespace Blowfish_GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.KeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundDecrypt = new System.ComponentModel.BackgroundWorker();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.fileHeader = new System.Windows.Forms.Label();
            this.ImportFile = new System.Windows.Forms.Button();
            this.encodingListFile = new System.Windows.Forms.ListBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.encodingListKey = new System.Windows.Forms.ListBox();
            this.keyHeader = new System.Windows.Forms.Label();
            this.ImportKey = new System.Windows.Forms.Button();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.ouputButton = new System.Windows.Forms.Button();
            this.backgroundEncrypt = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.outputDialog = new System.Windows.Forms.SaveFileDialog();
            this.compatModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logBox = new System.Windows.Forms.TextBox();
            this.standardModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardModeToolStripMenuItem,
            this.compatModeToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(39, 17);
            this.StatusLabel.Text = "Status";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(0, 27);
            this.fileTextBox.Multiline = true;
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileTextBox.Size = new System.Drawing.Size(491, 365);
            this.fileTextBox.TabIndex = 2;
            // 
            // FileDialog
            // 
            this.FileDialog.Title = "Choose a file";
            this.FileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialog_FileOk);
            // 
            // KeyDialog
            // 
            this.KeyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.KeyDialog_FileOk);
            // 
            // backgroundDecrypt
            // 
            this.backgroundDecrypt.WorkerReportsProgress = true;
            this.backgroundDecrypt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundDecrypt_DoWork);
            this.backgroundDecrypt.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundDecrypt_ProgressChanged);
            this.backgroundDecrypt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundDecrypt_RunWorkerCompleted);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.keyTextBox.Location = new System.Drawing.Point(0, 399);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(491, 20);
            this.keyTextBox.TabIndex = 7;
            // 
            // decryptButton
            // 
            this.decryptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptButton.Location = new System.Drawing.Point(3, 3);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(145, 25);
            this.decryptButton.TabIndex = 9;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptButton.Location = new System.Drawing.Point(154, 3);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(146, 25);
            this.encryptButton.TabIndex = 10;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tab1);
            this.tabs.Controls.Add(this.tab2);
            this.tabs.Controls.Add(this.tab3);
            this.tabs.Location = new System.Drawing.Point(497, 27);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(303, 133);
            this.tabs.TabIndex = 11;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.fileHeader);
            this.tab1.Controls.Add(this.ImportFile);
            this.tab1.Controls.Add(this.encodingListFile);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(295, 107);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "File Options";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // fileHeader
            // 
            this.fileHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileHeader.Location = new System.Drawing.Point(3, 3);
            this.fileHeader.Name = "fileHeader";
            this.fileHeader.Size = new System.Drawing.Size(289, 23);
            this.fileHeader.TabIndex = 9;
            this.fileHeader.Text = "Text type";
            this.fileHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImportFile
            // 
            this.ImportFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImportFile.Location = new System.Drawing.Point(3, 81);
            this.ImportFile.Name = "ImportFile";
            this.ImportFile.Size = new System.Drawing.Size(289, 23);
            this.ImportFile.TabIndex = 8;
            this.ImportFile.Text = "Import File";
            this.ImportFile.UseVisualStyleBackColor = true;
            this.ImportFile.Click += new System.EventHandler(this.ImportFile_Click);
            // 
            // encodingListFile
            // 
            this.encodingListFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encodingListFile.FormattingEnabled = true;
            this.encodingListFile.Items.AddRange(new object[] {
            "ASCII",
            "Hex"});
            this.encodingListFile.Location = new System.Drawing.Point(0, 29);
            this.encodingListFile.Name = "encodingListFile";
            this.encodingListFile.Size = new System.Drawing.Size(292, 30);
            this.encodingListFile.TabIndex = 7;
            this.encodingListFile.SelectedIndexChanged += new System.EventHandler(this.encodingListFile_SelectedIndexChanged);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.encodingListKey);
            this.tab2.Controls.Add(this.keyHeader);
            this.tab2.Controls.Add(this.ImportKey);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(295, 107);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Key Options";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // encodingListKey
            // 
            this.encodingListKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encodingListKey.FormattingEnabled = true;
            this.encodingListKey.Items.AddRange(new object[] {
            "ASCII",
            "Hex"});
            this.encodingListKey.Location = new System.Drawing.Point(0, 29);
            this.encodingListKey.Name = "encodingListKey";
            this.encodingListKey.Size = new System.Drawing.Size(292, 30);
            this.encodingListKey.TabIndex = 11;
            this.encodingListKey.SelectedIndexChanged += new System.EventHandler(this.encodingListFile_SelectedIndexChanged);
            // 
            // keyHeader
            // 
            this.keyHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.keyHeader.Location = new System.Drawing.Point(3, 3);
            this.keyHeader.Name = "keyHeader";
            this.keyHeader.Size = new System.Drawing.Size(289, 23);
            this.keyHeader.TabIndex = 10;
            this.keyHeader.Text = "Text type";
            this.keyHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImportKey
            // 
            this.ImportKey.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImportKey.Location = new System.Drawing.Point(3, 81);
            this.ImportKey.Name = "ImportKey";
            this.ImportKey.Size = new System.Drawing.Size(289, 23);
            this.ImportKey.TabIndex = 5;
            this.ImportKey.Text = "Import Key";
            this.ImportKey.UseVisualStyleBackColor = true;
            this.ImportKey.Click += new System.EventHandler(this.ImportKey_Click);
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.ouputButton);
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(295, 107);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Output Options";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // ouputButton
            // 
            this.ouputButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ouputButton.Location = new System.Drawing.Point(3, 81);
            this.ouputButton.Name = "ouputButton";
            this.ouputButton.Size = new System.Drawing.Size(289, 23);
            this.ouputButton.TabIndex = 0;
            this.ouputButton.Text = "Output";
            this.ouputButton.UseVisualStyleBackColor = true;
            this.ouputButton.Click += new System.EventHandler(this.ouputButton_Click);
            // 
            // backgroundEncrypt
            // 
            this.backgroundEncrypt.WorkerReportsProgress = true;
            this.backgroundEncrypt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundEncrypt_DoWork);
            this.backgroundEncrypt.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundDecrypt_ProgressChanged);
            this.backgroundEncrypt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundEncrypt_RunWorkerCompleted);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.encryptButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.decryptButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(497, 394);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 31);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // outputDialog
            // 
            this.outputDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.outputDialog_FileOk);
            // 
            // compatModeToolStripMenuItem
            // 
            this.compatModeToolStripMenuItem.Checked = true;
            this.compatModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compatModeToolStripMenuItem.Name = "compatModeToolStripMenuItem";
            this.compatModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compatModeToolStripMenuItem.Text = "Compat mode";
            this.compatModeToolStripMenuItem.Click += new System.EventHandler(this.compatModeToolStripMenuItem_Click);
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Location = new System.Drawing.Point(497, 163);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(299, 229);
            this.logBox.TabIndex = 13;
            // 
            // standardModeToolStripMenuItem
            // 
            this.standardModeToolStripMenuItem.Checked = false;
            this.standardModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.standardModeToolStripMenuItem.Name = "standardModeToolStripMenuItem";
            this.standardModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.standardModeToolStripMenuItem.Text = "Standard mode";
            this.standardModeToolStripMenuItem.Click += new System.EventHandler(this.standardModeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.Text = "BlowFish GUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.OpenFileDialog KeyDialog;
        private System.ComponentModel.BackgroundWorker backgroundDecrypt;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Button ImportFile;
        private System.Windows.Forms.ListBox encodingListFile;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Button ImportKey;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.Button ouputButton;
        private System.ComponentModel.BackgroundWorker backgroundEncrypt;
        private System.Windows.Forms.Label fileHeader;
        private System.Windows.Forms.Label keyHeader;
        private System.Windows.Forms.ListBox encodingListKey;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SaveFileDialog outputDialog;
        private System.Windows.Forms.ToolStripMenuItem compatModeToolStripMenuItem;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.ToolStripMenuItem standardModeToolStripMenuItem;
    }
}

