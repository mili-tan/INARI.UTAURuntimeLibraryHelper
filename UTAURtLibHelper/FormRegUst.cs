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
        }

        private void buttonOpenUTAUFile_Click(object sender, EventArgs e)
        {
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = false;
            DialogResult Result = openFileDialog.ShowDialog();
            if (Result == DialogResult.OK)
            {
                utauFile = openFileDialog.FileName;
            }
        }
    }
}
