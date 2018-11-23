namespace AppToFindFilesAndReplace
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblInputFolder = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.lblTotalNumberOfFiles = new System.Windows.Forms.Label();
            this.lblTotalNumberofFilesValue = new System.Windows.Forms.Label();
            this.btnFindDetails = new System.Windows.Forms.Button();
            this.lblAvailableExtensions = new System.Windows.Forms.Label();
            this.clbFileExtensions = new System.Windows.Forms.CheckedListBox();
            this.lblTextToFind = new System.Windows.Forms.Label();
            this.rtxtTextToFind = new System.Windows.Forms.RichTextBox();
            this.rtxtTextToReplace = new System.Windows.Forms.RichTextBox();
            this.lblTextToReplace = new System.Windows.Forms.Label();
            this.gpbInputs = new System.Windows.Forms.GroupBox();
            this.gpbOutputs = new System.Windows.Forms.GroupBox();
            this.lbltotalSelectedFileCountValue = new System.Windows.Forms.Label();
            this.gpbFindOptions = new System.Windows.Forms.GroupBox();
            this.chbMatchCase = new System.Windows.Forms.CheckBox();
            this.chbMatchWholeWord = new System.Windows.Forms.CheckBox();
            this.lblSearchOptions = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbltotalSelectedFileCount = new System.Windows.Forms.Label();
            this.stlblCurrentFileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblCurrentFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpbInputs.SuspendLayout();
            this.gpbOutputs.SuspendLayout();
            this.gpbFindOptions.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeading.Location = new System.Drawing.Point(202, 12);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(378, 24);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "FIND FILES AND REPLACE ITS CONTENTS";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputFolder
            // 
            this.lblInputFolder.AutoSize = true;
            this.lblInputFolder.Location = new System.Drawing.Point(18, 41);
            this.lblInputFolder.Name = "lblInputFolder";
            this.lblInputFolder.Size = new System.Drawing.Size(66, 13);
            this.lblInputFolder.TabIndex = 1;
            this.lblInputFolder.Text = "Input Folder ";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(102, 38);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(496, 20);
            this.txtFolderPath.TabIndex = 2;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Browse the Input Folder Path";
            this.folderBrowserDialog1.SelectedPath = "D:\\";
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(629, 35);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(101, 23);
            this.btnBrowseFolder.TabIndex = 3;
            this.btnBrowseFolder.Text = "Browse";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // lblTotalNumberOfFiles
            // 
            this.lblTotalNumberOfFiles.AutoSize = true;
            this.lblTotalNumberOfFiles.Location = new System.Drawing.Point(24, 15);
            this.lblTotalNumberOfFiles.Name = "lblTotalNumberOfFiles";
            this.lblTotalNumberOfFiles.Size = new System.Drawing.Size(186, 13);
            this.lblTotalNumberOfFiles.TabIndex = 4;
            this.lblTotalNumberOfFiles.Text = "Total Number of Files in This Folder is:";
            // 
            // lblTotalNumberofFilesValue
            // 
            this.lblTotalNumberofFilesValue.AutoSize = true;
            this.lblTotalNumberofFilesValue.Location = new System.Drawing.Point(210, 15);
            this.lblTotalNumberofFilesValue.Name = "lblTotalNumberofFilesValue";
            this.lblTotalNumberofFilesValue.Size = new System.Drawing.Size(0, 13);
            this.lblTotalNumberofFilesValue.TabIndex = 5;
            // 
            // btnFindDetails
            // 
            this.btnFindDetails.Location = new System.Drawing.Point(248, 82);
            this.btnFindDetails.Name = "btnFindDetails";
            this.btnFindDetails.Size = new System.Drawing.Size(225, 23);
            this.btnFindDetails.TabIndex = 6;
            this.btnFindDetails.Text = "Find All File Details";
            this.btnFindDetails.UseVisualStyleBackColor = true;
            this.btnFindDetails.Click += new System.EventHandler(this.btnFindDetails_Click);
            // 
            // lblAvailableExtensions
            // 
            this.lblAvailableExtensions.AutoSize = true;
            this.lblAvailableExtensions.Location = new System.Drawing.Point(624, 20);
            this.lblAvailableExtensions.Name = "lblAvailableExtensions";
            this.lblAvailableExtensions.Size = new System.Drawing.Size(104, 13);
            this.lblAvailableExtensions.TabIndex = 7;
            this.lblAvailableExtensions.Text = "Available Extensions";
            // 
            // clbFileExtensions
            // 
            this.clbFileExtensions.FormattingEnabled = true;
            this.clbFileExtensions.Location = new System.Drawing.Point(615, 43);
            this.clbFileExtensions.Name = "clbFileExtensions";
            this.clbFileExtensions.Size = new System.Drawing.Size(126, 169);
            this.clbFileExtensions.TabIndex = 9;
            this.clbFileExtensions.SelectedValueChanged += new System.EventHandler(this.clbFileExtensions_SelectedValueChanged);
            // 
            // lblTextToFind
            // 
            this.lblTextToFind.AutoSize = true;
            this.lblTextToFind.Location = new System.Drawing.Point(24, 89);
            this.lblTextToFind.Name = "lblTextToFind";
            this.lblTextToFind.Size = new System.Drawing.Size(70, 13);
            this.lblTextToFind.TabIndex = 10;
            this.lblTextToFind.Text = "Text To Find:";
            // 
            // rtxtTextToFind
            // 
            this.rtxtTextToFind.Location = new System.Drawing.Point(123, 80);
            this.rtxtTextToFind.Name = "rtxtTextToFind";
            this.rtxtTextToFind.Size = new System.Drawing.Size(190, 36);
            this.rtxtTextToFind.TabIndex = 12;
            this.rtxtTextToFind.Text = "";
            // 
            // rtxtTextToReplace
            // 
            this.rtxtTextToReplace.Location = new System.Drawing.Point(123, 146);
            this.rtxtTextToReplace.Name = "rtxtTextToReplace";
            this.rtxtTextToReplace.Size = new System.Drawing.Size(190, 38);
            this.rtxtTextToReplace.TabIndex = 14;
            this.rtxtTextToReplace.Text = "";
            // 
            // lblTextToReplace
            // 
            this.lblTextToReplace.AutoSize = true;
            this.lblTextToReplace.Location = new System.Drawing.Point(24, 156);
            this.lblTextToReplace.Name = "lblTextToReplace";
            this.lblTextToReplace.Size = new System.Drawing.Size(90, 13);
            this.lblTextToReplace.TabIndex = 13;
            this.lblTextToReplace.Text = "Text To Replace:";
            // 
            // gpbInputs
            // 
            this.gpbInputs.Controls.Add(this.btnFindDetails);
            this.gpbInputs.Controls.Add(this.txtFolderPath);
            this.gpbInputs.Controls.Add(this.lblInputFolder);
            this.gpbInputs.Controls.Add(this.btnBrowseFolder);
            this.gpbInputs.Location = new System.Drawing.Point(29, 43);
            this.gpbInputs.Name = "gpbInputs";
            this.gpbInputs.Size = new System.Drawing.Size(777, 127);
            this.gpbInputs.TabIndex = 15;
            this.gpbInputs.TabStop = false;
            // 
            // gpbOutputs
            // 
            this.gpbOutputs.Controls.Add(this.lbltotalSelectedFileCountValue);
            this.gpbOutputs.Controls.Add(this.gpbFindOptions);
            this.gpbOutputs.Controls.Add(this.btnSubmit);
            this.gpbOutputs.Controls.Add(this.lbltotalSelectedFileCount);
            this.gpbOutputs.Controls.Add(this.lblTotalNumberOfFiles);
            this.gpbOutputs.Controls.Add(this.rtxtTextToReplace);
            this.gpbOutputs.Controls.Add(this.lblTotalNumberofFilesValue);
            this.gpbOutputs.Controls.Add(this.lblTextToReplace);
            this.gpbOutputs.Controls.Add(this.lblAvailableExtensions);
            this.gpbOutputs.Controls.Add(this.rtxtTextToFind);
            this.gpbOutputs.Controls.Add(this.clbFileExtensions);
            this.gpbOutputs.Controls.Add(this.lblTextToFind);
            this.gpbOutputs.Location = new System.Drawing.Point(29, 192);
            this.gpbOutputs.Name = "gpbOutputs";
            this.gpbOutputs.Size = new System.Drawing.Size(777, 264);
            this.gpbOutputs.TabIndex = 16;
            this.gpbOutputs.TabStop = false;
            // 
            // lbltotalSelectedFileCountValue
            // 
            this.lbltotalSelectedFileCountValue.AutoSize = true;
            this.lbltotalSelectedFileCountValue.Location = new System.Drawing.Point(261, 44);
            this.lbltotalSelectedFileCountValue.Name = "lbltotalSelectedFileCountValue";
            this.lbltotalSelectedFileCountValue.Size = new System.Drawing.Size(0, 13);
            this.lbltotalSelectedFileCountValue.TabIndex = 17;
            // 
            // gpbFindOptions
            // 
            this.gpbFindOptions.Controls.Add(this.chbMatchCase);
            this.gpbFindOptions.Controls.Add(this.chbMatchWholeWord);
            this.gpbFindOptions.Controls.Add(this.lblSearchOptions);
            this.gpbFindOptions.Location = new System.Drawing.Point(340, 73);
            this.gpbFindOptions.Name = "gpbFindOptions";
            this.gpbFindOptions.Size = new System.Drawing.Size(209, 111);
            this.gpbFindOptions.TabIndex = 16;
            this.gpbFindOptions.TabStop = false;
            // 
            // chbMatchCase
            // 
            this.chbMatchCase.AutoSize = true;
            this.chbMatchCase.Location = new System.Drawing.Point(22, 75);
            this.chbMatchCase.Name = "chbMatchCase";
            this.chbMatchCase.Size = new System.Drawing.Size(86, 17);
            this.chbMatchCase.TabIndex = 0;
            this.chbMatchCase.Text = " Match Case";
            this.chbMatchCase.UseVisualStyleBackColor = true;
            // 
            // chbMatchWholeWord
            // 
            this.chbMatchWholeWord.AutoSize = true;
            this.chbMatchWholeWord.Location = new System.Drawing.Point(22, 41);
            this.chbMatchWholeWord.Name = "chbMatchWholeWord";
            this.chbMatchWholeWord.Size = new System.Drawing.Size(122, 17);
            this.chbMatchWholeWord.TabIndex = 0;
            this.chbMatchWholeWord.Text = " Match Whole Word";
            this.chbMatchWholeWord.UseVisualStyleBackColor = true;
            // 
            // lblSearchOptions
            // 
            this.lblSearchOptions.AutoSize = true;
            this.lblSearchOptions.Location = new System.Drawing.Point(52, 16);
            this.lblSearchOptions.Name = "lblSearchOptions";
            this.lblSearchOptions.Size = new System.Drawing.Size(80, 13);
            this.lblSearchOptions.TabIndex = 7;
            this.lblSearchOptions.Text = "Search Options";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(248, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // lbltotalSelectedFileCount
            // 
            this.lbltotalSelectedFileCount.AutoSize = true;
            this.lbltotalSelectedFileCount.Location = new System.Drawing.Point(24, 44);
            this.lbltotalSelectedFileCount.Name = "lbltotalSelectedFileCount";
            this.lbltotalSelectedFileCount.Size = new System.Drawing.Size(236, 13);
            this.lbltotalSelectedFileCount.TabIndex = 4;
            this.lbltotalSelectedFileCount.Text = "Total Number of Files with Selected Extension is:";
            // 
            // stlblCurrentFileStatus
            // 
            this.stlblCurrentFileStatus.Name = "stlblCurrentFileStatus";
            this.stlblCurrentFileStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlblCurrentFileStatus,
            this.slblCurrentFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(843, 22);
            this.statusStrip1.TabIndex = 17;
            // 
            // slblCurrentFile
            // 
            this.slblCurrentFile.Name = "slblCurrentFile";
            this.slblCurrentFile.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 495);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gpbOutputs);
            this.Controls.Add(this.gpbInputs);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find And Replace Automation";
            this.gpbInputs.ResumeLayout(false);
            this.gpbInputs.PerformLayout();
            this.gpbOutputs.ResumeLayout(false);
            this.gpbOutputs.PerformLayout();
            this.gpbFindOptions.ResumeLayout(false);
            this.gpbFindOptions.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblInputFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnBrowseFolder;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblTotalNumberOfFiles;
        private System.Windows.Forms.Label lblTotalNumberofFilesValue;
        private System.Windows.Forms.Button btnFindDetails;
        private System.Windows.Forms.Label lblAvailableExtensions;
        private System.Windows.Forms.CheckedListBox clbFileExtensions;
        private System.Windows.Forms.Label lblTextToFind;
        private System.Windows.Forms.RichTextBox rtxtTextToFind;
        private System.Windows.Forms.RichTextBox rtxtTextToReplace;
        private System.Windows.Forms.Label lblTextToReplace;
        private System.Windows.Forms.GroupBox gpbInputs;
        private System.Windows.Forms.GroupBox gpbOutputs;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolStripStatusLabel stlblCurrentFileStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblCurrentFile;
        private System.Windows.Forms.GroupBox gpbFindOptions;
        private System.Windows.Forms.Label lblSearchOptions;
        private System.Windows.Forms.CheckBox chbMatchCase;
        private System.Windows.Forms.CheckBox chbMatchWholeWord;
        private System.Windows.Forms.Label lbltotalSelectedFileCount;
        private System.Windows.Forms.Label lbltotalSelectedFileCountValue;
    }
}

