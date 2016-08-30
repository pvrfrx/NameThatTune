using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NameThatTune
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void btnClearMusic_Click(object sender, EventArgs e)
        {
            lbListMusic.Items.Clear();
        }

        private void btnLoadMusic_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lbListMusic.Items.AddRange(Directory.GetFiles(fbd.SelectedPath, "*.mp3", 
                    cbAllFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
            }

        }
    }
}
