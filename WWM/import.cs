using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWM
{
    public partial class import : Form
    {
        string programmpfad = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string download = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public import()
        {
            InitializeComponent();
            tb_source.Text = download + "\\Downloads\\wwm-config";
        }

        private void tb_source_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                tb_source.Text = folderBrowser.SelectedPath + "\\";
                bt_import.Enabled = true;
            }
        }

        private void bt_import_Click(object sender, EventArgs e)
        {

            string Source = Convert.ToString(tb_source.Text);

            string SourceDir = Source + "\\";
            string DestinationDir = programmpfad + "\\WWM";
            try
            {
                string[] FilesToCopy = Directory.GetFiles(SourceDir, "*", SearchOption.AllDirectories);

                foreach (string src in FilesToCopy)
                {
                    string relativePath = src.Substring(SourceDir.Length, src.Length - SourceDir.Length);
                    string dst = Path.Combine(DestinationDir, relativePath);
                    DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(dst));
                    if (!di.Exists)
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(dst));
                    }
                    File.Copy(src, dst);
                }
                MessageBox.Show("Erfolg");
                Close();
            }
            catch
            {
                MessageBox.Show("Kopieren fehlgeschlagen");
            }
            

        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            try
            { 
                Directory.Delete(programmpfad + "\\WWM", true);
                MessageBox.Show("Config erfolgreich geleert");
            }
            catch
            {
                MessageBox.Show("Config konnte nicht geleert werden.\nMöglicherweise noch geöffnet");
            }
        }
    }
}
