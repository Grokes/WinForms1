namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Authorize_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;

            if(UserRepository.Users.Where(u => u.Login == login && u.Password == password).FirstOrDefault() == null )
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
    }
}