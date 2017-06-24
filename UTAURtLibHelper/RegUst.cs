using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTAURtLibHelper
{
    class RegUst
    {
        public static void RegFile(string filePathStr, string fileTypeName)
        {
            RegistryKey regKey = Registry.ClassesRoot.OpenSubKey("", true);
            RegistryKey cmdKey = regKey.OpenSubKey(fileTypeName, true);
            if (cmdKey != null)
            {
                regKey.DeleteSubKey(fileTypeName, true);
            }
            regKey.CreateSubKey(fileTypeName);
            cmdKey = regKey.OpenSubKey(fileTypeName, true);
            cmdKey.SetValue("", "Exec");
            cmdKey = regKey.OpenSubKey("Exec", true);
            if (cmdKey != null) regKey.DeleteSubKeyTree("Exec");
            regKey.CreateSubKey("Exec");
            cmdKey = regKey.OpenSubKey("Exec", true);
            cmdKey.CreateSubKey("shell");
            cmdKey = cmdKey.OpenSubKey("shell", true);
            cmdKey.CreateSubKey("open");
            cmdKey = cmdKey.OpenSubKey("open", true);
            cmdKey.CreateSubKey("command");
            cmdKey = cmdKey.OpenSubKey("command", true);
            string pathStr = "\"" + filePathStr + "\" \"%1\"";
            cmdKey.SetValue("", pathStr);
        }

        public static void UnRegFile(string fileTypeName)
        {
            RegistryKey regKey = Registry.ClassesRoot.OpenSubKey("", true);
            RegistryKey cmdKey = regKey.OpenSubKey(fileTypeName);
            if (cmdKey != null)
            {
                regKey.DeleteSubKey(fileTypeName, true);
            }
            if (cmdKey != null)
            {
                regKey.DeleteSubKeyTree("Exec");
            }
        }
    }
}
