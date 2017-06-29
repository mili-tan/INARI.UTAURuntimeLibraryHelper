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
    public partial class FormLauncher : Form
    {
        bool TestDlg32Reg;
        bool TestComCTLReg;
        string utauFile;

        public FormLauncher(string pathString)
        {
            InitializeComponent();

            TestDlg32Reg = RegRun.RegTest(@"TypeLib\{F9043C88-F6F2-101A-A3C9-08002B2F49FB}\1.2\0\win32");
            TestComCTLReg = RegRun.RegTest(@"TypeLib\{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}\2.0");
            utauFile = pathString;
            notifyIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void FormLauncher_Load(object sender, EventArgs e)
        {
            if (!TestDlg32Reg)
            {
                RegRun.RegLib("/s " + Application.StartupPath + "/lib/COMDLG32.OCX");
            }
            if (!TestComCTLReg)
            {
                RegRun.RegLib("/s " + Application.StartupPath + "/lib/MSCOMCTL.OCX");
            }

            //try
            //{
            //    RegUst.RegFile(utauFile, ".ust");
            //    RegUst.RegFile(utauFile, ".uar");
            //}
            //catch (Exception errorMsg)
            //{
            //    MessageBox.Show(errorMsg.Message);
            //}

            WindowState = FormWindowState.Minimized;

            ShowInTaskbar = false;
            notifyIcon.Visible = true;
        }

        private void FormLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!TestDlg32Reg)
            {
                RegRun.UnRegLib("/s " + Application.StartupPath + "/lib/COMDLG32.OCX");
            }
            if (!TestComCTLReg)
            {
                RegRun.UnRegLib("/s " + Application.StartupPath + "/lib/MSCOMCTL.OCX");
            }

            //try
            //{
            //    RegUst.UnRegFile(".ust");
            //    RegUst.UnRegFile(".uar");
            //}
            //catch (Exception errorMsg)
            //{
            //    MessageBox.Show(errorMsg.Message);
            //}
            MessageBox.Show("已退出并清理");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
