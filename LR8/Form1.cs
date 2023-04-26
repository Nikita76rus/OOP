using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace LR8
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog bd = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();
        }
        private void load_Click(object sender, EventArgs e)
        {
            if (bd.ShowDialog() == DialogResult.OK)
            {
                path.Text = bd.SelectedPath;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Zip files (*.zip)|*.zip";
            if (path.Text != "" && sfd.ShowDialog() == DialogResult.OK)
            {
                ZipFile zf = new ZipFile(sfd.FileName);
                zf.AddDirectory(bd.SelectedPath);
                zf.Save();
                MessageBox.Show("Архивация прошла успешно");
             }
        }
    }
}
