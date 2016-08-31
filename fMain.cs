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
    public partial class fMain : Form
    {
        
        fSettings fs = new fSettings();
        fGame fg = new fGame();
        public fMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            fs.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (NameThatTune.listMusic.Count==0) MessageBox.Show("Не загружено ни одной песни");
            else fg.ShowDialog();
        }

        private void fMain_Shown(object sender, EventArgs e)
        {
            NameThatTune.ReadSettings();
            try
            {
                NameThatTune.listMusic.AddRange(Directory.GetFiles(
                    NameThatTune.lastPath, "*.mp3", 
                    Convert.ToBoolean(NameThatTune.allDirection) ? 
                    SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
