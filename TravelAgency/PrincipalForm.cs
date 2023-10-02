using System.Windows.Forms;

namespace TravelAgency
{
    public partial class PrincipalFrom : Form
    {
        public PrincipalFrom()
        {
            InitializeComponent();
            listBoxNameImages.SelectedIndexChanged += listBoxNameImages_SelectedIndexChanged;
        }

        private void listBoxNameImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectIndex = listBoxNameImages.SelectedIndex;
            if (selectIndex >= 0 && selectIndex < listBoxNameImages.Items.Count)
            {
                pictureBox1.Image = imageList.Images[selectIndex];
            }

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}