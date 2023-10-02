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
            menuStrip1.SuspendLayout();
            toolStripUp.SuspendLayout();
            groupBoxTypeStay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStars).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { companyAgreementToolStripMenuItem, pricesToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(808, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // companyAgreementToolStripMenuItem
            // 
            companyAgreementToolStripMenuItem.Name = "companyAgreementToolStripMenuItem";
            companyAgreementToolStripMenuItem.Size = new Size(131, 20);
            companyAgreementToolStripMenuItem.Text = "Company agreement";
            // 
            // pricesToolStripMenuItem
            // 
            pricesToolStripMenuItem.Name = "pricesToolStripMenuItem";
            pricesToolStripMenuItem.Size = new Size(50, 20);
            pricesToolStripMenuItem.Text = "Prices";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStripUp
            // 
            toolStripUp.AutoSize = false;
            toolStripUp.Items.AddRange(new ToolStripItem[] { btnDeal, btnPrices, bntExit });
            toolStripUp.Location = new Point(0, 24);
            toolStripUp.Name = "toolStripUp";
            toolStripUp.Size = new Size(808, 68);
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
            monthCalendar.Location = new Point(580, 247);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 2;
            // 
            // groupBoxTypeStay
            // 
            groupBoxTypeStay.BackColor = SystemColors.ButtonHighlight;
            groupBoxTypeStay.Controls.Add(rboFullBoard);
            groupBoxTypeStay.Controls.Add(rboHalfPension);
            groupBoxTypeStay.Controls.Add(rboOnlySleep);
            groupBoxTypeStay.Location = new Point(392, 278);
            groupBoxTypeStay.Name = "groupBoxTypeStay";
            groupBoxTypeStay.Size = new Size(154, 112);
            groupBoxTypeStay.TabIndex = 3;
            groupBoxTypeStay.TabStop = false;
            // 
            // rboFullBoard
            // 
            rboFullBoard.AutoSize = true;
            rboFullBoard.Location = new Point(25, 72);
            rboFullBoard.Name = "rboFullBoard";
            rboFullBoard.Size = new Size(78, 19);
            rboFullBoard.TabIndex = 2;
            rboFullBoard.TabStop = true;
            rboFullBoard.Text = "Full board";
            rboFullBoard.UseVisualStyleBackColor = true;
            // 
            // rboHalfPension
            // 
            rboHalfPension.AutoSize = true;
            rboHalfPension.Location = new Point(25, 47);
            rboHalfPension.Name = "rboHalfPension";
            rboHalfPension.Size = new Size(92, 19);
            rboHalfPension.TabIndex = 1;
            rboHalfPension.TabStop = true;
            rboHalfPension.Text = "Half pension";
            rboHalfPension.UseVisualStyleBackColor = true;
            // 
            // rboOnlySleep
            // 
            rboOnlySleep.AutoSize = true;
            rboOnlySleep.Location = new Point(25, 22);
            rboOnlySleep.Name = "rboOnlySleep";
            rboOnlySleep.Size = new Size(80, 19);
            rboOnlySleep.TabIndex = 0;
            rboOnlySleep.TabStop = true;
            rboOnlySleep.Text = "Only sleep";
            rboOnlySleep.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ButtonHighlight;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Location = new Point(407, 499);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(365, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 323);
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
            imageList.Images.SetKeyName(1, "guiza_egipto.jpg");
            imageList.Images.SetKeyName(2, "itza_mejico.jpg");
            imageList.Images.SetKeyName(3, "machupiccu_peru.jpg");
            imageList.Images.SetKeyName(4, "petra_jordania.jpg");
            imageList.Images.SetKeyName(5, "tajmahal_india.jpg");
            // 
            // listBoxNameImages
            // 
            listBoxNameImages.FormattingEnabled = true;
            listBoxNameImages.ItemHeight = 15;
            listBoxNameImages.Items.AddRange(new object[] { "Acrópolis - Atenas", "Giza - Egypt", "Itza - Mexico", "Machu Picchu - Peru", "Petra - Jordan", "Taj Mahal - India" });
            listBoxNameImages.Location = new Point(392, 118);
            listBoxNameImages.Name = "listBoxNameImages";
            listBoxNameImages.Size = new Size(154, 109);
            listBoxNameImages.TabIndex = 6;
            listBoxNameImages.Tag = "";
            listBoxNameImages.SelectedIndexChanged += listBoxNameImages_SelectedIndexChanged;
            // 
            // numericUpDownPeople
            // 
            numericUpDownPeople.Location = new Point(407, 436);
            numericUpDownPeople.Name = "numericUpDownPeople";
            numericUpDownPeople.Size = new Size(37, 23);
            numericUpDownPeople.TabIndex = 7;
            // 
            // numericUpDownStars
            // 
            numericUpDownStars.Location = new Point(618, 436);
            numericUpDownStars.Name = "numericUpDownStars";
            numericUpDownStars.Size = new Size(37, 23);
            numericUpDownStars.TabIndex = 8;
            // 
            // checkedListBoxExtra
            // 
            checkedListBoxExtra.FormattingEnabled = true;
            checkedListBoxExtra.Items.AddRange(new object[] { "Dinner & show", "Excursion", "Laundry", "Natur Adventure", "Spa" });
            checkedListBoxExtra.Location = new Point(603, 118);
            checkedListBoxExtra.Name = "checkedListBoxExtra";
            checkedListBoxExtra.Size = new Size(149, 112);
            checkedListBoxExtra.TabIndex = 9;
            // 
            // lblActivities
            // 
            lblActivities.AutoSize = true;
            lblActivities.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblActivities.Location = new Point(624, 87);
            lblActivities.Name = "lblActivities";
            lblActivities.Size = new Size(112, 28);
            lblActivities.TabIndex = 10;
            lblActivities.Text = "Activities";
            // 
            // lblDestinations
            // 
            lblDestinations.AutoSize = true;
            lblDestinations.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestinations.Location = new Point(392, 86);
            lblDestinations.Name = "lblDestinations";
            lblDestinations.Size = new Size(144, 28);
            lblDestinations.TabIndex = 11;
            lblDestinations.Text = "Destinations";
            // 
            // lblTypeOfStay
            // 
            lblTypeOfStay.AutoSize = true;
            lblTypeOfStay.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTypeOfStay.Location = new Point(386, 247);
            lblTypeOfStay.Name = "lblTypeOfStay";
            lblTypeOfStay.Size = new Size(160, 28);
            lblTypeOfStay.TabIndex = 12;
            lblTypeOfStay.Text = "Types of stay";
            // 
            // lblPeoople
            // 
            lblPeoople.AutoSize = true;
            lblPeoople.Font = new Font("MV Boli", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblPeoople.Location = new Point(457, 436);
            lblPeoople.Name = "lblPeoople";
            lblPeoople.Size = new Size(79, 25);
            lblPeoople.TabIndex = 13;
            lblPeoople.Text = "Peoople";
            // 
            // lblStars
            // 
            lblStars.AutoSize = true;
            lblStars.Font = new Font("MV Boli", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblStars.Location = new Point(677, 434);
            lblStars.Name = "lblStars";
            lblStars.Size = new Size(59, 25);
            lblStars.TabIndex = 14;
            lblStars.Text = "Stars";
            // 
            // txtBoxResum
            // 
            txtBoxResum.Location = new Point(0, 415);
            txtBoxResum.Multiline = true;
            txtBoxResum.Name = "txtBoxResum";
            txtBoxResum.Size = new Size(370, 161);
            txtBoxResum.TabIndex = 15;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.LightGreen;
            btnValidate.FlatStyle = FlatStyle.Popup;
            btnValidate.Location = new Point(407, 553);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(365, 23);
            btnValidate.TabIndex = 16;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            // 
            // PrincipalFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 612);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}