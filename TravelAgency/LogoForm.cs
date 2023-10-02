using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TravelAgency
{
    public partial class LogoForm : Form
    {
        public LogoForm()
        {
            InitializeComponent();
        }

        private void timerSpalsh_Tick(object sender, EventArgs e)
        {
            timerSpalsh.Stop();
            PrincipalFrom frmPrincipal = new PrincipalFrom();
            frmPrincipal.Show();
            this.Hide();
        }

        private void LogoForm_Shown(object sender, EventArgs e)
        {
            timerSpalsh.Start();
        }
    }
}
