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
    public partial class UserDataWindow : Form
    {
        Voter Voter;
        public UserDataWindow()
        {
            InitializeComponent();
            ResultLabel.Text = "";
        }
        public UserDataWindow(Voter User) :this()
        {
            ResultLabel.Text = "Edit your data";
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.Click -= new System.EventHandler(this.SaveButton_Click);
            this.SaveButton.Click += new System.EventHandler(this.EditSaveButton_Click);
            Voter = User;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length==0 || RepeatPasswordTextBox.Text.Length == 0 || NameTextBox.Text.Length == 0 || EmailTextBox.Text.Length == 0)
            {
                ResultLabel.Text = "All fields are required";
                await ResultLabelClean();
                return;
            }
            await Tests();

            string salt = BCrypt.Net.BCrypt.GenerateSalt();

            var newVoter = new Voter()
            {
                Name = NameTextBox.Text,
                Email = EmailTextBox.Text.ToLower(),
                Password = BCrypt.Net.BCrypt.HashPassword(PasswordTextBox.Text, salt),
            };
            UserAdder.Add(newVoter);
            this.Close();


        }
        private async void EditSaveButton_Click(object sender, EventArgs e)
        {
            await Tests();
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            var newVoter = new Voter();

            if (NameTextBox.Text.Length == 0)
               newVoter.Name=Voter.Name;
            else newVoter.Name=NameTextBox.Text;

            if (EmailTextBox.Text.Length == 0)
                newVoter.Email = Voter.Email;
            else newVoter.Email = EmailTextBox.Text;

            if (PasswordTextBox.Text.Length == 0)
                newVoter.Password = Voter.Password;
            else newVoter.Password = BCrypt.Net.BCrypt.HashPassword(PasswordTextBox.Text, salt);

            UserEditor.Edit(Voter,newVoter);
            ResultLabel.Text = "Data has been Edited";
            await Task.Delay(2000);
            this.Close();


        }
        async Task Tests()
        {
            if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
            {
                ResultLabel.Text = "Passworts Are different";
                await ResultLabelClean();
                return;
            }
            var validator = new EmailAddresValidator(EmailTextBox.Text.ToLower());
            if ((!validator.IsValidEmail()&& Voter == null) || (!validator.IsValidEmail() && Voter != null && EmailTextBox.Text.Length!=0) )
            {
                ResultLabel.Text = "Incorrect email addres";
                await ResultLabelClean();
                return;
            }
            if (EmailTextBox.Text.Length != 0)
            { 
                if (!validator.IsEmailExist())
                {
                    ResultLabel.Text = "This email address is taken ";
                    await ResultLabelClean();
                    return;
                } 
            }
  
        }
        async Task ResultLabelClean()
        {
            await Task.Delay(2000);
            if(Voter != null)
            {
                ResultLabel.Text = "Edit your data";
            }
            else
                ResultLabel.Text = "";
        }
        

    }
}
