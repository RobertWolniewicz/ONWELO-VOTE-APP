using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Validators;
using Microsoft.EntityFrameworkCore;
using ONWELO_VOTE_APP.Entity;

namespace ONWELO_VOTE_APP.AuthenticationOptions
{
    public class EmailAddresValidator
    {
        string _email;
        VoteAppDB DbContext = new VoteAppDB();
        public EmailAddresValidator(string email)
        {
            _email=email;

        }
            public  bool IsValidEmail()
            {
            try
            {
                var addr = new System.Net.Mail.MailAddress(_email);
                return addr.Address == _email;
            }
            catch
            {
                return false;
             }
        }
        public bool IsEmailExist()
        {
           var result =  DbContext.Voters.FirstOrDefault(V => V.Email == _email);
            if (result == null) return true;
            else return false;
            
        }
    }
}
