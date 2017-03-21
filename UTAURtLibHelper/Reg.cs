using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Win32;

namespace UTAURtLibHelper
{
    class Reg
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
    }
}
