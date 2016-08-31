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
                    WMP.URL = NameThatTune.listMusic[random.Next()];
                    WMP.Ctlcontrols.play();
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

        private void GameOver()
        {
            throw new NotImplementedException();
        }

        private void fGame_Shown(object sender, EventArgs e)
        {

        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
            WMP.close();
        }
    }
}
