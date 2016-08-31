using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;

namespace NameThatTune
{
    static class NameThatTune
    {
        //параметры реестра для хранения настроек
        static string regGameDuration = "Game Duration";
        static string regTuneDuration = "Game Tune";
        static string regRandomStart = "Random Start";
        static string regRepeatTune = "Repeat Tune";
        static string regAllDirection = "All Direction";
        static string regLastPath = "Last Path";
        //ветка реестра
        static string regKeyName = "Software\\PavelR\\NameThatTune";

        //настройки программы
        static public List<string> listMusic = new List<string>();
        static public int gameDuration=0;// = 60;(int)ReadSettings(regGameDuration);
        static public int tuneDuration=0;// = (int)ReadSettings(regTuneDuration);
        static public bool randomStart=false; //= Convert.ToBoolean(ReadSettings(regRandomStart));
        static public bool repeatTune= false; //= Convert.ToBoolean(ReadSettings(regRepeatTune));
        static public bool allDirection= false;// = Convert.ToBoolean(ReadSettings(regAllDirection));
        static public string lastPath= "";// = ReadSettings(regLastPath).ToString();


        //получение параметров реестра, для записей значений в них
        public static string GetRegGameDuration() { return regGameDuration; }
        public static string GetRegTuneDuration() { return regTuneDuration; }
        public static string GetRegRandomStart() { return regRandomStart; }
        public static string GetRegRepeatTune() { return regRepeatTune; }
        public static string GetRegAllDirection() { return regAllDirection; }
        public static string GetRegLastPath() { return regLastPath; }

        public static void WriteSettings()
        {
            try
            {
                Registry.CurrentUser.CreateSubKey(regKeyName).SetValue(regGameDuration, gameDuration);
                Registry.CurrentUser.CreateSubKey(regKeyName).SetValue(regTuneDuration, tuneDuration);
                Registry.CurrentUser.CreateSubKey(regKeyName).SetValue(regRandomStart, randomStart);
                Registry.CurrentUser.CreateSubKey(regKeyName).SetValue(regRepeatTune, repeatTune);
                Registry.CurrentUser.CreateSubKey(regKeyName).SetValue(regAllDirection, allDirection);
                Registry.CurrentUser.CreateSubKey(regKeyName).SetValue(regLastPath, lastPath);
            }
            catch (Exception)
            {
                return;
            }
        }

        public static void ReadSettings()
        {
            try
            {
                gameDuration = Convert.ToInt32(Registry.CurrentUser.OpenSubKey(regKeyName).GetValue(regGameDuration));
                tuneDuration = Convert.ToInt32(Registry.CurrentUser.OpenSubKey(regKeyName).GetValue(regTuneDuration));
                randomStart = Convert.ToBoolean(Registry.CurrentUser.OpenSubKey(regKeyName).GetValue(regRandomStart));
                repeatTune = Convert.ToBoolean(Registry.CurrentUser.OpenSubKey(regKeyName).GetValue(regRepeatTune));
                allDirection = Convert.ToBoolean(Registry.CurrentUser.OpenSubKey(regKeyName).GetValue(regAllDirection));
                lastPath = Registry.CurrentUser.OpenSubKey(regKeyName).GetValue(regLastPath).ToString();
            }
            catch (Exception)
            {
            }
        }    
    }
}
