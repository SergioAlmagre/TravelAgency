namespace TravelAgency
{
    partial class ControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            destination = new TabControl();
            Destinations = new TabPage();
            grpAmountPeople = new GroupBox();
            lbl1Person = new Label();
            txt1Person = new TextBox();
            grpTypeOfStay = new GroupBox();
            lblFullBoard = new Label();
            lblHalfPension = new Label();
            lblOnlySleep = new Label();
            txtFullBoard = new TextBox();
            txtHalfPension = new TextBox();
            txtSleep = new TextBox();
            grpStars = new GroupBox();
            picRating = new PictureBox();
            txt5Star = new TextBox();
            txt4Star = new TextBox();
            txt3Star = new TextBox();
            txt2Star = new TextBox();
            txt1Star = new TextBox();
            grpDestinations = new GroupBox();
            txtTajMahal = new TextBox();
            lblTaj = new Label();
            txtPetra = new TextBox();
            lblPetra = new Label();
            txtMachuPiccu = new TextBox();
            lblMachu = new Label();
            txtItza = new TextBox();
            lblItza = new Label();
            txtGiza = new TextBox();
            lblGiza = new Label();
            lblAcropolis = new Label();
            txtAcoPrice = new TextBox();
            Activites = new TabPage();
            gprActivities = new GroupBox();
            lblSpa = new Label();
            lblNaturAdventure = new Label();
            lblLaundry = new Label();
            lblExcursion = new Label();
            lblDinner = new Label();
            txtSpa = new TextBox();
            txtNaturAdventure = new TextBox();
            txtLaundry = new TextBox();
            txtExcursion = new TextBox();
            txtBoxDinner = new TextBox();
            Dates = new TabPage();
            grpDaySeasson = new GroupBox();
            txtLow = new TextBox();
            txtMid = new TextBox();
            txtHight = new TextBox();
            label1 = new Label();
            lblMidSeason = new Label();
            lblHight = new Label();
            destination.SuspendLayout();
            Destinations.SuspendLayout();
            grpAmountPeople.SuspendLayout();
            grpTypeOfStay.SuspendLayout();
            grpStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRating).BeginInit();
            grpDestinations.SuspendLayout();
            Activites.SuspendLayout();
            gprActivities.SuspendLayout();
            Dates.SuspendLayout();
            grpDaySeasson.SuspendLayout();
            SuspendLayout();
            // 
            // destination
            // 
            destination.Controls.Add(Destinations);
            destination.Controls.Add(Activites);
            destination.Controls.Add(Dates);
            destination.Location = new Point(0, -2);
            destination.Margin = new Padding(3, 2, 3, 2);
            destination.Name = "destination";
            destination.SelectedIndex = 0;
            destination.Size = new Size(760, 458);
            destination.TabIndex = 1;
            // 
            // Destinations
            // 
            Destinations.BackColor = Color.Transparent;
            Destinations.BackgroundImage = (Image)resources.GetObject("Destinations.BackgroundImage");
            Destinations.Controls.Add(grpAmountPeople);
            Destinations.Controls.Add(grpTypeOfStay);
            Destinations.Controls.Add(grpStars);
            Destinations.Controls.Add(grpDestinations);
            Destinations.Location = new Point(4, 24);
            Destinations.Margin = new Padding(3, 2, 3, 2);
            Destinations.Name = "Destinations";
            Destinations.Padding = new Padding(3, 2, 3, 2);
            Destinations.Size = new Size(752, 430);
            Destinations.TabIndex = 0;
            Destinations.Text = "Destinations";
            // 
            // grpAmountPeople
            // 
            grpAmountPeople.BackColor = Color.Transparent;
            grpAmountPeople.Controls.Add(lbl1Person);
            grpAmountPeople.Controls.Add(txt1Person);
            grpAmountPeople.Location = new Point(385, 282);
            grpAmountPeople.Margin = new Padding(3, 2, 3, 2);
            grpAmountPeople.Name = "grpAmountPeople";
            grpAmountPeople.Padding = new Padding(3, 2, 3, 2);
            grpAmountPeople.Size = new Size(311, 86);
            grpAmountPeople.TabIndex = 3;
            grpAmountPeople.TabStop = false;
            grpAmountPeople.Text = "Amount people";
            // 
            // lbl1Person
            // 
            lbl1Person.AutoSize = true;
            lbl1Person.Location = new Point(47, 35);
            lbl1Person.Name = "lbl1Person";
            lbl1Person.Size = new Size(52, 15);
            lbl1Person.TabIndex = 18;
            lbl1Person.Text = "1 Person";
            // 
            // txt1Person
            // 
            txt1Person.Location = new Point(185, 30);
            txt1Person.Margin = new Padding(3, 2, 3, 2);
            txt1Person.Name = "txt1Person";
            txt1Person.Size = new Size(110, 23);
            txt1Person.TabIndex = 18;
            txt1Person.Text = "20";
            txt1Person.TextAlign = HorizontalAlignment.Center;
            txt1Person.TextChanged += txt1Person_TextChanged;
            // 
            // grpTypeOfStay
            // 
            grpTypeOfStay.Controls.Add(lblFullBoard);
            grpTypeOfStay.Controls.Add(lblHalfPension);
            grpTypeOfStay.Controls.Add(lblOnlySleep);
            grpTypeOfStay.Controls.Add(txtFullBoard);
            grpTypeOfStay.Controls.Add(txtHalfPension);
            grpTypeOfStay.Controls.Add(txtSleep);
            grpTypeOfStay.Location = new Point(26, 282);
            grpTypeOfStay.Margin = new Padding(3, 2, 3, 2);
            grpTypeOfStay.Name = "grpTypeOfStay";
            grpTypeOfStay.Padding = new Padding(3, 2, 3, 2);
            grpTypeOfStay.Size = new Size(321, 116);
            grpTypeOfStay.TabIndex = 2;
            grpTypeOfStay.TabStop = false;
            grpTypeOfStay.Text = "Type of stay";
            // 
            // lblFullBoard
            // 
            lblFullBoard.AutoSize = true;
            lblFullBoard.Location = new Point(25, 92);
            lblFullBoard.Name = "lblFullBoard";
            lblFullBoard.Size = new Size(60, 15);
            lblFullBoard.TabIndex = 17;
            lblFullBoard.Text = "Full board";
            // 
            // lblHalfPension
            // 
            lblHalfPension.AutoSize = true;
            lblHalfPension.Location = new Point(25, 60);
            lblHalfPension.Name = "lblHalfPension";
            lblHalfPension.Size = new Size(74, 15);
            lblHalfPension.TabIndex = 16;
            lblHalfPension.Text = "Half pension";
            // 
            // lblOnlySleep
            // 
            lblOnlySleep.AutoSize = true;
            lblOnlySleep.Location = new Point(25, 30);
            lblOnlySleep.Name = "lblOnlySleep";
            lblOnlySleep.Size = new Size(62, 15);
            lblOnlySleep.TabIndex = 15;
            lblOnlySleep.Text = "Only sleep";
            // 
            // txtFullBoard
            // 
            txtFullBoard.Location = new Point(176, 92);
            txtFullBoard.Margin = new Padding(3, 2, 3, 2);
            txtFullBoard.Name = "txtFullBoard";
            txtFullBoard.Size = new Size(110, 23);
            txtFullBoard.TabIndex = 14;
            txtFullBoard.Text = "60";
            txtFullBoard.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHalfPension
            // 
            txtHalfPension.Location = new Point(176, 60);
            txtHalfPension.Margin = new Padding(3, 2, 3, 2);
            txtHalfPension.Name = "txtHalfPension";
            txtHalfPension.Size = new Size(110, 23);
            txtHalfPension.TabIndex = 13;
            txtHalfPension.Text = "30";
            txtHalfPension.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSleep
            // 
            txtSleep.Location = new Point(177, 28);
            txtSleep.Margin = new Padding(3, 2, 3, 2);
            txtSleep.Name = "txtSleep";
            txtSleep.Size = new Size(110, 23);
            txtSleep.TabIndex = 12;
            txtSleep.Text = "20";
            txtSleep.TextAlign = HorizontalAlignment.Center;
            // 
            // grpStars
            // 
            grpStars.Controls.Add(picRating);
            grpStars.Controls.Add(txt5Star);
            grpStars.Controls.Add(txt4Star);
            grpStars.Controls.Add(txt3Star);
            grpStars.Controls.Add(txt2Star);
            grpStars.Controls.Add(txt1Star);
            grpStars.Location = new Point(385, 35);
            grpStars.Margin = new Padding(3, 2, 3, 2);
            grpStars.Name = "grpStars";
            grpStars.Padding = new Padding(3, 2, 3, 2);
            grpStars.Size = new Size(311, 218);
            grpStars.TabIndex = 1;
            grpStars.TabStop = false;
            grpStars.Text = "Stars";
            // 
            // picRating
            // 
            picRating.BackgroundImage = (Image)resources.GetObject("picRating.BackgroundImage");
            picRating.BackgroundImageLayout = ImageLayout.Stretch;
            picRating.Location = new Point(-23, -31);
            picRating.Margin = new Padding(3, 2, 3, 2);
            picRating.Name = "picRating";
            picRating.Size = new Size(202, 262);
            picRating.TabIndex = 17;
            picRating.TabStop = false;
            // 
            // txt5Star
            // 
            txt5Star.Location = new Point(185, 167);
            txt5Star.Margin = new Padding(3, 2, 3, 2);
            txt5Star.Name = "txt5Star";
            txt5Star.Size = new Size(110, 23);
            txt5Star.TabIndex = 16;
            txt5Star.Text = "80";
            txt5Star.TextAlign = HorizontalAlignment.Center;
            // 
            // txt4Star
            // 
            txt4Star.Location = new Point(185, 131);
            txt4Star.Margin = new Padding(3, 2, 3, 2);
            txt4Star.Name = "txt4Star";
            txt4Star.Size = new Size(110, 23);
            txt4Star.TabIndex = 15;
            txt4Star.Text = "60";
            txt4Star.TextAlign = HorizontalAlignment.Center;
            // 
            // txt3Star
            // 
            txt3Star.Location = new Point(185, 97);
            txt3Star.Margin = new Padding(3, 2, 3, 2);
            txt3Star.Name = "txt3Star";
            txt3Star.Size = new Size(110, 23);
            txt3Star.TabIndex = 14;
            txt3Star.Text = "40";
            txt3Star.TextAlign = HorizontalAlignment.Center;
            // 
            // txt2Star
            // 
            txt2Star.Location = new Point(185, 64);
            txt2Star.Margin = new Padding(3, 2, 3, 2);
            txt2Star.Name = "txt2Star";
            txt2Star.Size = new Size(110, 23);
            txt2Star.TabIndex = 13;
            txt2Star.Text = "30";
            txt2Star.TextAlign = HorizontalAlignment.Center;
            // 
            // txt1Star
            // 
            txt1Star.Location = new Point(185, 27);
            txt1Star.Margin = new Padding(3, 2, 3, 2);
            txt1Star.Name = "txt1Star";
            txt1Star.Size = new Size(110, 23);
            txt1Star.TabIndex = 12;
            txt1Star.Text = "20";
            txt1Star.TextAlign = HorizontalAlignment.Center;
            // 
            // grpDestinations
            // 
            grpDestinations.Controls.Add(txtTajMahal);
            grpDestinations.Controls.Add(lblTaj);
            grpDestinations.Controls.Add(txtPetra);
            grpDestinations.Controls.Add(lblPetra);
            grpDestinations.Controls.Add(txtMachuPiccu);
            grpDestinations.Controls.Add(lblMachu);
            grpDestinations.Controls.Add(txtItza);
            grpDestinations.Controls.Add(lblItza);
            grpDestinations.Controls.Add(txtGiza);
            grpDestinations.Controls.Add(lblGiza);
            grpDestinations.Controls.Add(lblAcropolis);
            grpDestinations.Controls.Add(txtAcoPrice);
            grpDestinations.Location = new Point(26, 35);
            grpDestinations.Margin = new Padding(3, 2, 3, 2);
            grpDestinations.Name = "grpDestinations";
            grpDestinations.Padding = new Padding(3, 2, 3, 2);
            grpDestinations.Size = new Size(321, 218);
            grpDestinations.TabIndex = 0;
            grpDestinations.TabStop = false;
            grpDestinations.Text = "Destinations prices";
            // 
            // txtTajMahal
            // 
            txtTajMahal.Location = new Point(177, 181);
            txtTajMahal.Margin = new Padding(3, 2, 3, 2);
            txtTajMahal.Name = "txtTajMahal";
            txtTajMahal.Size = new Size(110, 23);
            txtTajMahal.TabIndex = 11;
            txtTajMahal.Text = "600";
            txtTajMahal.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTaj
            // 
            lblTaj.AutoSize = true;
            lblTaj.Location = new Point(35, 183);
            lblTaj.Name = "lblTaj";
            lblTaj.Size = new Size(94, 15);
            lblTaj.TabIndex = 10;
            lblTaj.Text = "Taj Mahal - India";
            // 
            // txtPetra
            // 
            txtPetra.Location = new Point(177, 148);
            txtPetra.Margin = new Padding(3, 2, 3, 2);
            txtPetra.Name = "txtPetra";
            txtPetra.Size = new Size(110, 23);
            txtPetra.TabIndex = 9;
            txtPetra.Text = "200";
            txtPetra.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPetra
            // 
            lblPetra.AutoSize = true;
            lblPetra.Location = new Point(35, 151);
            lblPetra.Name = "lblPetra";
            lblPetra.Size = new Size(80, 15);
            lblPetra.TabIndex = 8;
            lblPetra.Text = "Petra - Jordan";
            // 
            // txtMachuPiccu
            // 
            txtMachuPiccu.Location = new Point(177, 121);
            txtMachuPiccu.Margin = new Padding(3, 2, 3, 2);
            txtMachuPiccu.Name = "txtMachuPiccu";
            txtMachuPiccu.Size = new Size(110, 23);
            txtMachuPiccu.TabIndex = 7;
            txtMachuPiccu.Text = "500";
            txtMachuPiccu.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMachu
            // 
            lblMachu.AutoSize = true;
            lblMachu.Location = new Point(35, 123);
            lblMachu.Name = "lblMachu";
            lblMachu.Size = new Size(111, 15);
            lblMachu.TabIndex = 6;
            lblMachu.Text = "Machu Piccu - Peru";
            // 
            // txtItza
            // 
            txtItza.Location = new Point(177, 94);
            txtItza.Margin = new Padding(3, 2, 3, 2);
            txtItza.Name = "txtItza";
            txtItza.Size = new Size(110, 23);
            txtItza.TabIndex = 5;
            txtItza.Text = "400";
            txtItza.TextAlign = HorizontalAlignment.Center;
            // 
            // lblItza
            // 
            lblItza.AutoSize = true;
            lblItza.Location = new Point(35, 97);
            lblItza.Name = "lblItza";
            lblItza.Size = new Size(75, 15);
            lblItza.TabIndex = 4;
            lblItza.Text = "Itza - Mexico";
            // 
            // txtGiza
            // 
            txtGiza.Location = new Point(176, 62);
            txtGiza.Margin = new Padding(3, 2, 3, 2);
            txtGiza.Name = "txtGiza";
            txtGiza.Size = new Size(110, 23);
            txtGiza.TabIndex = 3;
            txtGiza.Text = "300";
            txtGiza.TextAlign = HorizontalAlignment.Center;
            txtGiza.TextChanged += txtGiza_TextChanged;
            // 
            // lblGiza
            // 
            lblGiza.AutoSize = true;
            lblGiza.Location = new Point(34, 64);
            lblGiza.Name = "lblGiza";
            lblGiza.Size = new Size(63, 15);
            lblGiza.TabIndex = 2;
            lblGiza.Text = "Giza - Eypt";
            // 
            // lblAcropolis
            // 
            lblAcropolis.AutoSize = true;
            lblAcropolis.Location = new Point(34, 32);
            lblAcropolis.Name = "lblAcropolis";
            lblAcropolis.Size = new Size(104, 15);
            lblAcropolis.TabIndex = 1;
            lblAcropolis.Text = "Acrópolis - Atenas";
            // 
            // txtAcoPrice
            // 
            txtAcoPrice.Location = new Point(176, 30);
            txtAcoPrice.Margin = new Padding(3, 2, 3, 2);
            txtAcoPrice.Name = "txtAcoPrice";
            txtAcoPrice.Size = new Size(110, 23);
            txtAcoPrice.TabIndex = 0;
            txtAcoPrice.Text = "200";
            txtAcoPrice.TextAlign = HorizontalAlignment.Center;
            txtAcoPrice.TextChanged += txtAcoPrice_TextChanged;
            // 
            // Activites
            // 
            Activites.BackgroundImage = (Image)resources.GetObject("Activites.BackgroundImage");
            Activites.Controls.Add(gprActivities);
            Activites.Location = new Point(4, 24);
            Activites.Margin = new Padding(3, 2, 3, 2);
            Activites.Name = "Activites";
            Activites.Padding = new Padding(3, 2, 3, 2);
            Activites.Size = new Size(752, 430);
            Activites.TabIndex = 1;
            Activites.Text = "Activities";
            Activites.UseVisualStyleBackColor = true;
            // 
            // gprActivities
            // 
            gprActivities.Controls.Add(lblSpa);
            gprActivities.Controls.Add(lblNaturAdventure);
            gprActivities.Controls.Add(lblLaundry);
            gprActivities.Controls.Add(lblExcursion);
            gprActivities.Controls.Add(lblDinner);
            gprActivities.Controls.Add(txtSpa);
            gprActivities.Controls.Add(txtNaturAdventure);
            gprActivities.Controls.Add(txtLaundry);
            gprActivities.Controls.Add(txtExcursion);
            gprActivities.Controls.Add(txtBoxDinner);
            gprActivities.Location = new Point(222, 76);
            gprActivities.Margin = new Padding(3, 2, 3, 2);
            gprActivities.Name = "gprActivities";
            gprActivities.Padding = new Padding(3, 2, 3, 2);
            gprActivities.Size = new Size(304, 242);
            gprActivities.TabIndex = 0;
            gprActivities.TabStop = false;
            gprActivities.Text = "Activities";
            // 
            // lblSpa
            // 
            lblSpa.AutoSize = true;
            lblSpa.Location = new Point(23, 192);
            lblSpa.Name = "lblSpa";
            lblSpa.Size = new Size(26, 15);
            lblSpa.TabIndex = 9;
            lblSpa.Text = "Spa";
            // 
            // lblNaturAdventure
            // 
            lblNaturAdventure.AutoSize = true;
            lblNaturAdventure.Location = new Point(23, 155);
            lblNaturAdventure.Name = "lblNaturAdventure";
            lblNaturAdventure.Size = new Size(95, 15);
            lblNaturAdventure.TabIndex = 8;
            lblNaturAdventure.Text = "Natur Adventure";
            // 
            // lblLaundry
            // 
            lblLaundry.AutoSize = true;
            lblLaundry.Location = new Point(23, 114);
            lblLaundry.Name = "lblLaundry";
            lblLaundry.Size = new Size(50, 15);
            lblLaundry.TabIndex = 7;
            lblLaundry.Text = "Laundry";
            // 
            // lblExcursion
            // 
            lblExcursion.AutoSize = true;
            lblExcursion.Location = new Point(23, 77);
            lblExcursion.Name = "lblExcursion";
            lblExcursion.Size = new Size(63, 15);
            lblExcursion.TabIndex = 6;
            lblExcursion.Text = "Excursions";
            // 
            // lblDinner
            // 
            lblDinner.AutoSize = true;
            lblDinner.Location = new Point(23, 34);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new Size(96, 15);
            lblDinner.TabIndex = 5;
            lblDinner.Text = "Dinner and show";
            // 
            // txtSpa
            // 
            txtSpa.Location = new Point(151, 190);
            txtSpa.Margin = new Padding(3, 2, 3, 2);
            txtSpa.Name = "txtSpa";
            txtSpa.Size = new Size(110, 23);
            txtSpa.TabIndex = 4;
            txtSpa.Text = "40";
            txtSpa.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNaturAdventure
            // 
            txtNaturAdventure.Location = new Point(151, 153);
            txtNaturAdventure.Margin = new Padding(3, 2, 3, 2);
            txtNaturAdventure.Name = "txtNaturAdventure";
            txtNaturAdventure.Size = new Size(110, 23);
            txtNaturAdventure.TabIndex = 3;
            txtNaturAdventure.Text = "60";
            txtNaturAdventure.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLaundry
            // 
            txtLaundry.Location = new Point(151, 114);
            txtLaundry.Margin = new Padding(3, 2, 3, 2);
            txtLaundry.Name = "txtLaundry";
            txtLaundry.Size = new Size(110, 23);
            txtLaundry.TabIndex = 2;
            txtLaundry.Text = "15";
            txtLaundry.TextAlign = HorizontalAlignment.Center;
            // 
            // txtExcursion
            // 
            txtExcursion.Location = new Point(151, 75);
            txtExcursion.Margin = new Padding(3, 2, 3, 2);
            txtExcursion.Name = "txtExcursion";
            txtExcursion.Size = new Size(110, 23);
            txtExcursion.TabIndex = 1;
            txtExcursion.Text = "60";
            txtExcursion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxDinner
            // 
            txtBoxDinner.Location = new Point(151, 32);
            txtBoxDinner.Margin = new Padding(3, 2, 3, 2);
            txtBoxDinner.Name = "txtBoxDinner";
            txtBoxDinner.Size = new Size(110, 23);
            txtBoxDinner.TabIndex = 0;
            txtBoxDinner.Text = "50";
            txtBoxDinner.TextAlign = HorizontalAlignment.Center;
            // 
            // Dates
            // 
            Dates.BackgroundImage = (Image)resources.GetObject("Dates.BackgroundImage");
            Dates.Controls.Add(grpDaySeasson);
            Dates.Location = new Point(4, 24);
            Dates.Margin = new Padding(3, 2, 3, 2);
            Dates.Name = "Dates";
            Dates.Size = new Size(752, 430);
            Dates.TabIndex = 2;
            Dates.Text = "Dates";
            Dates.UseVisualStyleBackColor = true;
            // 
            // grpDaySeasson
            // 
            grpDaySeasson.Controls.Add(txtLow);
            grpDaySeasson.Controls.Add(txtMid);
            grpDaySeasson.Controls.Add(txtHight);
            grpDaySeasson.Controls.Add(label1);
            grpDaySeasson.Controls.Add(lblMidSeason);
            grpDaySeasson.Controls.Add(lblHight);
            grpDaySeasson.Location = new Point(167, 98);
            grpDaySeasson.Margin = new Padding(3, 2, 3, 2);
            grpDaySeasson.Name = "grpDaySeasson";
            grpDaySeasson.Padding = new Padding(3, 2, 3, 2);
            grpDaySeasson.Size = new Size(416, 181);
            grpDaySeasson.TabIndex = 0;
            grpDaySeasson.TabStop = false;
            grpDaySeasson.Text = "Day depending on the season";
            // 
            // txtLow
            // 
            txtLow.Location = new Point(266, 125);
            txtLow.Margin = new Padding(3, 2, 3, 2);
            txtLow.Name = "txtLow";
            txtLow.Size = new Size(110, 23);
            txtLow.TabIndex = 5;
            txtLow.Text = "10";
            txtLow.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMid
            // 
            txtMid.Location = new Point(266, 80);
            txtMid.Margin = new Padding(3, 2, 3, 2);
            txtMid.Name = "txtMid";
            txtMid.Size = new Size(110, 23);
            txtMid.TabIndex = 4;
            txtMid.Text = "30";
            txtMid.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHight
            // 
            txtHight.Location = new Point(266, 38);
            txtHight.Margin = new Padding(3, 2, 3, 2);
            txtHight.Name = "txtHight";
            txtHight.Size = new Size(110, 23);
            txtHight.TabIndex = 3;
            txtHight.Text = "50";
            txtHight.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 130);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 2;
            label1.Text = "Low (February - June)";
            // 
            // lblMidSeason
            // 
            lblMidSeason.AutoSize = true;
            lblMidSeason.Location = new Point(24, 85);
            lblMidSeason.Name = "lblMidSeason";
            lblMidSeason.Size = new Size(146, 15);
            lblMidSeason.TabIndex = 1;
            lblMidSeason.Text = "Mid (september - January)";
            // 
            // lblHight
            // 
            lblHight.AutoSize = true;
            lblHight.Location = new Point(24, 40);
            lblHight.Name = "lblHight";
            lblHight.Size = new Size(117, 15);
            lblHight.TabIndex = 0;
            lblHight.Text = "Hight (July - Auguts)";
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 452);
            Controls.Add(destination);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ControlPanel";
            Text = "ControlPanel";
            destination.ResumeLayout(false);
            Destinations.ResumeLayout(false);
            grpAmountPeople.ResumeLayout(false);
            grpAmountPeople.PerformLayout();
            grpTypeOfStay.ResumeLayout(false);
            grpTypeOfStay.PerformLayout();
            grpStars.ResumeLayout(false);
            grpStars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRating).EndInit();
            grpDestinations.ResumeLayout(false);
            grpDestinations.PerformLayout();
            Activites.ResumeLayout(false);
            gprActivities.ResumeLayout(false);
            gprActivities.PerformLayout();
            Dates.ResumeLayout(false);
            grpDaySeasson.ResumeLayout(false);
            grpDaySeasson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl destination;
        private TabPage Destinations;
        private TabPage Activites;
        private TabPage Dates;
        private GroupBox grpDestinations;
        private Label lblAcropolis;
        public TextBox txtAcoPrice;
        public TextBox txtTajMahal;
        private Label lblTaj;
        public TextBox txtPetra;
        private Label lblPetra;
        public TextBox txtMachuPiccu;
        private Label lblMachu;
        public TextBox txtItza;
        private Label lblItza;
        public TextBox txtGiza;
        private Label lblGiza;
        private GroupBox grpStars;
        public TextBox txt1Star;
        private GroupBox grpTypeOfStay;
        public TextBox txtFullBoard;
        public TextBox txtHalfPension;
        public TextBox txtSleep;
        public TextBox txt5Star;
        public TextBox txt4Star;
        public TextBox txt3Star;
        public TextBox txt2Star;
        private Label lblHalfPension;
        private Label lblOnlySleep;
        private GroupBox grpAmountPeople;
        private Label lbl1Person;
        public TextBox txt1Person;
        private Label lblFullBoard;
        private GroupBox gprActivities;
        public TextBox txtBoxDinner;
        private Label lblLaundry;
        private Label lblExcursion;
        private Label lblDinner;
        public TextBox txtSpa;
        public TextBox txtNaturAdventure;
        public TextBox txtLaundry;
        public TextBox txtExcursion;
        private Label lblSpa;
        private Label lblNaturAdventure;
        private GroupBox grpDaySeasson;
        public TextBox txtHight;
        private Label label1;
        private Label lblMidSeason;
        private Label lblHight;
        public TextBox txtLow;
        public TextBox txtMid;
        private PictureBox picRating;
    }
}