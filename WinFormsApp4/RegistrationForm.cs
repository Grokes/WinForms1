using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserRepository _userRepository;
        public RegistrationForm()
        {
            _userRepository = new UserRepository("Data Source=LAPTOP-J6B0K8DE;Initial Catalog=WinForms;Persist Security Info=True;User ID=sa;Password=admin;TrustServerCertificate=True");
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
        private void Registration_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Вы ввели некоректные данные", "Логин или пароль неверный", MessageBoxButtons.OK);
                return;
            }

            _userRepository.Create(new User() { Login = login, Password = password });

            var _mainWindow = new MainWindow();

            _mainWindow.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var logForm = new AuthorizeForm();
            logForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
