using WinFormsApp4.Repositories;

namespace WinFormsApp4
{
    public partial class AuthorizeForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly RegistrationForm _registrationForm;
        private readonly MainWindow _mainWindow;
        public AuthorizeForm(MainWindow mainWindow, /*RegistrationForm registrationForm,*/ IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _mainWindow = mainWindow;
            _registrationForm = new RegistrationForm(_mainWindow, this, _userRepository);
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Authorize_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;

            if (_userRepository.GetUsers().Where(u => u.Login == login && u.Password == password).FirstOrDefault() == null)
            {
                MessageBox.Show("Вы ввели некоректные данные", "Не найден пользователь", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Вы ввели коректные данные", "Найден пользователь", MessageBoxButtons.OK);

            this.Hide();
            _mainWindow.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _registrationForm.Show();
        }
    }
}