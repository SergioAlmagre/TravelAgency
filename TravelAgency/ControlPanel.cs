using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class ControlPanel : Form
    {
        private static ControlPanel onlyControlPanel;
        private ControlPanel()
        {
            InitializeComponent();
        }

        public static ControlPanel getInstance()
        {
            if (onlyControlPanel == null)
            {
                onlyControlPanel = new ControlPanel();
            }
            return onlyControlPanel;
        }

        private void txtAcoPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGiza_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt1Person_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
