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
            tabControl1 = new TabControl();
            Destinations = new TabPage();
            groupBox1 = new GroupBox();
            lblAcropolis = new Label();
            txtAcoPrice = new TextBox();
            Activites = new TabPage();
            Dates = new TabPage();
            lblGiza = new Label();
            txtGiza = new TextBox();
            textBox1 = new TextBox();
            lblItza = new Label();
            textBox2 = new TextBox();
            lblMachu = new Label();
            textBox3 = new TextBox();
            lblPetra = new Label();
            textBox4 = new TextBox();
            lblTaj = new Label();
            groupBox2 = new GroupBox();
            tabControl1.SuspendLayout();
            Destinations.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Destinations);
            tabControl1.Controls.Add(Activites);
            tabControl1.Controls.Add(Dates);
            tabControl1.Location = new Point(0, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(965, 611);
            tabControl1.TabIndex = 1;
            // 
            // Destinations
            // 
            Destinations.BackColor = Color.Transparent;
            Destinations.BackgroundImage = (Image)resources.GetObject("Destinations.BackgroundImage");
            Destinations.Controls.Add(groupBox2);
            Destinations.Controls.Add(groupBox1);
            Destinations.Location = new Point(4, 29);
            Destinations.Name = "Destinations";
            Destinations.Padding = new Padding(3);
            Destinations.Size = new Size(957, 578);
            Destinations.TabIndex = 0;
            Destinations.Text = "Destinations";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(lblTaj);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(lblPetra);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(lblMachu);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblItza);
            groupBox1.Controls.Add(txtGiza);
            groupBox1.Controls.Add(lblGiza);
            groupBox1.Controls.Add(lblAcropolis);
            groupBox1.Controls.Add(txtAcoPrice);
            groupBox1.Location = new Point(30, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Destinations prices";
            // 
            // lblAcropolis
            // 
            lblAcropolis.AutoSize = true;
            lblAcropolis.Location = new Point(39, 43);
            lblAcropolis.Name = "lblAcropolis";
            lblAcropolis.Size = new Size(131, 20);
            lblAcropolis.TabIndex = 1;
            lblAcropolis.Text = "Acrópolis - Atenas";
            // 
            // txtAcoPrice
            // 
            txtAcoPrice.Location = new Point(201, 40);
            txtAcoPrice.Name = "txtAcoPrice";
            txtAcoPrice.Size = new Size(125, 27);
            txtAcoPrice.TabIndex = 0;
            txtAcoPrice.TextChanged += txtAcoPrice_TextChanged;
            // 
            // Activites
            // 
            Activites.BackgroundImage = (Image)resources.GetObject("Activites.BackgroundImage");
            Activites.Location = new Point(4, 29);
            Activites.Name = "Activites";
            Activites.Padding = new Padding(3);
            Activites.Size = new Size(957, 578);
            Activites.TabIndex = 1;
            Activites.Text = "Activities";
            Activites.UseVisualStyleBackColor = true;
            // 
            // Dates
            // 
            Dates.BackgroundImage = (Image)resources.GetObject("Dates.BackgroundImage");
            Dates.Location = new Point(4, 29);
            Dates.Name = "Dates";
            Dates.Size = new Size(957, 578);
            Dates.TabIndex = 2;
            Dates.Text = "Dates";
            Dates.UseVisualStyleBackColor = true;
            // 
            // lblGiza
            // 
            lblGiza.AutoSize = true;
            lblGiza.Location = new Point(39, 86);
            lblGiza.Name = "lblGiza";
            lblGiza.Size = new Size(81, 20);
            lblGiza.TabIndex = 2;
            lblGiza.Text = "Giza - Eypt";
            // 
            // txtGiza
            // 
            txtGiza.Location = new Point(201, 83);
            txtGiza.Name = "txtGiza";
            txtGiza.Size = new Size(125, 27);
            txtGiza.TabIndex = 3;
            txtGiza.TextChanged += txtGiza_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // lblItza
            // 
            lblItza.AutoSize = true;
            lblItza.Location = new Point(40, 129);
            lblItza.Name = "lblItza";
            lblItza.Size = new Size(95, 20);
            lblItza.TabIndex = 4;
            lblItza.Text = "Itza - Mexico";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // lblMachu
            // 
            lblMachu.AutoSize = true;
            lblMachu.Location = new Point(40, 164);
            lblMachu.Name = "lblMachu";
            lblMachu.Size = new Size(133, 20);
            lblMachu.TabIndex = 6;
            lblMachu.Text = "Machu Piccu - Peru";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(202, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // lblPetra
            // 
            lblPetra.AutoSize = true;
            lblPetra.Location = new Point(40, 201);
            lblPetra.Name = "lblPetra";
            lblPetra.Size = new Size(100, 20);
            lblPetra.TabIndex = 8;
            lblPetra.Text = "Petra - Jordan";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(202, 241);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 11;
            // 
            // lblTaj
            // 
            lblTaj.AutoSize = true;
            lblTaj.Location = new Point(40, 244);
            lblTaj.Name = "lblTaj";
            lblTaj.Size = new Size(119, 20);
            lblTaj.TabIndex = 10;
            lblTaj.Text = "Taj Mahal - India";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(459, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 291);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stars";
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 604);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ControlPanel";
            Text = "ControlPanel";
            tabControl1.ResumeLayout(false);
            Destinations.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage Destinations;
        private TabPage Activites;
        private TabPage Dates;
        private GroupBox groupBox1;
        private Label lblAcropolis;
        private TextBox txtAcoPrice;
        private TextBox textBox4;
        private Label lblTaj;
        private TextBox textBox3;
        private Label lblPetra;
        private TextBox textBox2;
        private Label lblMachu;
        private TextBox textBox1;
        private Label lblItza;
        private TextBox txtGiza;
        private Label lblGiza;
        private GroupBox groupBox2;
    }
}