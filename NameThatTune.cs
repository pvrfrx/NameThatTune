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
        static public List<string> listMusic = new List<string>();

        static string regKeyName = "Software\\PavelR\\NameThatTune";
        public static void WriteSettings(string nameRegister, object valueRegister)
        {
            try
            {
                Registry.CurrentUser.CreateSubKey(regKeyName).SetValue(nameRegister, valueRegister);
            }
            catch (Exception)
            {
                return;
            }
        }

        public static object ReadSettings(string nameRegister)
        { 
            try
            {
                return Registry.CurrentUser.OpenSubKey(regKeyName).GetValue(nameRegister);
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
