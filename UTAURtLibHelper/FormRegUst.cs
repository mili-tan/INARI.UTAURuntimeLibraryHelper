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

        private void buttonRegFileLink_Click(object sender, EventArgs e)
        {
            try
            {
                RegUst.RegFile(utauFile, ".ust");
                RegUst.RegFile(utauFile, ".uar");
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
                RegUst.UnRegFile(".ust");
                RegUst.UnRegFile(".uar");
                MessageBox.Show("反注册成功");
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }
    }
}
