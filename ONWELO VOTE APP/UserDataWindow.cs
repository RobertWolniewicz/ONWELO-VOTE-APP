using ONWELO_VOTE_APP.UserOptions;
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
        public Voter ReturnValue { get; set; }
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
                await ResultLabelShow("All fields are required");
                return;
            }

            if (!await Tests()) return;

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

            if (!await Tests()) return;

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

            await UserEditor.Edit(Voter,newVoter);
            ReturnValue = newVoter;
            ResultLabel.Text = "Data has been Edited";
            await Task.Delay(2000);
            this.Close();


        }
        async Task<bool> Tests()
        {
            if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
            {
                await ResultLabelShow("Passwords are different");
                return false;
            }
            var validator = new EmailAddresValidator(EmailTextBox.Text.ToLower());
            if ((!validator.IsValidEmail()&& Voter == null) || (!validator.IsValidEmail() && Voter != null && EmailTextBox.Text.Length!=0) )
            {
                await ResultLabelShow("Incorrect email addres");
                return false;
            }
            if (EmailTextBox.Text.Length != 0)
            { 
                if (!validator.IsEmailExist())
                {
                    await ResultLabelShow("This email address is taken");
                    return false;
                } 
            }
            return true;
  
        }
        async Task ResultLabelShow(string text)
        {
            ResultLabel.Text=text;
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
