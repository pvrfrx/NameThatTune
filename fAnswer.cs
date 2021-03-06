﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
namespace NameThatTune
{
    public partial class fAnswer : Form
    {
        public fAnswer()
        {
            InitializeComponent();
        }

        private void fAnswer_Load(object sender, EventArgs e)
        {
            lblGetRightAnswer.Text = "Посмотреть ответ";
            progressBar1.Maximum = NameThatTune.timeAnswer;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value==progressBar1.Maximum)
            {
                this.DialogResult = DialogResult.No;
                timer1.Stop();
                this.Close();
            }
            else progressBar1.Value++;
        }

        private void lblGetRightAnswer_Click(object sender, EventArgs e)
        {
            File mp3File = File.Create(NameThatTune.tuneAnswer);
            lblGetRightAnswer.Text = mp3File.Tag.Performers[0] + " - " + mp3File.Tag.Title;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
