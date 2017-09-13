using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;

namespace UTAURtLibHelper
{
    class RegRun
    {
        public static void RegLib(string path)
        {
            Process p = new Process();
            p.StartInfo.FileName = "Regsvr32.exe";
            p.StartInfo.Arguments = path;
            p.Start();
        }
        public static void UnRegLib(string path)
        {
            Process p = new Process();
            p.StartInfo.FileName = "Regsvr32.exe";
            p.StartInfo.Arguments = "/u " + path;
            p.Start();
        }
        public static bool RegTest(string strKey)
        {
            RegistryKey keyRoot = Registry.ClassesRoot;
            string ocxKey = strKey;
            RegistryKey rkOcx = keyRoot.OpenSubKey(ocxKey);
            if (rkOcx == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void resLib()
        {
            if (!Directory.Exists(@".\lib"))
            {
                Directory.CreateDirectory(@".\lib");
            }
            if (!File.Exists(@".\lib\COMDLG32.ocx"))
            {
                byte[] Save = Properties.Resources.COMDLG32;
                FileStream fileStream = new FileStream(@".\lib\COMDLG32.ocx", FileMode.CreateNew);
                fileStream.Write(Save, 0, Save.Length);
                fileStream.Close();
            }
            if (!File.Exists(@".\lib\MSCOMCTL.ocx"))
            {
                byte[] Save = Properties.Resources.MSCOMCTL;
                FileStream fileStream = new FileStream(@".\lib\MSCOMCTL.ocx", FileMode.CreateNew);
                fileStream.Write(Save, 0, Save.Length);
                fileStream.Close();
            }
        }
    }
}
