namespace Biuro_Podrozy.forms
{
    partial class formLogin
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
            lblBigLogin = new Label();
            txtBoxLogin = new TextBox();
            lblLogin = new Label();
            lblPassword = new Label();
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblBigLogin
            // 
            lblBigLogin.AutoSize = true;
            lblBigLogin.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBigLogin.Location = new Point(106, 41);
            lblBigLogin.Name = "lblBigLogin";
            lblBigLogin.Size = new Size(202, 45);
            lblBigLogin.TabIndex = 0;
            lblBigLogin.Text = "LOGOWANIE";
            lblBigLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxLogin.Location = new Point(106, 185);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(202, 33);
            txtBoxLogin.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(106, 151);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(202, 28);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(106, 223);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(202, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Hasło";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPassword.Location = new Point(106, 257);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(202, 33);
            txtBoxPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(106, 346);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(202, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Zaloguj";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 450);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtBoxPassword);
            Controls.Add(lblLogin);
            Controls.Add(txtBoxLogin);
            Controls.Add(lblBigLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biuro Podróży";
            FormClosed += formLogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBigLogin;
        private TextBox txtBoxLogin;
        private Label lblLogin;
        private Label lblPassword;
        private TextBox txtBoxPassword;
        private Button btnLogin;
    }
}