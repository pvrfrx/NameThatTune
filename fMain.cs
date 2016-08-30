using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
