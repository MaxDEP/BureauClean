using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace BureauClean_Projet
{
    public partial class Setup_BureauClean : Form
    {
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private StringBuilder string_log;
        private bool log_present;
        private FileSystemWatcher checker;
        private bool check_on;
        string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Setup_BureauClean()
        {
            InitializeComponent();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] { this.menuItem1 });
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Stop";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            notifyIcon1.ContextMenu = this.contextMenu1;
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
                if(e.ChangeType.ToString() == "Created")
                {
                    System.Threading.Thread.Sleep(10000);
                    cleaning(e.FullPath, e.Name);
                }
                log_present = true;
            }
        }
        static string getFolder_byext(string url_file)
        {
            var url_folder = new Dictionary<string, string>
            {
                //Images
                [".png"] = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                [".gif"] = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                [".jpg"] = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                [".jpeg"] = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                //Documents textes
                [".txt"] = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                [".doc"] = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                [".odt"] = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                [".docx"] = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                //Vidéos
                [".avi"] = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                [".mp4"] = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                [".mkv"] = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                [".webm"] = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                //Musiques
                [".mp3"] = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
            };
            string ext = Path.GetExtension(@url_file);
            return url_folder[ext];
        }
        public void cleaning(string url_file, string name_file)
        {
            if (!File.Exists(url_file))
            {
                var directory = new DirectoryInfo(path_desktop + "\\test\\");
                name_file = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First().Name;
                url_file = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First().FullName;
            }
            string url_folder = getFolder_byext(url_file);
            File.Move(url_file, url_folder + "\\" + name_file);
            if (!log_present)
            {
                string_log.Remove(0, string_log.Length);
                string_log.Append(name_file);
                string_log.Append("- is ");
                string_log.Append("Moved");
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

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            this.Activate();
        }
        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}