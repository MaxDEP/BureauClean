namespace BureauClean_Projet
{
    partial class frmNotifier
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
            this.components = new System.ComponentModel.Container();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnWatchFile = new System.Windows.Forms.Button();
            this.lstNotification = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrEditNotify = new System.Windows.Forms.Timer(this.components);
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenDir = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(13, 32);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(268, 20);
            this.txtFile.TabIndex = 0;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(12, 14);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(124, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "Select File/Directory";
            // 
            // btnWatchFile
            // 
            this.btnWatchFile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnWatchFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWatchFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWatchFile.Location = new System.Drawing.Point(12, 58);
            this.btnWatchFile.Name = "btnWatchFile";
            this.btnWatchFile.Size = new System.Drawing.Size(119, 23);
            this.btnWatchFile.TabIndex = 4;
            this.btnWatchFile.Text = "Start Watching";
            this.btnWatchFile.UseVisualStyleBackColor = false;
            this.btnWatchFile.Click += new System.EventHandler(this.btnWatchFile_Click);
            // 
            // lstNotification
            // 
            this.lstNotification.FormattingEnabled = true;
            this.lstNotification.Location = new System.Drawing.Point(12, 109);
            this.lstNotification.Name = "lstNotification";
            this.lstNotification.Size = new System.Drawing.Size(461, 225);
            this.lstNotification.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Change Notifications";
            // 
            // tmrEditNotify
            // 
            this.tmrEditNotify.Enabled = true;
            this.tmrEditNotify.Tick += new System.EventHandler(this.tmrEditNotify_Tick);
            // 
            // dlgOpenDir
            // 
            this.dlgOpenDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "log";
            this.dlgSaveFile.Filter = "LogFiles|*.log";
            // 
            // frmNotifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstNotification);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnWatchFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNotifier";
            this.Text = "File/Directory Change Notifier";
            this.Load += new System.EventHandler(this.frmNotifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnWatchFile;
        private System.Windows.Forms.ListBox lstNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrEditNotify;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.FolderBrowserDialog dlgOpenDir;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}

