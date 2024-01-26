using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4.Repositories;
using WinFormsApp4.Models;

namespace WinFormsApp4
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly AuthorizeForm _authorizeForm;
        private readonly MainWindow _mainWindow;
        public RegistrationForm(MainWindow mainWindow, AuthorizeForm authorizeForm, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _mainWindow = mainWindow;
            _authorizeForm = authorizeForm;
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

            this.Hide();
            _mainWindow.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _authorizeForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
