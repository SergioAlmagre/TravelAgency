using System.Windows.Forms;

namespace TravelAgency
{
    public partial class PrincipalFrom : Form
    {
        Boolean calculate = false;
        public PrincipalFrom()
        {
            InitializeComponent();
            pictureBox1.Image = imageList.Images[0];
            listBoxNameImages.SelectedIndex = 0;
            timer1.Start();


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

        private void checkedListBoxExtra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void groupBoxTypeStay_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDownPeople_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownStars_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {



        }

        private void btnValidate_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxResum_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSystemTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (calculate)
            {

            }
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            Agreement fmrAgreemnt = new Agreement();
            DialogResult result = fmrAgreemnt.ShowDialog();
        }

        private void btnPrices_Click(object sender, EventArgs e)
        {
            ControlPanel fmrControlPanel = new ControlPanel();
            DialogResult result = fmrControlPanel.ShowDialog();
        }
    }
}