using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BureauClean_Projet
{
    public partial class Setup_BureauClean : Form
    {
        private StringBuilder string_log;
        private bool log_present;
        private FileSystemWatcher checker;
        private bool check_on;
        string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Setup_BureauClean()
        {
            InitializeComponent();
            versionToolStripMenuItem.Text = "Version : " + Application.ProductVersion;
            string_log = new StringBuilder();
            log_present = false;
            check_on = false;
            check();
        }
        public void check()
        {
            check_on = true;
            btnCheckStatut.PerformClick();
            btnCheckStatut.BackColor = Color.Red;
            btnCheckStatut.Text = "Stop checking";

            checker = new System.IO.FileSystemWatcher();
            checker.Filter = "*.*";
            checker.Path = path_desktop + "\\test\\";

            checker.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                 | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            checker.Changed += new FileSystemEventHandler(OnChanged);
            checker.Created += new FileSystemEventHandler(OnChanged);
            checker.Deleted += new FileSystemEventHandler(OnChanged);
            checker.Renamed += new RenamedEventHandler(OnRenamed);
            checker.EnableRaisingEvents = true;
        }

        private void btnWatchFile_Click(object sender, EventArgs e)
        {
            if (check_on)
            {
                check_on = false;
                checker.EnableRaisingEvents = false;
                checker.Dispose();
                btnCheckStatut.BackColor = Color.LightSkyBlue;
                btnCheckStatut.Text = "Start checking";
                
            }
            else
            {
                check();
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (!log_present)
            {
                string_log.Remove(0, string_log.Length);
                string_log.Append(e.FullPath);
                string_log.Append("- is ");
                string_log.Append(e.ChangeType.ToString());
                string_log.Append("- le  ");
                string_log.Append(DateTime.Now.ToString());
                log_present = true;
            }
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            if (!log_present)
            {
                string_log.Remove(0, string_log.Length);
                string_log.Append(e.OldFullPath);
                string_log.Append("- is ");
                string_log.Append(e.ChangeType.ToString());
                string_log.Append(" ");
                string_log.Append("à ");
                string_log.Append(e.Name);
                string_log.Append("    ");
                string_log.Append(DateTime.Now.ToString());
                log_present = true;
            }            
        }

        private void tmrEditNotify_Tick(object sender, EventArgs e)
        {
            if (log_present)
            {
                suiviBureau.BeginUpdate();
                suiviBureau.Items.Add(string_log.ToString());
                suiviBureau.EndUpdate();
                log_present = false;
            }
        }


        private void frmNotifier_Load(object sender, EventArgs e)
        {

        }

        private void suiviBureau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}