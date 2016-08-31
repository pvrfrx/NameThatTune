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
                lbListMusic.Items.Clear();
                lbListMusic.Items.AddRange(Directory.GetFiles(fbd.SelectedPath, "*.mp3", 
                    cbAllFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
                NameThatTune.WriteSettings("Last Path", fbd.SelectedPath);
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
            NameThatTune.WriteSettings("Game Duration", cbGameDuration.Text);
            NameThatTune.WriteSettings("Game Tune", cbTuneDuration.Text);
            NameThatTune.WriteSettings("Random Start", cbRandomStart.Checked);
            NameThatTune.WriteSettings("All Direction", cbAllFolder.Checked);
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
                cbGameDuration.Text = NameThatTune.ReadSettings("Game Duration").ToString();
                cbTuneDuration.Text = NameThatTune.ReadSettings("Game Tune").ToString();
                cbRandomStart.Checked = Convert.ToBoolean(NameThatTune.ReadSettings("Random Start"));
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
