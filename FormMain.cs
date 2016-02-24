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
        private StringBuilder m_Sb;
        private bool m_bDirty;
        private System.IO.FileSystemWatcher m_Watcher;
        private bool m_bIsWatching;
        string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Setup_BureauClean()
        {
            InitializeComponent();
            m_Sb = new StringBuilder();
            m_bDirty = false;
            m_bIsWatching = false;
            check();
        }
        public void check()
        {
            m_bIsWatching = true;
            btnCheckStatut.PerformClick();
            btnCheckStatut.BackColor = Color.Red;
            btnCheckStatut.Text = "Stop checking";

            m_Watcher = new System.IO.FileSystemWatcher();
            m_Watcher.Filter = "*.*";
            m_Watcher.Path = path_desktop + "\\test\\";

            m_Watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                 | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            m_Watcher.Changed += new FileSystemEventHandler(OnChanged);
            m_Watcher.Created += new FileSystemEventHandler(OnChanged);
            m_Watcher.Deleted += new FileSystemEventHandler(OnChanged);
            m_Watcher.Renamed += new RenamedEventHandler(OnRenamed);
            m_Watcher.EnableRaisingEvents = true;
        }

        private void btnWatchFile_Click(object sender, EventArgs e)
        {
            if (m_bIsWatching)
            {
                m_bIsWatching = false;
                m_Watcher.EnableRaisingEvents = false;
                m_Watcher.Dispose();
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
            if (!m_bDirty)
            {
                m_Sb.Remove(0, m_Sb.Length);
                m_Sb.Append(e.FullPath);
                m_Sb.Append("- is ");
                m_Sb.Append(e.ChangeType.ToString());
                m_Sb.Append("- le  ");
                m_Sb.Append(DateTime.Now.ToString());
                m_bDirty = true;
            }
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            if (!m_bDirty)
            {
                m_Sb.Remove(0, m_Sb.Length);
                m_Sb.Append(e.OldFullPath);
                m_Sb.Append("- is ");
                m_Sb.Append(e.ChangeType.ToString());
                m_Sb.Append(" ");
                m_Sb.Append("à ");
                m_Sb.Append(e.Name);
                m_Sb.Append("    ");
                m_Sb.Append(DateTime.Now.ToString());
                m_bDirty = true;
            }            
        }

        private void tmrEditNotify_Tick(object sender, EventArgs e)
        {
            if (m_bDirty)
            {
                lstNotification.BeginUpdate();
                lstNotification.Items.Add(m_Sb.ToString());
                lstNotification.EndUpdate();
                m_bDirty = false;
            }
        }


        private void frmNotifier_Load(object sender, EventArgs e)
        {

        }
    }
}