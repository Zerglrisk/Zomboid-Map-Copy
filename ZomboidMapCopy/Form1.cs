using System;
using System.IO;
using System.Windows.Forms;

namespace ZomboidMapCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string userFolderPath = Environment.GetEnvironmentVariable("USERPROFILE");
            string path = Path.Combine(userFolderPath, "Zomboid");
            if (Directory.Exists(path))
            {
                this.txtFrom.Text = path;
            }
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            this.txtFrom.Text = OpenFolder();
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            this.txtTo.Text = OpenFolder();
        }

        private void txtBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtFrom.Text) || !File.Exists(Path.Combine(this.txtFrom.Text, "map_meta.bin")))
            {
                MessageBox.Show("This Folder is not Save Folder");
                return;
            }
            if (string.IsNullOrEmpty(this.txtTo.Text))
            {
                MessageBox.Show("Target Folder is Empty");
            }

            CopySpecificFiles(this.txtFrom.Text, this.txtTo.Text, this.nudXFrom.Value, this.nudXTo.Value, this.nudYFrom.Value, this.nudYTo.Value);
            MessageBox.Show("Jobs Done");
        }

        public void CopySpecificFiles(string sourceFolder, string targetFolder, decimal xFrom, decimal xTo, decimal yFrom, decimal yTo)
        {
            string[] files = Directory.GetFiles(sourceFolder, "map_*_*.bin");
            foreach (string file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                string[] parts = fileName.Split('_');
                if (parts.Length == 3)
                {
                    if (decimal.TryParse(parts[1], out decimal x) && decimal.TryParse(parts[2], out decimal y))
                    {
                        if (x >= xFrom && x <= xTo && y >= yFrom && y <= yTo)
                        {
                            string targetFilePath = Path.Combine(targetFolder, Path.GetFileName(file));
                            File.Copy(file, targetFilePath, true);
                        }
                    }
                }
            }
        }

        private string OpenFolder()
        {
            string userFolderPath = Environment.GetEnvironmentVariable("USERPROFILE");
            string path = Path.Combine(userFolderPath, "Zomboid");
            if (!Directory.Exists(path))
            {
                path = userFolderPath;
            }
            folderBrowserDialog1.SelectedPath = path;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }
            else
            {
                return null;
            }
        }
    }
}