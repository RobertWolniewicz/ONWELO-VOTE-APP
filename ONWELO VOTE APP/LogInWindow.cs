using ONWELO_VOTE_APP.AuthenticationOptions;
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
    public partial class LogInWindow : Form
    {
        public LogInWindow()
        {
            InitializeComponent();
            ResultLabel.Text = "";
        }

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            if( EmailTextBox.Text.Length==0 || PasswordTextBox.Text.Length==0)
            {
                ResultLabel.Text = "Incorrect e-mail or password";
                await ResultLabelClean();
                return;  
            }
            var User = await UserAuthentication.Verification(EmailTextBox.Text.ToLower(), PasswordTextBox.Text);
            if(User !=null)
            {
                var form = new MainWindow(User);
                this.Hide();
                await Task.Run(() => form.ShowDialog());
            }
            else
            {
                ResultLabel.Text = "Incorrect e-mail or password";
                await ResultLabelClean();
                return;
            }
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            var form = new UserDataWindow();
            await Task.Run(() => form.ShowDialog());
            ResultLabel.Text = "Please log in";
        }
        async Task ResultLabelClean()
        {
            await Task.Delay(2000);
            ResultLabel.Text = "";
        }

    }
}
