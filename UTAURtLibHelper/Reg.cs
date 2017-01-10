using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
    }
}
