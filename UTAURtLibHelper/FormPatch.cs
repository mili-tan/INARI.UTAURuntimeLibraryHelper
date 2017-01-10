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
        public FormPatch()
        {
            InitializeComponent();
        }

        private void FormPatch_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            DirectoryInfo folder = new DirectoryInfo(@".\lib\patch");

            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                listBox1.Items.Add(file.Name);
            }
        }
    }
}
