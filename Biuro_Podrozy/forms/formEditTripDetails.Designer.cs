namespace Biuro_Podrozy.forms
{
    partial class formEditTripDetails
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
            label1 = new Label();
            lblPricePerPerson = new Label();
            btnBookTrip = new Button();
            lblTrip = new Label();
            pictureBox1 = new PictureBox();
            lblKindOfRoom = new Label();
            lblDateOfEnd = new Label();
            lblDateOfStart = new Label();
            lblTripDetails = new Label();
            dateTimePickerDateOfStart = new DateTimePicker();
            dateTimePickerDateOfEnd = new DateTimePicker();
            comboKindOfRoom = new ComboBox();
            checkBoxWiFi = new CheckBox();
            checkBoxAC = new CheckBox();
            checkBoxKidsEntertainment = new CheckBox();
            btnChangePhoto = new Button();
            txtBoxPricePerPerson = new TextBox();
            checkBoxIsAvailable = new CheckBox();
            checkBoxMealIncluded = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 319);
            label1.Name = "label1";
            label1.Size = new Size(256, 23);
            label1.TabIndex = 49;
            label1.Text = "Dodatkowe informacje";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPricePerPerson
            // 
            lblPricePerPerson.AutoSize = true;
            lblPricePerPerson.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPricePerPerson.Location = new Point(416, 411);
            lblPricePerPerson.Name = "lblPricePerPerson";
            lblPricePerPerson.Size = new Size(139, 25);
            lblPricePerPerson.TabIndex = 48;
            lblPricePerPerson.Text = "Cena za osobę:";
            // 
            // btnBookTrip
            // 
            btnBookTrip.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookTrip.Location = new Point(297, 500);
            btnBookTrip.Name = "btnBookTrip";
            btnBookTrip.Size = new Size(140, 45);
            btnBookTrip.TabIndex = 47;
            btnBookTrip.Text = "Zapisz zmiany";
            btnBookTrip.UseVisualStyleBackColor = true;
            btnBookTrip.Click += btnBookTrip_Click;
            // 
            // lblTrip
            // 
            lblTrip.AutoSize = true;
            lblTrip.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrip.Location = new Point(498, 95);
            lblTrip.Name = "lblTrip";
            lblTrip.Size = new Size(144, 32);
            lblTrip.TabIndex = 46;
            lblTrip.Text = "Wycieczka 1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(416, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // lblKindOfRoom
            // 
            lblKindOfRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKindOfRoom.Location = new Point(50, 229);
            lblKindOfRoom.Name = "lblKindOfRoom";
            lblKindOfRoom.Size = new Size(256, 23);
            lblKindOfRoom.TabIndex = 41;
            lblKindOfRoom.Text = "Standard pokoju";
            lblKindOfRoom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateOfEnd
            // 
            lblDateOfEnd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfEnd.Location = new Point(50, 165);
            lblDateOfEnd.Name = "lblDateOfEnd";
            lblDateOfEnd.Size = new Size(256, 23);
            lblDateOfEnd.TabIndex = 39;
            lblDateOfEnd.Text = "Data przyjazdu";
            lblDateOfEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateOfStart
            // 
            lblDateOfStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfStart.Location = new Point(50, 102);
            lblDateOfStart.Name = "lblDateOfStart";
            lblDateOfStart.Size = new Size(256, 23);
            lblDateOfStart.TabIndex = 37;
            lblDateOfStart.Text = "Data  wyjazdu";
            lblDateOfStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTripDetails
            // 
            lblTripDetails.AutoSize = true;
            lblTripDetails.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTripDetails.Location = new Point(12, 21);
            lblTripDetails.Name = "lblTripDetails";
            lblTripDetails.Size = new Size(392, 45);
            lblTripDetails.TabIndex = 36;
            lblTripDetails.Text = "Edytuj szczegóły wycieczki";
            // 
            // dateTimePickerDateOfStart
            // 
            dateTimePickerDateOfStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerDateOfStart.Location = new Point(50, 128);
            dateTimePickerDateOfStart.Name = "dateTimePickerDateOfStart";
            dateTimePickerDateOfStart.Size = new Size(256, 29);
            dateTimePickerDateOfStart.TabIndex = 51;
            // 
            // dateTimePickerDateOfEnd
            // 
            dateTimePickerDateOfEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerDateOfEnd.Location = new Point(50, 191);
            dateTimePickerDateOfEnd.Name = "dateTimePickerDateOfEnd";
            dateTimePickerDateOfEnd.Size = new Size(256, 29);
            dateTimePickerDateOfEnd.TabIndex = 52;
            // 
            // comboKindOfRoom
            // 
            comboKindOfRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboKindOfRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboKindOfRoom.FormattingEnabled = true;
            comboKindOfRoom.Items.AddRange(new object[] { "Standard", "Deluxe", "Premium" });
            comboKindOfRoom.Location = new Point(50, 255);
            comboKindOfRoom.Name = "comboKindOfRoom";
            comboKindOfRoom.Size = new Size(256, 29);
            comboKindOfRoom.TabIndex = 53;
            // 
            // checkBoxWiFi
            // 
            checkBoxWiFi.AutoSize = true;
            checkBoxWiFi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxWiFi.Location = new Point(50, 392);
            checkBoxWiFi.Name = "checkBoxWiFi";
            checkBoxWiFi.Size = new Size(60, 25);
            checkBoxWiFi.TabIndex = 55;
            checkBoxWiFi.Text = "WiFi";
            checkBoxWiFi.UseVisualStyleBackColor = true;
            // 
            // checkBoxAC
            // 
            checkBoxAC.AutoSize = true;
            checkBoxAC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAC.Location = new Point(50, 423);
            checkBoxAC.Name = "checkBoxAC";
            checkBoxAC.Size = new Size(115, 25);
            checkBoxAC.TabIndex = 56;
            checkBoxAC.Text = "Klimatyzacja";
            checkBoxAC.UseVisualStyleBackColor = true;
            // 
            // checkBoxKidsEntertainment
            // 
            checkBoxKidsEntertainment.AutoSize = true;
            checkBoxKidsEntertainment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxKidsEntertainment.Location = new Point(50, 454);
            checkBoxKidsEntertainment.Name = "checkBoxKidsEntertainment";
            checkBoxKidsEntertainment.Size = new Size(153, 25);
            checkBoxKidsEntertainment.TabIndex = 57;
            checkBoxKidsEntertainment.Text = "Atrakcje dla dzieci";
            checkBoxKidsEntertainment.UseVisualStyleBackColor = true;
            // 
            // btnChangePhoto
            // 
            btnChangePhoto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangePhoto.Location = new Point(498, 338);
            btnChangePhoto.Name = "btnChangePhoto";
            btnChangePhoto.Size = new Size(144, 45);
            btnChangePhoto.TabIndex = 58;
            btnChangePhoto.Text = "Zmień zdjęcie";
            btnChangePhoto.UseVisualStyleBackColor = true;
            btnChangePhoto.Click += btnChangePhoto_Click;
            // 
            // txtBoxPricePerPerson
            // 
            txtBoxPricePerPerson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPricePerPerson.Location = new Point(561, 411);
            txtBoxPricePerPerson.Name = "txtBoxPricePerPerson";
            txtBoxPricePerPerson.Size = new Size(100, 29);
            txtBoxPricePerPerson.TabIndex = 59;
            txtBoxPricePerPerson.TextAlign = HorizontalAlignment.Right;
            txtBoxPricePerPerson.KeyPress += txtBoxPricePerPerson_KeyPress;
            // 
            // checkBoxIsAvailable
            // 
            checkBoxIsAvailable.AutoSize = true;
            checkBoxIsAvailable.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxIsAvailable.Location = new Point(416, 451);
            checkBoxIsAvailable.Name = "checkBoxIsAvailable";
            checkBoxIsAvailable.Size = new Size(202, 29);
            checkBoxIsAvailable.TabIndex = 60;
            checkBoxIsAvailable.Text = "Ogłoszenie aktualne";
            checkBoxIsAvailable.UseVisualStyleBackColor = true;
            // 
            // checkBoxMealIncluded
            // 
            checkBoxMealIncluded.AutoSize = true;
            checkBoxMealIncluded.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMealIncluded.Location = new Point(50, 361);
            checkBoxMealIncluded.Name = "checkBoxMealIncluded";
            checkBoxMealIncluded.Size = new Size(168, 25);
            checkBoxMealIncluded.TabIndex = 61;
            checkBoxMealIncluded.Text = "Wyżywienie w cenie";
            checkBoxMealIncluded.UseVisualStyleBackColor = true;
            // 
            // formEditTripDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 576);
            Controls.Add(checkBoxMealIncluded);
            Controls.Add(checkBoxIsAvailable);
            Controls.Add(txtBoxPricePerPerson);
            Controls.Add(btnChangePhoto);
            Controls.Add(checkBoxKidsEntertainment);
            Controls.Add(checkBoxAC);
            Controls.Add(checkBoxWiFi);
            Controls.Add(comboKindOfRoom);
            Controls.Add(dateTimePickerDateOfEnd);
            Controls.Add(dateTimePickerDateOfStart);
            Controls.Add(label1);
            Controls.Add(lblPricePerPerson);
            Controls.Add(btnBookTrip);
            Controls.Add(lblTrip);
            Controls.Add(pictureBox1);
            Controls.Add(lblKindOfRoom);
            Controls.Add(lblDateOfEnd);
            Controls.Add(lblDateOfStart);
            Controls.Add(lblTripDetails);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formEditTripDetails";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += formEditTripDetails_FormClosed;
            Load += formEditTripDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblPricePerPerson;
        private Button btnBookTrip;
        private Label lblTrip;
        private PictureBox pictureBox1;
        private Label lblKindOfRoom;
        private Label lblDateOfEnd;
        private Label lblDateOfStart;
        private Label lblTripDetails;
        private DateTimePicker dateTimePickerDateOfStart;
        private DateTimePicker dateTimePickerDateOfEnd;
        private ComboBox comboKindOfRoom;
        private CheckBox checkBoxWiFi;
        private CheckBox checkBoxAC;
        private CheckBox checkBoxKidsEntertainment;
        private Button btnChangePhoto;
        private TextBox txtBoxPricePerPerson;
        private CheckBox checkBoxIsAvailable;
        private CheckBox checkBoxMealIncluded;
    }
}