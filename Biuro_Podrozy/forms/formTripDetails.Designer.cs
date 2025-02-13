namespace Biuro_Podrozy.forms
{
    partial class formTripDetails
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
            lblPricePerPerson = new Label();
            btnBookTrip = new Button();
            lblTrip = new Label();
            pictureBox1 = new PictureBox();
            txtBoxMealIncluded = new TextBox();
            lblMealIncluded = new Label();
            txtBoxKindOfRoom = new TextBox();
            lblKindOfRoom = new Label();
            txtBoxDateOfEnd = new TextBox();
            lblDateOfEnd = new Label();
            txtBoxDateOfStart = new TextBox();
            lblDateOfStart = new Label();
            lblTripDetails = new Label();
            txtBoxAdditionalInfo = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPricePerPerson
            // 
            lblPricePerPerson.AutoSize = true;
            lblPricePerPerson.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPricePerPerson.Location = new Point(416, 510);
            lblPricePerPerson.Name = "lblPricePerPerson";
            lblPricePerPerson.Size = new Size(174, 25);
            lblPricePerPerson.TabIndex = 33;
            lblPricePerPerson.Text = "Cena za osobę: $$$";
            // 
            // btnBookTrip
            // 
            btnBookTrip.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookTrip.Location = new Point(102, 500);
            btnBookTrip.Name = "btnBookTrip";
            btnBookTrip.Size = new Size(140, 45);
            btnBookTrip.TabIndex = 32;
            btnBookTrip.Text = "Rezerwuj";
            btnBookTrip.UseVisualStyleBackColor = true;
            btnBookTrip.Click += btnBookTrip_Click;
            // 
            // lblTrip
            // 
            lblTrip.AutoSize = true;
            lblTrip.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrip.Location = new Point(416, 93);
            lblTrip.Name = "lblTrip";
            lblTrip.Size = new Size(144, 32);
            lblTrip.TabIndex = 31;
            lblTrip.Text = "Wycieczka 1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(416, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // txtBoxMealIncluded
            // 
            txtBoxMealIncluded.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxMealIncluded.Location = new Point(50, 332);
            txtBoxMealIncluded.Name = "txtBoxMealIncluded";
            txtBoxMealIncluded.ReadOnly = true;
            txtBoxMealIncluded.Size = new Size(256, 33);
            txtBoxMealIncluded.TabIndex = 25;
            txtBoxMealIncluded.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMealIncluded
            // 
            lblMealIncluded.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMealIncluded.Location = new Point(50, 306);
            lblMealIncluded.Name = "lblMealIncluded";
            lblMealIncluded.Size = new Size(256, 23);
            lblMealIncluded.TabIndex = 24;
            lblMealIncluded.Text = "Wliczone posiłki";
            lblMealIncluded.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxKindOfRoom
            // 
            txtBoxKindOfRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxKindOfRoom.Location = new Point(50, 264);
            txtBoxKindOfRoom.Name = "txtBoxKindOfRoom";
            txtBoxKindOfRoom.ReadOnly = true;
            txtBoxKindOfRoom.Size = new Size(256, 33);
            txtBoxKindOfRoom.TabIndex = 23;
            txtBoxKindOfRoom.TextAlign = HorizontalAlignment.Center;
            // 
            // lblKindOfRoom
            // 
            lblKindOfRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKindOfRoom.Location = new Point(50, 238);
            lblKindOfRoom.Name = "lblKindOfRoom";
            lblKindOfRoom.Size = new Size(256, 23);
            lblKindOfRoom.TabIndex = 22;
            lblKindOfRoom.Text = "Standard pokoju";
            lblKindOfRoom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxDateOfEnd
            // 
            txtBoxDateOfEnd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDateOfEnd.Location = new Point(50, 196);
            txtBoxDateOfEnd.Name = "txtBoxDateOfEnd";
            txtBoxDateOfEnd.ReadOnly = true;
            txtBoxDateOfEnd.Size = new Size(256, 33);
            txtBoxDateOfEnd.TabIndex = 21;
            txtBoxDateOfEnd.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDateOfEnd
            // 
            lblDateOfEnd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfEnd.Location = new Point(50, 170);
            lblDateOfEnd.Name = "lblDateOfEnd";
            lblDateOfEnd.Size = new Size(256, 23);
            lblDateOfEnd.TabIndex = 20;
            lblDateOfEnd.Text = "Data przyjazdu";
            lblDateOfEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxDateOfStart
            // 
            txtBoxDateOfStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDateOfStart.Location = new Point(50, 128);
            txtBoxDateOfStart.Name = "txtBoxDateOfStart";
            txtBoxDateOfStart.ReadOnly = true;
            txtBoxDateOfStart.Size = new Size(256, 33);
            txtBoxDateOfStart.TabIndex = 19;
            txtBoxDateOfStart.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDateOfStart
            // 
            lblDateOfStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfStart.Location = new Point(50, 102);
            lblDateOfStart.Name = "lblDateOfStart";
            lblDateOfStart.Size = new Size(256, 23);
            lblDateOfStart.TabIndex = 18;
            lblDateOfStart.Text = "Data  wyjazdu";
            lblDateOfStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTripDetails
            // 
            lblTripDetails.AutoSize = true;
            lblTripDetails.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTripDetails.Location = new Point(12, 21);
            lblTripDetails.Name = "lblTripDetails";
            lblTripDetails.Size = new Size(298, 45);
            lblTripDetails.TabIndex = 17;
            lblTripDetails.Text = "Szczegóły wycieczki";
            // 
            // txtBoxAdditionalInfo
            // 
            txtBoxAdditionalInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAdditionalInfo.Location = new Point(50, 400);
            txtBoxAdditionalInfo.Multiline = true;
            txtBoxAdditionalInfo.Name = "txtBoxAdditionalInfo";
            txtBoxAdditionalInfo.ReadOnly = true;
            txtBoxAdditionalInfo.Size = new Size(256, 68);
            txtBoxAdditionalInfo.TabIndex = 35;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 374);
            label1.Name = "label1";
            label1.Size = new Size(256, 23);
            label1.TabIndex = 34;
            label1.Text = "Dodatkowe informacje";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formTripDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 576);
            Controls.Add(txtBoxAdditionalInfo);
            Controls.Add(label1);
            Controls.Add(lblPricePerPerson);
            Controls.Add(btnBookTrip);
            Controls.Add(lblTrip);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxMealIncluded);
            Controls.Add(lblMealIncluded);
            Controls.Add(txtBoxKindOfRoom);
            Controls.Add(lblKindOfRoom);
            Controls.Add(txtBoxDateOfEnd);
            Controls.Add(lblDateOfEnd);
            Controls.Add(txtBoxDateOfStart);
            Controls.Add(lblDateOfStart);
            Controls.Add(lblTripDetails);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formTripDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biuro Podróży";
            FormClosed += formTripDetails_FormClosed;
            Load += formTripDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPricePerPerson;
        private Button btnBookTrip;
        private Label lblTrip;
        private PictureBox pictureBox1;
        private TextBox txtBoxMealIncluded;
        private Label lblMealIncluded;
        private TextBox txtBoxKindOfRoom;
        private Label lblKindOfRoom;
        private TextBox txtBoxDateOfEnd;
        private Label lblDateOfEnd;
        private TextBox txtBoxDateOfStart;
        private Label lblDateOfStart;
        private Label lblTripDetails;
        private TextBox txtBoxAdditionalInfo;
        private Label label1;
    }
}