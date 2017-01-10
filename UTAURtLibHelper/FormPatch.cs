using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UTAURtLibHelper
{
    public partial class FormPatch : Form
    {
        string FileName;
        string SystemFile = "";
        string WinFile;
        bool winType = Environment.Is64BitOperatingSystem;
        string Source = @".\lib\patch\";

        public FormPatch()
        {
            InitializeComponent();
        }

        private void FormPatch_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            DirectoryInfo folder = new DirectoryInfo(Source);

            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                listBox1.Items.Add(file.Name);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                FileName = listBox1.Text.ToString();
                if (winType == true)
                {
                    WinFile = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                    SystemFile = WinFile + @"\SysWOW64\";
                }
                if (winType == false)
                {
                    WinFile = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                    SystemFile = WinFile + @"\system32\";
                }
                if (FileName == null || FileName == "")
                {
                    MessageBox.Show("请选择文件");
                }
                else
                {
                    File.Copy(Source + FileName, SystemFile + FileName, false);

                    MessageBox.Show(FileName + " 文件写入成功。");
                }
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message + "\r\n" + FileName + " 文件未写入。");
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (FileName == null || FileName == "")
            {
                MessageBox.Show("请选择文件");
            }
            else
            {
                Reg.RegLib(SystemFile + FileName);
            }
        }
    }
}
