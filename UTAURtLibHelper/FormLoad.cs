using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace UTAURtLibHelper
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            Thread.Sleep(500);
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void loadForm_Load(object sender, EventArgs e)
        {
            FxWin.EffectsWindows(Handle, 1300, FxWin.AW_BLEND);
        }

        private void timerShowMainForm_Tick(object sender, EventArgs e)
        {
            Opacity = 0;
            Form frmMain = new Form1();
            Hide();
            Thread.Sleep(100);
            frmMain.Show();
            timerShowMainForm.Enabled = false;
        }
    }
}
