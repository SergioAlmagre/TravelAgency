namespace TravelAgency
{
    partial class PrincipalFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFrom));
            menuStrip1 = new MenuStrip();
            companyAgreementToolStripMenuItem = new ToolStripMenuItem();
            pricesToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripUp = new ToolStrip();
            btnDeal = new ToolStripButton();
            btnPrices = new ToolStripButton();
            bntExit = new ToolStripButton();
            monthCalendar = new MonthCalendar();
            groupBoxTypeStay = new GroupBox();
            rboFullBoard = new RadioButton();
            rboHalfPension = new RadioButton();
            rboOnlySleep = new RadioButton();
            btnCalculate = new Button();
            pictureBox1 = new PictureBox();
            imageList = new ImageList(components);
            listBoxNameImages = new ListBox();
            numericUpDownPeople = new NumericUpDown();
            numericUpDownStars = new NumericUpDown();
            checkedListBoxExtra = new CheckedListBox();
            lblActivities = new Label();
            lblDestinations = new Label();
            lblTypeOfStay = new Label();
            lblPeoople = new Label();
            lblStars = new Label();
            txtBoxResum = new TextBox();
            btnValidate = new Button();
            statusStrip1 = new StatusStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            lblSystemTime = new ToolStripStatusLabel();
            lbl1 = new Label();
            lbl2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStripProgressBar1 = new ToolStripProgressBar();
            menuStrip1.SuspendLayout();
            toolStripUp.SuspendLayout();
            groupBoxTypeStay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStars).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { companyAgreementToolStripMenuItem, pricesToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(923, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // companyAgreementToolStripMenuItem
            // 
            companyAgreementToolStripMenuItem.Name = "companyAgreementToolStripMenuItem";
            companyAgreementToolStripMenuItem.Size = new Size(162, 24);
            companyAgreementToolStripMenuItem.Text = "Company agreement";
            // 
            // pricesToolStripMenuItem
            // 
            pricesToolStripMenuItem.Name = "pricesToolStripMenuItem";
            pricesToolStripMenuItem.Size = new Size(61, 24);
            pricesToolStripMenuItem.Text = "Prices";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStripUp
            // 
            toolStripUp.AutoSize = false;
            toolStripUp.ImageScalingSize = new Size(20, 20);
            toolStripUp.Items.AddRange(new ToolStripItem[] { btnDeal, btnPrices, bntExit });
            toolStripUp.Location = new Point(0, 30);
            toolStripUp.Name = "toolStripUp";
            toolStripUp.Size = new Size(923, 91);
            toolStripUp.TabIndex = 1;
            toolStripUp.Text = "toolStrip1";
            // 
            // btnDeal
            // 
            btnDeal.AutoSize = false;
            btnDeal.BackgroundImage = (Image)resources.GetObject("btnDeal.BackgroundImage");
            btnDeal.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeal.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeal.ImageTransparentColor = Color.Magenta;
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(65, 65);
            btnDeal.Text = "toolStripButton1";
            btnDeal.Click += btnDeal_Click;
            // 
            // btnPrices
            // 
            btnPrices.AutoSize = false;
            btnPrices.BackgroundImage = (Image)resources.GetObject("btnPrices.BackgroundImage");
            btnPrices.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrices.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPrices.ImageTransparentColor = Color.Magenta;
            btnPrices.Name = "btnPrices";
            btnPrices.Size = new Size(65, 65);
            btnPrices.Text = "toolStripButton1";
            btnPrices.Click += btnPrices_Click;
            // 
            // bntExit
            // 
            bntExit.AutoSize = false;
            bntExit.BackgroundImage = (Image)resources.GetObject("bntExit.BackgroundImage");
            bntExit.BackgroundImageLayout = ImageLayout.Stretch;
            bntExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bntExit.ImageTransparentColor = Color.Magenta;
            bntExit.Name = "bntExit";
            bntExit.Size = new Size(65, 65);
            bntExit.Text = "toolStripButton1";
            bntExit.Click += bntExit_Click;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(663, 329);
            monthCalendar.Margin = new Padding(10, 12, 10, 12);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 2;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // groupBoxTypeStay
            // 
            groupBoxTypeStay.BackColor = SystemColors.ButtonHighlight;
            groupBoxTypeStay.Controls.Add(rboFullBoard);
            groupBoxTypeStay.Controls.Add(rboHalfPension);
            groupBoxTypeStay.Controls.Add(rboOnlySleep);
            groupBoxTypeStay.Location = new Point(448, 371);
            groupBoxTypeStay.Margin = new Padding(3, 4, 3, 4);
            groupBoxTypeStay.Name = "groupBoxTypeStay";
            groupBoxTypeStay.Padding = new Padding(3, 4, 3, 4);
            groupBoxTypeStay.Size = new Size(176, 149);
            groupBoxTypeStay.TabIndex = 3;
            groupBoxTypeStay.TabStop = false;
            groupBoxTypeStay.Enter += groupBoxTypeStay_Enter;
            // 
            // rboFullBoard
            // 
            rboFullBoard.AutoSize = true;
            rboFullBoard.Location = new Point(29, 96);
            rboFullBoard.Margin = new Padding(3, 4, 3, 4);
            rboFullBoard.Name = "rboFullBoard";
            rboFullBoard.Size = new Size(97, 24);
            rboFullBoard.TabIndex = 2;
            rboFullBoard.TabStop = true;
            rboFullBoard.Text = "Full board";
            rboFullBoard.UseVisualStyleBackColor = true;
            // 
            // rboHalfPension
            // 
            rboHalfPension.AutoSize = true;
            rboHalfPension.Location = new Point(29, 63);
            rboHalfPension.Margin = new Padding(3, 4, 3, 4);
            rboHalfPension.Name = "rboHalfPension";
            rboHalfPension.Size = new Size(114, 24);
            rboHalfPension.TabIndex = 1;
            rboHalfPension.TabStop = true;
            rboHalfPension.Text = "Half pension";
            rboHalfPension.UseVisualStyleBackColor = true;
            // 
            // rboOnlySleep
            // 
            rboOnlySleep.AutoSize = true;
            rboOnlySleep.Location = new Point(29, 29);
            rboOnlySleep.Margin = new Padding(3, 4, 3, 4);
            rboOnlySleep.Name = "rboOnlySleep";
            rboOnlySleep.Size = new Size(99, 24);
            rboOnlySleep.TabIndex = 0;
            rboOnlySleep.TabStop = true;
            rboOnlySleep.Text = "Only sleep";
            rboOnlySleep.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ButtonHighlight;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Location = new Point(522, 659);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(360, 31);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 115);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 431);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "acropolis_atenas.jpg");
            imageList.Images.SetKeyName(1, "");
            imageList.Images.SetKeyName(2, "");
            imageList.Images.SetKeyName(3, "");
            imageList.Images.SetKeyName(4, "");
            imageList.Images.SetKeyName(5, "");
            // 
            // listBoxNameImages
            // 
            listBoxNameImages.FormattingEnabled = true;
            listBoxNameImages.ItemHeight = 20;
            listBoxNameImages.Items.AddRange(new object[] { "Acrópolis - Atenas", "Giza - Egypt", "Itza - Mexico", "Machu Picchu - Peru", "Petra - Jordan", "Taj Mahal - India" });
            listBoxNameImages.Location = new Point(448, 157);
            listBoxNameImages.Margin = new Padding(3, 4, 3, 4);
            listBoxNameImages.Name = "listBoxNameImages";
            listBoxNameImages.Size = new Size(175, 144);
            listBoxNameImages.TabIndex = 6;
            listBoxNameImages.Tag = "";
            listBoxNameImages.SelectedIndexChanged += listBoxNameImages_SelectedIndexChanged;
            // 
            // numericUpDownPeople
            // 
            numericUpDownPeople.Location = new Point(465, 581);
            numericUpDownPeople.Margin = new Padding(3, 4, 3, 4);
            numericUpDownPeople.Name = "numericUpDownPeople";
            numericUpDownPeople.Size = new Size(42, 27);
            numericUpDownPeople.TabIndex = 7;
            numericUpDownPeople.ValueChanged += numericUpDownPeople_ValueChanged;
            // 
            // numericUpDownStars
            // 
            numericUpDownStars.Location = new Point(706, 581);
            numericUpDownStars.Margin = new Padding(3, 4, 3, 4);
            numericUpDownStars.Name = "numericUpDownStars";
            numericUpDownStars.Size = new Size(42, 27);
            numericUpDownStars.TabIndex = 8;
            numericUpDownStars.ValueChanged += numericUpDownStars_ValueChanged;
            // 
            // checkedListBoxExtra
            // 
            checkedListBoxExtra.CheckOnClick = true;
            checkedListBoxExtra.FormattingEnabled = true;
            checkedListBoxExtra.Items.AddRange(new object[] { "Dinner & show", "Excursion", "Laundry", "Natur Adventure", "Spa" });
            checkedListBoxExtra.Location = new Point(689, 157);
            checkedListBoxExtra.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxExtra.Name = "checkedListBoxExtra";
            checkedListBoxExtra.Size = new Size(170, 136);
            checkedListBoxExtra.TabIndex = 9;
            checkedListBoxExtra.SelectedIndexChanged += checkedListBoxExtra_SelectedIndexChanged;
            // 
            // lblActivities
            // 
            lblActivities.AutoSize = true;
            lblActivities.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblActivities.Location = new Point(713, 116);
            lblActivities.Name = "lblActivities";
            lblActivities.Size = new Size(141, 34);
            lblActivities.TabIndex = 10;
            lblActivities.Text = "Activities";
            // 
            // lblDestinations
            // 
            lblDestinations.AutoSize = true;
            lblDestinations.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestinations.Location = new Point(448, 115);
            lblDestinations.Name = "lblDestinations";
            lblDestinations.Size = new Size(180, 34);
            lblDestinations.TabIndex = 11;
            lblDestinations.Text = "Destinations";
            // 
            // lblTypeOfStay
            // 
            lblTypeOfStay.AutoSize = true;
            lblTypeOfStay.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTypeOfStay.Location = new Point(441, 329);
            lblTypeOfStay.Name = "lblTypeOfStay";
            lblTypeOfStay.Size = new Size(201, 34);
            lblTypeOfStay.TabIndex = 12;
            lblTypeOfStay.Text = "Types of stay";
            // 
            // lblPeoople
            // 
            lblPeoople.AutoSize = true;
            lblPeoople.Font = new Font("MV Boli", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblPeoople.Location = new Point(522, 581);
            lblPeoople.Name = "lblPeoople";
            lblPeoople.Size = new Size(100, 31);
            lblPeoople.TabIndex = 13;
            lblPeoople.Text = "Peoople";
            // 
            // lblStars
            // 
            lblStars.AutoSize = true;
            lblStars.Font = new Font("MV Boli", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblStars.Location = new Point(774, 579);
            lblStars.Name = "lblStars";
            lblStars.Size = new Size(74, 31);
            lblStars.TabIndex = 14;
            lblStars.Text = "Stars";
            // 
            // txtBoxResum
            // 
            txtBoxResum.Location = new Point(0, 553);
            txtBoxResum.Margin = new Padding(3, 4, 3, 4);
            txtBoxResum.Multiline = true;
            txtBoxResum.Name = "txtBoxResum";
            txtBoxResum.Size = new Size(422, 213);
            txtBoxResum.TabIndex = 15;
            txtBoxResum.TextChanged += txtBoxResum_TextChanged;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.LightGreen;
            btnValidate.FlatStyle = FlatStyle.Popup;
            btnValidate.Location = new Point(522, 720);
            btnValidate.Margin = new Padding(3, 4, 3, 4);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(360, 31);
            btnValidate.TabIndex = 16;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripStatusLabel1, toolStripDropDownButton2, toolStripProgressBar1, lblSystemTime });
            statusStrip1.Location = new Point(0, 770);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(923, 26);
            statusStrip1.TabIndex = 18;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(34, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.IsLink = true;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(170, 20);
            toolStripStatusLabel1.Text = "mytravel@traveling.com";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.BackgroundImageLayout = ImageLayout.Stretch;
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(34, 24);
            toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // lblSystemTime
            // 
            lblSystemTime.Name = "lblSystemTime";
            lblSystemTime.Size = new Size(63, 20);
            lblSystemTime.Text = "00:00:00";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("MV Boli", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lbl1.Location = new Point(465, 655);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(34, 31);
            lbl1.TabIndex = 19;
            lbl1.Text = "1º";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("MV Boli", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lbl2.Location = new Point(459, 720);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(40, 31);
            lbl2.TabIndex = 20;
            lbl2.Text = "2º";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(600, 18);
            // 
            // PrincipalFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 796);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(statusStrip1);
            Controls.Add(btnValidate);
            Controls.Add(txtBoxResum);
            Controls.Add(lblStars);
            Controls.Add(lblPeoople);
            Controls.Add(lblTypeOfStay);
            Controls.Add(lblDestinations);
            Controls.Add(lblActivities);
            Controls.Add(checkedListBoxExtra);
            Controls.Add(numericUpDownStars);
            Controls.Add(numericUpDownPeople);
            Controls.Add(listBoxNameImages);
            Controls.Add(pictureBox1);
            Controls.Add(btnCalculate);
            Controls.Add(groupBoxTypeStay);
            Controls.Add(monthCalendar);
            Controls.Add(toolStripUp);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "PrincipalFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripUp.ResumeLayout(false);
            toolStripUp.PerformLayout();
            groupBoxTypeStay.ResumeLayout(false);
            groupBoxTypeStay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStars).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem companyAgreementToolStripMenuItem;
        private ToolStripMenuItem pricesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStripUp;
        private ToolStripButton btnDeal;
        private ToolStripButton btnPrices;
        private ToolStripButton bntExit;
        private MonthCalendar monthCalendar;
        private GroupBox groupBoxTypeStay;
        private RadioButton rboOnlySleep;
        private RadioButton rboFullBoard;
        private RadioButton rboHalfPension;
        private Button btnCalculate;
        private PictureBox pictureBox1;
        private ImageList imageList;
        private ListBox listBoxNameImages;
        private NumericUpDown numericUpDownPeople;
        private NumericUpDown numericUpDownStars;
        private CheckedListBox checkedListBoxExtra;
        private Label lblActivities;
        private Label lblDestinations;
        private Label lblTypeOfStay;
        private Label lblPeoople;
        private Label lblStars;
        private TextBox txtBoxResum;
        private Button btnValidate;
        private StatusStrip statusStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripStatusLabel lblSystemTime;
        private Label lbl1;
        private Label lbl2;
        private System.Windows.Forms.Timer timer1;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}