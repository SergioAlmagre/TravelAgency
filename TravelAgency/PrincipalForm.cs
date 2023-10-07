using System.Collections;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class PrincipalFrom : Form
    {
        ControlPanel controlPrices = ControlPanel.getInstance();
        Boolean calculate = false;
        int priceStay = 0;
        int priceStar = 0;
        int priceNumberPeople = 0;
        int priceDestination = 0;
        int priceActivities = 0;
        int priceSeasson = 0;
        int pricePerson = 0;

        String destinationChoosedStr = "";
        String activitieChoosedStr = "";
        String stayChoosedStr = "";
        String numberPeopleChoosedStr = "";
        String numberStarChoosedStr = "";
        String nameSeasson = "";
        String cadFinal = "";

        String cadDestination = "";
        String cadStay = "";
        String cadPeople = "";
        String cadStar = "";
        String cadActi = "";
        String cadSeasson = "";
        String cadTotal = "";

        DateTime travelDate = DateTime.Now;
        int[] hightSeason = { 7, 8 };
        int[] midSeason = { 9, 10, 11, 12, 1 };
        int[] lowSeason = { 2, 3, 4, 5, 6 };
        int time = 0;

        public PrincipalFrom()
        {
            InitializeComponent();
            pictureBox1.Image = imageList.Images[0];
            listBoxNameImages.SelectedIndex = 0;
            timer1.Start();

            int.TryParse(controlPrices.txt1Star.Text, out priceStar);

            int.TryParse(controlPrices.txt1Person.Text, out pricePerson);
            priceNumberPeople = (int)(pricePerson * numericUpDownPeople.Value);

            rboOnlySleep.Checked = true;

        }

        private void listBoxNameImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectIndex = listBoxNameImages.SelectedIndex;
            if (selectIndex >= 0 && selectIndex < listBoxNameImages.Items.Count)
            {
                pictureBox1.Image = imageList.Images[selectIndex];
            }
            switch (selectIndex)
            {
                case 0:
                    int.TryParse(controlPrices.txtAcoPrice.Text, out priceDestination);

                    break;
                case 1:
                    int.TryParse(controlPrices.txtGiza.Text, out priceDestination);
                    break;
                case 2:
                    int.TryParse(controlPrices.txtItza.Text, out priceDestination);
                    break;
                case 3:
                    int.TryParse(controlPrices.txtMachuPiccu.Text, out priceDestination);
                    break;
                case 4:
                    int.TryParse(controlPrices.txtPetra.Text, out priceDestination);
                    break;
                case 5:
                    int.TryParse(controlPrices.txtTajMahal.Text, out priceDestination);
                    break;

            }
            destinationChoosedStr = listBoxNameImages.SelectedItem.ToString();
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


            List<string> actiListStr = new List<string>();
            int price = 0;

            foreach (object itemChecked in checkedListBoxExtra.Items)
            {
                String name = itemChecked.ToString() + ", ";
                actiListStr.Add(name);

            }
            Console.WriteLine(checkedListBoxExtra.CheckedItems.Count);

            if (checkedListBoxExtra.CheckedItems.Count == 0)
            {
                priceActivities = 0;
                activitieChoosedStr = "";
                price = 0;
            }
            else
            {
                int index = checkedListBoxExtra.SelectedIndex;

                switch (index)
                {
                    case 0:
                        int.TryParse(controlPrices.txtBoxDinner.Text, out price);
                        activitieChoosedStr += actiListStr[index];
                        priceActivities += price;
                        break;
                    case 1:
                        int.TryParse(controlPrices.txtExcursion.Text, out price);
                        activitieChoosedStr += actiListStr[index];
                        priceActivities += price;
                        break;
                    case 2:
                        int.TryParse(controlPrices.txtLaundry.Text, out price);
                        activitieChoosedStr += actiListStr[index];
                        priceActivities += price;
                        break;
                    case 3:
                        int.TryParse(controlPrices.txtNaturAdventure.Text, out price);
                        activitieChoosedStr += actiListStr[index];
                        priceActivities += price;
                        break;
                    case 4:
                        int.TryParse(controlPrices.txtSpa.Text, out price);
                        activitieChoosedStr += actiListStr[index];
                        priceActivities += price;
                        break;
                }
            }
        }


        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            travelDate = monthCalendar.SelectionStart;
            int travelMonth = travelDate.Month;

            foreach (int h in hightSeason)
            {
                if (travelMonth == h)
                {
                    int.TryParse(controlPrices.txtHight.Text, out priceSeasson);
                    nameSeasson = "Hight season";
                    break;
                }
                foreach (int m in midSeason)
                {
                    if (travelMonth == m)
                    {
                        int.TryParse(controlPrices.txtMid.Text, out priceSeasson);
                        nameSeasson = "Mid season";
                        break;
                    }
                    foreach (int l in lowSeason)
                    {
                        if (travelMonth == l)
                        {
                            int.TryParse(controlPrices.txtLow.Text, out priceSeasson);
                            nameSeasson = "Low season";
                            break;
                        }
                    }

                }
            }

        }

        private void groupBoxTypeStay_Enter(object sender, EventArgs e)
        {
        }

        private void numericUpDownPeople_ValueChanged(object sender, EventArgs e)
        {

            int.TryParse(controlPrices.txt1Person.Text, out pricePerson);
            numberPeopleChoosedStr = numericUpDownPeople.Value.ToString();
            priceNumberPeople = (int)(pricePerson * numericUpDownPeople.Value);

        }

        private void numericUpDownStars_ValueChanged(object sender, EventArgs e)
        {
            switch (numericUpDownStars.Value)
            {
                case 1:
                    int.TryParse(controlPrices.txt1Star.Text, out priceStar);
                    numberStarChoosedStr = numericUpDownStars.Value.ToString();
                    break;
                case 2:
                    int.TryParse(controlPrices.txt2Star.Text, out priceStar);
                    numberStarChoosedStr = numericUpDownStars.Value.ToString();
                    break;
                case 3:
                    int.TryParse(controlPrices.txt3Star.Text, out priceStar);
                    numberStarChoosedStr = numericUpDownStars.Value.ToString();
                    break;
                case 4:
                    int.TryParse(controlPrices.txt4Star.Text, out priceStar);
                    numberStarChoosedStr = numericUpDownStars.Value.ToString();
                    break;
                case 5:
                    int.TryParse(controlPrices.txt5Star.Text, out priceStar);
                    numberStarChoosedStr = numericUpDownStars.Value.ToString();
                    break;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtBoxResum.Text = "";
            cadFinal = "";

            String intro = "\r\n";
            String eu = "€";
            int total = priceDestination + priceStay + priceNumberPeople + priceStar + priceActivities + priceSeasson;

            cadDestination = "Destination: " + destinationChoosedStr + " Price: " + priceDestination.ToString() + eu + intro;
            cadStay = "Type of stay: " + stayChoosedStr + " Price: " + priceStay.ToString() + eu + intro;
            cadPeople = "Number of people: " + numberPeopleChoosedStr + " Price: " + priceNumberPeople + eu + intro;
            cadStar = "Number of stars: " + numberStarChoosedStr + " Price: " + priceStar + eu + intro;
            cadActi = "Activities: " + activitieChoosedStr + " Price " + priceActivities + eu + intro;
            cadSeasson = "Seasson: " + nameSeasson + " Price " + priceSeasson + eu + intro + intro;
            cadTotal = "Total:___________ " + total + eu;

            calculate = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSystemTime.Text = DateTime.Now.ToString("HH:mm:ss");

            if (calculate)
            {
                progressBar.Value = time;
                switch (time)
                {
                    case 0:
                        cadFinal += cadDestination;
                        txtBoxResum.Text = cadFinal;
                        break;
                    case 1:
                        cadFinal += cadStay;
                        txtBoxResum.Text = cadFinal;
                        break;
                    case 2:
                        cadFinal += cadStar;
                        txtBoxResum.Text = cadFinal;
                        break;
                    case 3:
                        cadFinal += cadPeople;
                        txtBoxResum.Text = cadFinal;
                        break;
                    case 4:
                        cadFinal += cadActi;
                        txtBoxResum.Text = cadFinal;
                        break;
                    case 5:
                        cadFinal += cadSeasson;
                        txtBoxResum.Text = cadFinal;
                        break;
                    case 6:
                        cadFinal += cadTotal;
                        txtBoxResum.Text = cadFinal;
                        break;
                }
                time++;

                if (time > 6)
                {
                    progressBar.Value = 0;
                    calculate = false;
                    time = 0;
                }
            }


        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            Agreement fmrAgreemnt = new Agreement();
            DialogResult result = fmrAgreemnt.ShowDialog();
        }

        private void btnPrices_Click(object sender, EventArgs e)
        {
            controlPrices.ShowDialog();
        }

        private void rboOnlySleep_CheckedChanged(object sender, EventArgs e)
        {
            int.TryParse(controlPrices.txtSleep.Text, out priceStay);
            stayChoosedStr = rboOnlySleep.Text;
        }

        private void rboHalfPension_CheckedChanged(object sender, EventArgs e)
        {
            int.TryParse(controlPrices.txtHalfPension.Text, out priceStay);
            stayChoosedStr = rboHalfPension.Text;
        }

        private void rboFullBoard_CheckedChanged(object sender, EventArgs e)
        {
            int.TryParse(controlPrices.txtFullBoard.Text, out priceStay);
            stayChoosedStr = rboFullBoard.Text;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxResum_TextChanged(object sender, EventArgs e)
        {
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            string destinatario = "info@traveling.com";
            string asunto = "I want to travel with you";

            //string comando = $"mailto:{destinatario}?subject={asunto}";
            //Process.Start(new ProcessStartInfo(comando));
        }
    }
}