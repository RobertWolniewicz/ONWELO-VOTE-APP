using ONWELO_VOTE_APP.AuthenticationOptions;
using ONWELO_VOTE_APP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONWELO_VOTE_APP
{
    public partial class SignInWindow : Form
    {
        public SignInWindow()
        {
            InitializeComponent();
            ResultLabel.Text = "";
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length==0 || RepeatPasswordTextBox.Text.Length == 0 || NameTextBox.Text.Length == 0 || EmailTextBox.Text.Length == 0)
            {
                ResultLabel.Text = "All fields are required";
                await ResultLabelClean();
                return;
            }
            if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
            {
                ResultLabel.Text = "Passworts Are different";
                await ResultLabelClean();
                return;
            }
            var validator = new EmailAddresValidator(EmailTextBox.Text.ToLower());
            if( !validator.IsValidEmail())
            {
                ResultLabel.Text = "Incorrect email addres";
                await ResultLabelClean();
                return;
            }
            if(!validator.IsEmailExist())
            {
                ResultLabel.Text = "This email address is taken ";
                await ResultLabelClean();
                return;
            }

            string salt = BCrypt.Net.BCrypt.GenerateSalt();

            var newVoter = new Voter()
            {
                Name = NameTextBox.Text,
                Email = EmailTextBox.Text.ToLower(),
                Password = BCrypt.Net.BCrypt.HashPassword(PasswordTextBox.Text, salt),
                HasVoted = false

            };
            UserAdder.Add(newVoter);
            this.Close();


        } 
        async Task ResultLabelClean()
        {
            await Task.Delay(2000);
            ResultLabel.Text = "";
        }
    }
}
