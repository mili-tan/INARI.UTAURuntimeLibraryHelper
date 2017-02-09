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
using OneSet.EffectsWindow;

namespace UTAURtLibHelper
{
    public partial class loadForm : System.Windows.Forms.Form
    {
        public loadForm()
        {
            Thread.Sleep(500);
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void loadForm_Load(object sender, EventArgs e)
        {
            Fx.EffectsWindow(Handle, 1300, Fx.AW_BLEND);
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
