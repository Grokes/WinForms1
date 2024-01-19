namespace WinFormsApp4
{
    public partial class AuthorizeForm : Form
    {
        private readonly IUserRepository _userRepository;
        public AuthorizeForm()
        {
            _userRepository = new UserRepository("Data Source=LAPTOP-J6B0K8DE;Initial Catalog=WinForms;Persist Security Info=True;User ID=sa;Password=admin;TrustServerCertificate=True");
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

            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var regForm = new RegistrationForm();
            regForm.Show();
        }
    }
}