using Microsoft.EntityFrameworkCore;
using ONWELO_VOTE_APP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONWELO_VOTE_APP.UserOptions
{
    public class AccountDeleter
    {
        static readonly VoteAppDB DbContext = new();
        public static async  Task<bool> Delete(Voter User)
        {
            var DeletingUser= await DbContext.Voters.FirstOrDefaultAsync(V => V.Email == User.Email);
            if (DeletingUser != null)
            {
                DbContext.Voters.Remove(DeletingUser);
                await DbContext.SaveChangesAsync();
                return true;
            }
            return false;
          
        }
    }
}
