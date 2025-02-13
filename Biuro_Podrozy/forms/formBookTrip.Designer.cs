namespace Biuro_Podrozy.forms
{
    partial class formBookTrip
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
            lblBookTrip = new Label();
            lblFirstName = new Label();
            txtBoxFirstName = new TextBox();
            txtBoxLastName = new TextBox();
            lblLastName = new Label();
            txtBoxEmailAddress = new TextBox();
            lblEmailAddress = new Label();
            txtBoxPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            numericAdults = new NumericUpDown();
            lblAdults = new Label();
            label1 = new Label();
            numericKids = new NumericUpDown();
            lblTrip = new Label();
            btnConfirmBook = new Button();
            ((System.ComponentModel.ISupportInitialize)numericAdults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericKids).BeginInit();
            SuspendLayout();
            // 
            // lblBookTrip
            // 
            lblBookTrip.AutoSize = true;
            lblBookTrip.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookTrip.Location = new Point(85, 21);
            lblBookTrip.Name = "lblBookTrip";
            lblBookTrip.Size = new Size(294, 45);
            lblBookTrip.TabIndex = 0;
            lblBookTrip.Text = "Dokonaj Rezerwacji";
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(104, 134);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(256, 23);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Imię";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxFirstName.Location = new Point(104, 160);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(256, 33);
            txtBoxFirstName.TabIndex = 2;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxLastName.Location = new Point(104, 231);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(256, 33);
            txtBoxLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(104, 205);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(256, 23);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Nazwisko";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxEmailAddress
            // 
            txtBoxEmailAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxEmailAddress.Location = new Point(104, 374);
            txtBoxEmailAddress.Name = "txtBoxEmailAddress";
            txtBoxEmailAddress.Size = new Size(256, 33);
            txtBoxEmailAddress.TabIndex = 8;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailAddress.Location = new Point(104, 348);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(256, 23);
            lblEmailAddress.TabIndex = 7;
            lblEmailAddress.Text = "Adres E-mail";
            lblEmailAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPhoneNumber.Location = new Point(104, 303);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(256, 33);
            txtBoxPhoneNumber.TabIndex = 6;
            txtBoxPhoneNumber.KeyPress += txtBoxPhoneNumber_KeyPress;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(104, 277);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(256, 23);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Nr telefonu";
            lblPhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericAdults
            // 
            numericAdults.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericAdults.InterceptArrowKeys = false;
            numericAdults.Location = new Point(270, 423);
            numericAdults.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericAdults.Name = "numericAdults";
            numericAdults.Size = new Size(63, 33);
            numericAdults.TabIndex = 9;
            // 
            // lblAdults
            // 
            lblAdults.AutoSize = true;
            lblAdults.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdults.Location = new Point(131, 427);
            lblAdults.Name = "lblAdults";
            lblAdults.Size = new Size(133, 25);
            lblAdults.TabIndex = 10;
            lblAdults.Text = "Osoby dorosłe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 469);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 12;
            label1.Text = "Dzieci";
            // 
            // numericKids
            // 
            numericKids.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericKids.InterceptArrowKeys = false;
            numericKids.Location = new Point(270, 467);
            numericKids.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericKids.Name = "numericKids";
            numericKids.Size = new Size(63, 33);
            numericKids.TabIndex = 11;
            // 
            // lblTrip
            // 
            lblTrip.AutoSize = true;
            lblTrip.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrip.Location = new Point(160, 84);
            lblTrip.Name = "lblTrip";
            lblTrip.Size = new Size(144, 32);
            lblTrip.TabIndex = 14;
            lblTrip.Text = "Wycieczka 1";
            // 
            // btnConfirmBook
            // 
            btnConfirmBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmBook.Location = new Point(162, 536);
            btnConfirmBook.Name = "btnConfirmBook";
            btnConfirmBook.Size = new Size(140, 45);
            btnConfirmBook.TabIndex = 15;
            btnConfirmBook.Text = "Zatwierdź";
            btnConfirmBook.UseVisualStyleBackColor = true;
            btnConfirmBook.Click += btnConfirmBook_Click;
            // 
            // formBookTrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 615);
            Controls.Add(btnConfirmBook);
            Controls.Add(lblTrip);
            Controls.Add(label1);
            Controls.Add(numericKids);
            Controls.Add(lblAdults);
            Controls.Add(numericAdults);
            Controls.Add(txtBoxEmailAddress);
            Controls.Add(lblEmailAddress);
            Controls.Add(txtBoxPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtBoxLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtBoxFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(lblBookTrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formBookTrip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biuro Podróży";
            FormClosed += formBookTrip_FormClosed;
            Load += formBookTrip_Load;
            ((System.ComponentModel.ISupportInitialize)numericAdults).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericKids).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookTrip;
        private Label lblFirstName;
        private TextBox txtBoxFirstName;
        private TextBox txtBoxLastName;
        private Label lblLastName;
        private TextBox txtBoxEmailAddress;
        private Label lblEmailAddress;
        private TextBox txtBoxPhoneNumber;
        private Label lblPhoneNumber;
        private NumericUpDown numericAdults;
        private Label lblAdults;
        private Label label1;
        private NumericUpDown numericKids;
        private Label lblTrip;
        private Button btnConfirmBook;
    }
}