using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTAURtLibHelper
{
    public partial class FormRegUst : Form
    {
        string utauFile = "";
        public FormRegUst()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void buttonOpenUTAUFile_Click(object sender, EventArgs e)
        {
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = false;
            DialogResult Result = openFileDialog.ShowDialog();
            if (Result == DialogResult.OK)
            {
                utauFile = openFileDialog.FileName;
                buttonRegFileLink.Enabled = true;
            }
        }

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

        private void buttonRegFileLink_Click(object sender, EventArgs e)
        {
            try
            {
                RegFile(utauFile, ".ust");
                RegFile(utauFile, ".uar");
                MessageBox.Show("注册成功");
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }

        private void buttonUnRegFileLink_Click(object sender, EventArgs e)
        {
            try
            {
                UnRegFile(".ust");
                UnRegFile(".uar");
                MessageBox.Show("反注册成功");
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }
    }
}
