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
        }

        private void FormLauncher_Load(object sender, EventArgs e)
        {
            if (TestDlg32Reg == false)
            {
                RegRun.RegLib("/s " + Application.StartupPath + "/lib/COMDLG32.OCX");
            }
            if (TestComCTLReg == false)
            {
                RegRun.RegLib("/s " + Application.StartupPath + "/lib/MSCOMCTL.OCX");
            }

            try
            {
                RegUst.RegFile(utauFile, ".ust");
                RegUst.RegFile(utauFile, ".uar");
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }
    }
}
