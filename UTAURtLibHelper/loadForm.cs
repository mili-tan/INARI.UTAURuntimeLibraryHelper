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
        double transparent = 1.30;
        public loadForm()
        {
            Thread.Sleep(500);
            InitializeComponent();
        }

        private void loadForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            timerTransparent.Enabled = true;
        }

        private void timerTransparent_Tick(object sender, EventArgs e)
        {
            transparent = transparent - 0.01;
            this.Opacity = transparent;
            if (transparent == 0)
            {
                timerTransparent.Enabled = false;
            }
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
