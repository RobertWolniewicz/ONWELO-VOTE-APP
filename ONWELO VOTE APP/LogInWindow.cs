﻿using ONWELO_VOTE_APP.UserOptions;
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

                await ResultLabelShow("Incorrect e-mail or password");
                return;  
            }
            var User = await UserAuthentication.Verification(EmailTextBox.Text.ToLower(), PasswordTextBox.Text);
            if(User !=null)
            {
                EmailTextBox.Text = "";
                PasswordTextBox.Text = "";
                var form = new MainWindow(User);
                this.Hide();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.Retry)
                {
                    this.Show();
                    await ResultLabelShow("You have been successfully logged out");
                    return;
                }
                else if (form.DialogResult == DialogResult.Yes)
                {
                    this.Show();
                    await ResultLabelShow("Your account has been successfully deleted");
                    return;
                }
                else this.Close();
            }
            else
            {
                await ResultLabelShow("Incorrect e-mail or password");
                return;
            }
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            var form = new UserDataWindow();
            await Task.Run(() => form.ShowDialog());
            ResultLabel.Text = "Please log in";
        }
        async Task ResultLabelShow(string text)
        {
            ResultLabel.Text= text;
            await Task.Delay(2000);
            ResultLabel.Text = "";
        }

    }
}
