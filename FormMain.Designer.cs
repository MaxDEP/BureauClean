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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup_BureauClean));
            this.btnCheckStatut = new System.Windows.Forms.Button();
            this.suiviBureau = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrEditNotify = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveStatutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configRangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckStatut
            // 
            this.btnCheckStatut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCheckStatut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckStatut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckStatut.Location = new System.Drawing.Point(12, 27);
            this.btnCheckStatut.Name = "btnCheckStatut";
            this.btnCheckStatut.Size = new System.Drawing.Size(523, 23);
            this.btnCheckStatut.TabIndex = 4;
            this.btnCheckStatut.Text = "Start checking";
            this.btnCheckStatut.UseVisualStyleBackColor = false;
            this.btnCheckStatut.Click += new System.EventHandler(this.btnWatchFile_Click);
            // 
            // suiviBureau
            // 
            this.suiviBureau.FormattingEnabled = true;
            this.suiviBureau.Location = new System.Drawing.Point(12, 78);
            this.suiviBureau.Name = "suiviBureau";
            this.suiviBureau.Size = new System.Drawing.Size(523, 225);
            this.suiviBureau.TabIndex = 5;
            this.suiviBureau.SelectedIndexChanged += new System.EventHandler(this.suiviBureau_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modifications:";
            // 
            // tmrEditNotify
            // 
            this.tmrEditNotify.Enabled = true;
            this.tmrEditNotify.Tick += new System.EventHandler(this.tmrEditNotify_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveStatutToolStripMenuItem,
            this.configRangementToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // liveStatutToolStripMenuItem
            // 
            this.liveStatutToolStripMenuItem.Name = "liveStatutToolStripMenuItem";
            this.liveStatutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.liveStatutToolStripMenuItem.Text = "Live statut";
            // 
            // configRangementToolStripMenuItem
            // 
            this.configRangementToolStripMenuItem.Name = "configRangementToolStripMenuItem";
            this.configRangementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.configRangementToolStripMenuItem.Text = "Config rangement";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.versionToolStripMenuItem.Text = "Version ";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "BureuClean";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // Setup_BureauClean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.suiviBureau);
            this.Controls.Add(this.btnCheckStatut);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Setup_BureauClean";
            this.Text = "Configuration de BureauClean";
            this.Load += new System.EventHandler(this.frmNotifier_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckStatut;
        private System.Windows.Forms.ListBox suiviBureau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrEditNotify;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveStatutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configRangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

