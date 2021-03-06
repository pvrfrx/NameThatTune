﻿using System;
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
            if (Convert.ToInt32(cbGameDuration.Text) <= 0 || Convert.ToInt32(cbTuneDuration.Text) <= 0
                || Convert.ToInt32(cbTimeAnswer.Text) <= 0)
            {
                MessageBox.Show("Некорректные настройки времени");
                return;
            }
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
            NameThatTune.keyPlayer1 = cbKeyPlayer1.Text.ToUpper();
            NameThatTune.keyPlayer2 = cbKeyPlayer2.Text.ToUpper();
            NameThatTune.timeAnswer = Convert.ToInt32(cbTimeAnswer.Text);

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
                cbKeyPlayer1.Text = NameThatTune.keyPlayer1;
                cbKeyPlayer2.Text = NameThatTune.keyPlayer2;
                cbTimeAnswer.Text = NameThatTune.timeAnswer.ToString();
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
    }
}
