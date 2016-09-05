using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NameThatTune
{
    public partial class fGame : Form
    {
        public fGame()
        {
            InitializeComponent();
        }
        Random random = new Random();
        bool[] playerAnswers = new bool[2] { false, false };
        private void btnStart_Click(object sender, EventArgs e)
        {
            NewTunePlay();
        }

        List<int> listTunePlayed = new List<int>(); //список песен, которые прозвучали во время игры.

        private void NewTunePlay()
        {
            playerAnswers[0] = false;
            playerAnswers[1] = false;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = NameThatTune.tuneDuration;
            int i = 0;
            while (true)
            {
                int randomNumber = random.Next(NameThatTune.listMusic.Count);
                if (listTunePlayed.IndexOf(randomNumber) == -1)
                {
                    listTunePlayed.Add(randomNumber);
                    WMP.URL = NameThatTune.listMusic[randomNumber];
                    WMP.Ctlcontrols.play();
                    timerTune.Start();
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
            lblGameDuration.Text = NameThatTune.gameDuration.ToString();
            NewTunePlay();
            timerGame.Start();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
            WMP.close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (playerAnswers[0]&&playerAnswers[1]) NewTunePlay();
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timerTune.Stop();
                NewTunePlay();
            }
            else progressBar1.Value++;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timerTune.Stop();
            timerGame.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            timerTune.Start();
            timerGame.Start();
            WMP.Ctlcontrols.play();
        }
        fAnswer fA = new fAnswer();
        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (timerTune.Enabled)
            {
                try
                {
                    if (!playerAnswers[0] && e.KeyData.ToString().Equals(NameThatTune.keyPlayer1))
                    {
                        playerAnswers[0] = true;
                        TunePause();
                        fA.lblPlayerAnswer.Text = "Отвечает игрок 1";
                        if (fA.ShowDialog() == DialogResult.Yes)
                        {
                            lblPoint1.Text = StringPlus1(lblPoint1.Text);
                            NewTunePlay();
                        }
                        else
                        {
                            if (playerAnswers[1]) NewTunePlay();
                            else
                            {
                                lblPoint1.Text = StringMinus1(lblPoint1.Text);
                                TuneContinue();
                            }
                        }
                    }
                    else if (!playerAnswers[1] && e.KeyCode.ToString().Equals(NameThatTune.keyPlayer2))
                    {
                        playerAnswers[1] = true;
                        TunePause();
                        fA.lblPlayerAnswer.Text = "Отвечает игрок 2";
                        if (fA.ShowDialog() == DialogResult.Yes)
                        {
                            lblPoint2.Text = StringPlus1(lblPoint2.Text);
                            NewTunePlay();
                        }
                        else 
                        {
                            if (playerAnswers[0]) NewTunePlay();
                            else
                            {
                                lblPoint2.Text = StringMinus1(lblPoint2.Text);
                                TuneContinue();
                            }
                        }
                    }
                }
                catch (ObjectDisposedException)
                {
                }
            }
        }

        private void TuneContinue()
        {
            timerTune.Start();
            WMP.Ctlcontrols.play();
        }

        private string StringPlus1(string s)
        {
            return (Convert.ToInt32(s) + 1).ToString();
        }
        private string StringMinus1(string s)
        {
            return (Convert.ToInt32(s) - 1).ToString();
        }
        private void TunePause()
        {
            timerTune.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void GameOver()
        {
            HideForm(fA);
            timerGame.Stop();
            timerTune.Stop();
            WMP.Ctlcontrols.stop();
            this.Hide();
            int point1 = Convert.ToInt32(lblPoint1.Text);
            int point2 = Convert.ToInt32(lblPoint2.Text);
            if (point1 > point2) MessageBox.Show("Игра окончена!\nПобедил игрок номер 1");
            else if (point2 > point1) MessageBox.Show("Игра окончена!\nПобедил игрок номер 2");
            else MessageBox.Show("Игра окончена!\nПобедила дружба");
        }

        private void HideForm(Form formForClose)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Equals(formForClose))
                {
                    formForClose.Hide();
                    return;
                }
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
            {
                if (!NameThatTune.randomStart)
                    WMP.Ctlcontrols.currentPosition = random.Next(0, (int)WMP.currentMedia.duration / 2);

            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            if (lblGameDuration.Text == "0")
            {
                GameOver();
            }
            else lblGameDuration.Text = StringMinus1(lblGameDuration.Text);
        }

        private void lblPoint1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) (sender as Label).Text=StringPlus1((sender as Label).Text);
            else if (e.Button == MouseButtons.Right) (sender as Label).Text = StringMinus1((sender as Label).Text);
        }



    }
}
