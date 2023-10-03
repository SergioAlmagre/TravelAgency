namespace TravelAgency
{
    partial class Agreement
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
            txtBoxInfo = new TextBox();
            lblAcept = new Button();
            SuspendLayout();
            // 
            // txtBoxInfo
            // 
            txtBoxInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxInfo.Location = new Point(33, 33);
            txtBoxInfo.Multiline = true;
            txtBoxInfo.Name = "txtBoxInfo";
            txtBoxInfo.Size = new Size(468, 225);
            txtBoxInfo.TabIndex = 0;
            txtBoxInfo.Text = "This company will return 50% in case of\r\nthat on the chosen days there is a strike\r\nTransportation and/or hotels and affect the trip\r\n\r\n                                                  The company";
            txtBoxInfo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAcept
            // 
            lblAcept.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcept.ForeColor = SystemColors.ActiveCaptionText;
            lblAcept.Location = new Point(175, 280);
            lblAcept.Name = "lblAcept";
            lblAcept.Size = new Size(177, 40);
            lblAcept.TabIndex = 1;
            lblAcept.Text = "Acept";
            lblAcept.UseVisualStyleBackColor = true;
            lblAcept.Click += lblAcept_Click;
            // 
            // Agreement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(540, 356);
            Controls.Add(lblAcept);
            Controls.Add(txtBoxInfo);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agreement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agreement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInfo;
        private Button lblAcept;
    }
}