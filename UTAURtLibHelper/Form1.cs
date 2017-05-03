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
        string utauFile = "";
        bool winType;
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

        private void timerTest_Tick(object sender, EventArgs e)
        {
            if (testRegistredOcx(@"CLSID\{F9043C85-F6F2-101A-A3C9-08002B2F49FB}"))
            {
                lbCOMDLG32RegOn.Text = "已注册";
                lbCOMDLG32RegOn.ForeColor = Color.Green;
            }
            else
            {
                lbCOMDLG32RegOn.Text = "未注册";
                lbCOMDLG32RegOn.ForeColor = Color.Red;
            }

            if (testRegistredOcx(@"TypeLib\{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}\2.0"))
            {
                lbMSCOMCTLRegOn.Text = "已注册";
                lbMSCOMCTLRegOn.ForeColor = Color.Green;
            }
            else
            {
                lbMSCOMCTLRegOn.Text = "未注册";
                lbMSCOMCTLRegOn.ForeColor = Color.Red;
            }

            if (File.Exists(@SystemFile + "MSCOMCTL.OCX"))
            {
                lbMSCOMCTLFileOn.Text = "已存在";
                lbMSCOMCTLFileOn.ForeColor = Color.Green;
            }
            else
            {
                lbMSCOMCTLFileOn.Text = "未存在";
                lbMSCOMCTLFileOn.ForeColor = Color.Yellow;
            }

            if (File.Exists(@SystemFile + "MSCOMCTL.OCX"))
            {
                lbMSCOMCTLFileOn.Text = "已存在";
                lbMSCOMCTLFileOn.ForeColor = Color.YellowGreen;
            }
            else
            {
                lbMSCOMCTLFileOn.Text = "未存在";
                lbMSCOMCTLFileOn.ForeColor = Color.Red;
            }

            if (File.Exists(@SystemFile + "COMDLG32.OCX"))
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

        }
    }
}
