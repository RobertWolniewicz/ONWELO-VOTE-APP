using Microsoft.EntityFrameworkCore;
using ONWELO_VOTE_APP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONWELO_VOTE_APP.UserOptions
{
    public class UserEditor
    {
        static readonly VoteAppDB DbContext = new();
        public static async Task Edit(Voter EditingUser, Voter EditData)
        {
           var User = await  DbContext.Voters.FirstAsync(V=>V.Email==EditingUser.Email);
           User.Name = EditData.Name;
           User.Email = EditData.Email;
           User.Password = EditData.Password;
           await DbContext.SaveChangesAsync();
        }
    }
}
