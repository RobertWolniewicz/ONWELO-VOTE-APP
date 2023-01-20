using ONWELO_VOTE_APP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONWELO_VOTE_APP.AuthenticationOptions
{
    public class UserAdder
    {
        static VoteAppDB DbContext = new VoteAppDB();
        public async static void Add (Voter NewVoter)
        {
            await DbContext.Voters.AddAsync(NewVoter);
            await DbContext.SaveChangesAsync();
        }
    }
}
