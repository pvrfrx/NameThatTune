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
using NameThatTune;

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
                lbListMusic.Items.Clear();
                lbListMusic.Items.AddRange(Directory.GetFiles(fbd.SelectedPath, "*.mp3", 
                    cbAllFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
                NameThatTune.lastPath = fbd.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            NameThatTune.listMusic.Clear();
            foreach (string item in lbListMusic.Items)  
            {
                NameThatTune.listMusic.Add(item);
            }
            lbListMusic.Items.Clear();

            NameThatTune.gameDuration =Convert.ToInt32( cbGameDuration.Text);
            NameThatTune.tuneDuration =Convert.ToInt32(cbTuneDuration.Text);
            NameThatTune.randomStart = Convert.ToBoolean(cbRandomStart.Checked);
            NameThatTune.repeatTune = Convert.ToBoolean(cbRepeat.Checked);
            NameThatTune.allDirection = Convert.ToBoolean(cbAllFolder.Checked);
            NameThatTune.WriteSettings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            lbListMusic.Items.Clear();
        }

        private void fSettings_Shown(object sender, EventArgs e)
        {
            try
            {
                cbGameDuration.Text = NameThatTune.gameDuration.ToString();
                cbTuneDuration.Text = NameThatTune.tuneDuration.ToString();
                cbRandomStart.Checked = NameThatTune.randomStart;
                cbRepeat.Checked = NameThatTune.repeatTune;
                cbAllFolder.Checked = NameThatTune.allDirection;
                lbListMusic.Items.Clear();
                lbListMusic.Items.AddRange(NameThatTune.listMusic.ToArray());
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
    }
}
