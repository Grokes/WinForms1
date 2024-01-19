namespace WinFormsApp4
{
    partial class RegistrationForm
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
            Register_button = new Button();
            LoginTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            label_registration = new Label();
            linkLabel_createAccount = new LinkLabel();
            SuspendLayout();
            // 
            // Register_button
            // 
            Register_button.Location = new Point(232, 335);
            Register_button.Margin = new Padding(3, 4, 3, 4);
            Register_button.Name = "Register_button";
            Register_button.Size = new Size(338, 40);
            Register_button.TabIndex = 5;
            Register_button.Text = "Зарегистрироваться";
            Register_button.UseVisualStyleBackColor = true;
            Register_button.Click += Registration_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(195, 198);
            LoginTextBox.Margin = new Padding(3, 4, 3, 4);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(419, 27);
            LoginTextBox.TabIndex = 2;
            LoginTextBox.TextChanged += textBox1_TextChanged;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(127, 209);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(52, 20);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Логин";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(195, 285);
            PasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(419, 27);
            PasswordTextBox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(127, 296);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(62, 20);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Пароль";
            PasswordLabel.Click += label2_Click;
            // 
            // label_registration
            // 
            label_registration.AutoSize = true;
            label_registration.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label_registration.Location = new Point(235, 65);
            label_registration.Name = "label_registration";
            label_registration.Size = new Size(335, 67);
            label_registration.TabIndex = 0;
            label_registration.Text = "Регистрация";
            // 
            // linkLabel_createAccount
            // 
            linkLabel_createAccount.AutoSize = true;
            linkLabel_createAccount.Location = new Point(316, 391);
            linkLabel_createAccount.Name = "linkLabel_createAccount";
            linkLabel_createAccount.Size = new Size(147, 20);
            linkLabel_createAccount.TabIndex = 6;
            linkLabel_createAccount.TabStop = true;
            linkLabel_createAccount.Text = "Есть аккаунт? Войти";
            linkLabel_createAccount.LinkClicked += linkLabel1_LinkClicked;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(linkLabel_createAccount);
            Controls.Add(label_registration);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(Register_button);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(800, 600);
            Name = "RegistrationForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button Register_button;
        private TextBox LoginTextBox;
        private Label LoginLabel;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Label label_registration;
        private LinkLabel linkLabel_createAccount;
    }
}