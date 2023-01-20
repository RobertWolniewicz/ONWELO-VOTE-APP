using Microsoft.EntityFrameworkCore;
using ONWELO_VOTE_APP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONWELO_VOTE_APP.AuthenticationOptions
{
    public class UserAuthentication
    {
       static VoteAppDB DbContext = new VoteAppDB();

        public static  async Task<Voter> Verification(string UserEmail, string Password)
        {
            var User=  await DbContext.Voters.FirstOrDefaultAsync(V=>V.Email == UserEmail);
            if (User == null) return null;
            if (BCrypt.Net.BCrypt.Verify(Password, User.Password)) return User;

            return null;


        }

    }
}
