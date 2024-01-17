namespace WinFormsApp4
{
    partial class AuthorizeForm
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
            Authorize_button = new Button();
            LoginTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            label_login = new Label();
            linkLabel_createAccount = new LinkLabel();
            SuspendLayout();
            // 
            // Authorize_button
            // 
            Authorize_button.Location = new Point(232, 335);
            Authorize_button.Margin = new Padding(3, 4, 3, 4);
            Authorize_button.Name = "Authorize_button";
            Authorize_button.Size = new Size(338, 40);
            Authorize_button.TabIndex = 5;
            Authorize_button.Text = "Авторизоваться";
            Authorize_button.UseVisualStyleBackColor = true;
            Authorize_button.Click += Authorize_Click;
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
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label_login.Location = new Point(323, 75);
            label_login.Name = "label_login";
            label_login.Size = new Size(151, 67);
            label_login.TabIndex = 0;
            label_login.Text = "Вход";
            // 
            // linkLabel_createAccount
            // 
            linkLabel_createAccount.AutoSize = true;
            linkLabel_createAccount.Location = new Point(339, 391);
            linkLabel_createAccount.Name = "linkLabel_createAccount";
            linkLabel_createAccount.Size = new Size(120, 20);
            linkLabel_createAccount.TabIndex = 6;
            linkLabel_createAccount.TabStop = true;
            linkLabel_createAccount.Text = "Создать аккаунт";
            linkLabel_createAccount.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AuthorizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(linkLabel_createAccount);
            Controls.Add(label_login);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(Authorize_button);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(800, 600);
            Name = "AuthorizeForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Authorize_button;
        private TextBox LoginTextBox;
        private Label LoginLabel;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Label label_login;
        private LinkLabel linkLabel_createAccount;
    }
}