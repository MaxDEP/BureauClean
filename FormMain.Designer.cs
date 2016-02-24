namespace BureauClean_Projet
{
    partial class Setup_BureauClean
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
            this.btnCheckStatut = new System.Windows.Forms.Button();
            this.lstNotification = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrEditNotify = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCheckStatut
            // 
            this.btnCheckStatut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCheckStatut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckStatut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckStatut.Location = new System.Drawing.Point(12, 12);
            this.btnCheckStatut.Name = "btnCheckStatut";
            this.btnCheckStatut.Size = new System.Drawing.Size(523, 23);
            this.btnCheckStatut.TabIndex = 4;
            this.btnCheckStatut.Text = "Start Watching";
            this.btnCheckStatut.UseVisualStyleBackColor = false;
            this.btnCheckStatut.Click += new System.EventHandler(this.btnWatchFile_Click);
            // 
            // lstNotification
            // 
            this.lstNotification.FormattingEnabled = true;
            this.lstNotification.Location = new System.Drawing.Point(12, 63);
            this.lstNotification.Name = "lstNotification";
            this.lstNotification.Size = new System.Drawing.Size(523, 225);
            this.lstNotification.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 47);
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
            // Setup_BureauClean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstNotification);
            this.Controls.Add(this.btnCheckStatut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Setup_BureauClean";
            this.Text = "Configuration de BureauClean";
            this.Load += new System.EventHandler(this.frmNotifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckStatut;
        private System.Windows.Forms.ListBox lstNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrEditNotify;
    }
}

