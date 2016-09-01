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
    public partial class fGame : Form
    {
        public fGame()
        {
            InitializeComponent();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = NameThatTune.tuneDuration;
            NewTunePlay();
        }
        List<int> listTunePlayed = new List<int>(); //список песен, которые прозвучали во время игры.
        private void NewTunePlay()
        {
            Random random = new Random();
            int i = 0;
            while (true)
            {
                int randomNumber = random.Next(NameThatTune.listMusic.Count);
                if (listTunePlayed.IndexOf(randomNumber) == -1)
                {
                    listTunePlayed.Add(randomNumber);
                    WMP.URL = NameThatTune.listMusic[randomNumber];
                    WMP.Ctlcontrols.play();
                    timer1.Start();
                    break;
                }
                else
                {
                    i++;
                    if (i > NameThatTune.listMusic.Count)// если прошли все песни из списка, то смотрим параметр в настройках, и сбрасываем запомненные песни или заканчиваем игру
                    {
                        if (NameThatTune.repeatTune)
                        {
                            listTunePlayed.Clear();
                            i = 0;
                        }
                        else
                        {
                            GameOver();
                            break;
                        }
                    }
                }
            }
        }

       
        private void fGame_Shown(object sender, EventArgs e)
        {

        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
            WMP.close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            progressBar1.Value++;
            progressBar1.Refresh();
            this.Refresh();
            if (progressBar1.Value>=progressBar1.Maximum)
            {
                timer1.Stop();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Equals(NameThatTune.keyPlayer1))
            {
                GamePause();
                if (MessageBox.Show("Правильно ответил?", "Отвечает игрок 1", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    lblPoint1.Text = StringPlus1(lblPoint1.Text);
                else lblPoint1.Text = StringMinus1(lblPoint1.Text);
            }
            else if (e.KeyCode.ToString().Equals(NameThatTune.keyPlayer2))
            {
                GamePause();
                if (MessageBox.Show("Правильно ответил?", "Отвечает игрок 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    lblPoint2.Text = StringPlus1(lblPoint2.Text);
                else lblPoint2.Text = StringMinus1(lblPoint2.Text);
            }
        }
        private string StringPlus1(string s)
        {
            return (Convert.ToInt32(s) + 1).ToString();
        }
        private string StringMinus1(string s)
        {
            return (Convert.ToInt32(s) - 1).ToString();
        }
        private void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void GameOver()
        {
            MessageBox.Show("GameOver");
        }

    }
}
