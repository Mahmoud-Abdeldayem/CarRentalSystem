using BusinessLogicLayer.Abstractions;
using BusinessLogicLayer.Dtos;
using BusinessLogicLayer.Services;
using DataAccessLayer.Entities.Enums;
using PresentationLayer.Forms;
using PresentationLayer.Forms.AdminForms;
using PresentationLayer.Forms.CustomerForms;
using static PresentationLayer.Program;

namespace PresentationLayer
{
    public partial class LoginForm : Form
    {
        //private readonly ICarService _carService;
        private readonly IAccountService _accountService;

        public LoginForm(IAccountService accountService)
        {

            _accountService = accountService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email = this.textBox1.Text;
            var password = this.textBox2.Text;

            if (email == null || password == null)
                MessageBox.Show("Please fill all fields...");
            else
            {
                var loginDto = new LoginDto()
                {
                    Email = email,
                    Password = password
                };

                var user = _accountService.Login(loginDto);
                if (user.AuthenticatedUser == null)
                    MessageBox.Show(user.Error);

                if (user.AuthenticatedUser.Role == UserRole.Admin)
                {
                    var adminHomeForm = new AdminHomeForm();
                    adminHomeForm.Show();
                    this.Close();
                }
                var customerHomeForm = new CustomerHomeForm(ServicesManager.CarService);
                customerHomeForm.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //this.label1.Font.Size = 18;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterLink_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var RegisterForm = new CustomerRegisterForm(ServicesManager.AccountService);
            RegisterForm.Show();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
