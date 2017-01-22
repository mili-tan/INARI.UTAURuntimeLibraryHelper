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

namespace UTAURtLibHelper
{
    public partial class loadForm : System.Windows.Forms.Form
    {
        public loadForm()
        {
            Thread.Sleep(500);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void loadForm_Load(object sender, EventArgs e)
        {
            TsWin.EffectsWindows(this.Handle, 1300, TsWin.AW_BLEND);
        }

        private void timerShowMainForm_Tick(object sender, EventArgs e)
        {
            this.Opacity = 0;
            System.Windows.Forms.Form frmMain = new Form1();
            this.Hide();
            Thread.Sleep(100);
            frmMain.Show();
            timerShowMainForm.Enabled = false;
        }
    }
}
