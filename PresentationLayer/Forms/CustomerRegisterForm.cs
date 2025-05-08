using BusinessLogicLayer.Abstractions;
using BusinessLogicLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PresentationLayer.Program;

namespace PresentationLayer.Forms
{
    public partial class CustomerRegisterForm : Form
    {

        private readonly IAccountService _accountService;
        public CustomerRegisterForm(IAccountService accountService)
        {
            _accountService = accountService;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            var email = this.EmailInp.Text;
            var fullName = this.FirstNameInp.Text;
            var password = this.PasswordInp.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullName))
                MessageBox.Show("Please fill all fields...");
            else
            {
                var customer = new CustomerRegisterDto()
                {
                    Email = email,
                    Password = password,
                    FirstName = fullName.Split(' ')[0],
                    LastName = fullName.Split(' ')[0],
                };
                var res = _accountService.Register(customer);
                if (res.Error != null)
                {
                    MessageBox.Show("this User already registerd");
                }

                var loginForm = new LoginForm(ServicesManager.AccountService);
                loginForm.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
