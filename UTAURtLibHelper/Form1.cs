using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace UTAURtLibHelper
{
    public partial class Form1 : Form
    {
        string Source = @".\lib\";
        string SystemFile;
        bool winType;

        bool TestDlg32Reg;
        bool TestDlg32File;
        bool TestComCTLReg;
        bool TestComCTLFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            RegistryKey regKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
            lbWinVer.Text = Environment.OSVersion.ToString();
            winType = Environment.Is64BitOperatingSystem;
            string WinFile = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            if (winType == true)
            {
                lbWintypeT.Text = "操作系统为 64 位 " + regKey.GetValue("ProductName").ToString();
                SystemFile = WinFile + @"\SysWOW64\";
            }
            if (winType == false)
            {
                lbWintypeT.Text = "操作系统为 32 位 " + regKey.GetValue("ProductName").ToString();
                SystemFile = WinFile + @"\System32\";
            }
            lbSystemFile.Text = "系统环境位置： " + SystemFile;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
            Environment.Exit(0);
        }

        private void btnCOMDLG32_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(Source + "COMDLG32.OCX", SystemFile + "COMDLG32.OCX", false);
                MessageBox.Show("COMDLG32.OCX 写入成功");
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message + "\r\nCOMDLG32.OCX 文件未写入");
            }

            Reg.RegLib(SystemFile + "COMDLG32.OCX");
        }

        private void btnMSCOMCTL_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(Source + "MSCOMCTL.OCX", SystemFile + "MSCOMCTL.OCX", false);
                MessageBox.Show("MSCOMCTL.OCX 写入成功");
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message + "\r\nMSCOMCTL.OCX 文件未写入");
            }

            Reg.RegLib(SystemFile + "MSCOMCTL.OCX");
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            testFileAndReg();
            if (TestDlg32Reg)
            {
                lbCOMDLG32RegOn.Text = "已注册";
                lbCOMDLG32RegOn.ForeColor = Color.Green;
            }
            else
            {
                lbCOMDLG32RegOn.Text = "未注册";
                lbCOMDLG32RegOn.ForeColor = Color.Orange;
            }

            if (TestComCTLReg)
            {
                lbMSCOMCTLRegOn.Text = "已注册";
                lbMSCOMCTLRegOn.ForeColor = Color.Green;
            }
            else
            {
                lbMSCOMCTLRegOn.Text = "未注册";
                lbMSCOMCTLRegOn.ForeColor = Color.Orange;
            }

            if (TestComCTLFile)
            {
                lbMSCOMCTLFileOn.Text = "已存在";
                lbMSCOMCTLFileOn.ForeColor = Color.YellowGreen;
            }
            else
            {
                lbMSCOMCTLFileOn.Text = "未存在";
                lbMSCOMCTLFileOn.ForeColor = Color.Red;
            }

            if (TestDlg32File)
            {
                lbCOMDLG32FileOn.Text = "已存在";
                lbCOMDLG32FileOn.ForeColor = Color.YellowGreen;
            }
            else
            {
                lbCOMDLG32FileOn.Text = "未存在";
                lbCOMDLG32FileOn.ForeColor = Color.Red;
            }

        }

        private void btnRegSomeThing_Click(object sender, EventArgs e)
        {
            FormBlockHoles frmBH = new FormBlockHoles();
            frmBH.Show();
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            FormPatch frmPatch = new FormPatch();
            frmPatch.Show();
        }

        private void btnCOMDLG32_MouseDown(object sender, MouseEventArgs MouseE)
        {
            if (MouseE.Button == MouseButtons.Right || MouseE.Button == MouseButtons.Middle)
            {
                DialogResult Res = MessageBox.Show("是否反注册COMDLG32.OCX？", "反注册", MessageBoxButtons.OKCancel);
                if (Res == DialogResult.OK)
                {
                    Reg.UnRegLib(SystemFile + "COMDLG32.OCX");
                }
            }
        }

        private bool testRegistredOcx(string strKey)
        {
            RegistryKey keyRoot = Registry.ClassesRoot;
            string ocxKey = strKey;
            RegistryKey rkOcx = keyRoot.OpenSubKey(ocxKey);
            if (rkOcx != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void testFileAndReg()
        {
            TestDlg32File = File.Exists(@SystemFile + "COMDLG32.OCX");
            TestDlg32Reg = testRegistredOcx(@"TypeLib\{F9043C88-F6F2-101A-A3C9-08002B2F49FB}\1.2\0\win32");
            TestComCTLFile = File.Exists(@SystemFile + "MSCOMCTL.OCX");
            TestComCTLReg = testRegistredOcx(@"TypeLib\{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}\2.0");
        }

        private void btnMSCOMCTL_MouseDown(object sender, MouseEventArgs MouseE)
        {
            if (MouseE.Button == MouseButtons.Right || MouseE.Button == MouseButtons.Middle)
            {
                DialogResult Res = MessageBox.Show("是否反注册MSCOMCTL.OCX？", "反注册", MessageBoxButtons.OKCancel);
                if (Res == DialogResult.OK)
                {
                    Reg.UnRegLib(SystemFile + "MSCOMCTL.OCX");
                }
            }
        }

        private void btnOneKey_Click(object sender, EventArgs e)
        {
            if (TestDlg32File == false)
            {
                try
                {
                    File.Copy(Source + "COMDLG32.OCX", SystemFile + "COMDLG32.OCX", false);
                    MessageBox.Show("缺失的COMDLG32.OCX 写入成功");
                }
                catch (Exception errorMsg)
                {
                    MessageBox.Show(errorMsg.Message + "\r\nCOMDLG32.OCX 文件未写入");
                }
            }
            if (TestDlg32Reg == false)
            {
                Reg.RegLib(SystemFile + "COMDLG32.OCX");
            }
            else if (TestDlg32Reg == true && TestDlg32File == true)
            {
                MessageBox.Show("COMDLG32.OCX 无需修复");
            }

            if (TestComCTLFile == false)
            {
                try
                {
                    File.Copy(Source + "MSCOMCTL.OCX", SystemFile + "MSCOMCTL.OCX", false);
                    MessageBox.Show("MSCOMCTL.OCX 写入成功");
                }
                catch (Exception errorMsg)
                {
                    MessageBox.Show(errorMsg.Message + "\r\nMSCOMCTL.OCX 文件未写入");
                }
            }
            if (TestComCTLReg == false)
            {
                Reg.RegLib(SystemFile + "MSCOMCTL.OCX");
            }
            else if (TestComCTLReg == true && TestComCTLFile == true)
            {
                MessageBox.Show("MSCOMCTL.OCX 无需修复");
            }
            testFileAndReg();
        }
    }
}
