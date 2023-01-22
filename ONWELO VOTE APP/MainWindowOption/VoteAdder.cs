using Microsoft.EntityFrameworkCore;
using ONWELO_VOTE_APP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONWELO_VOTE_APP.MainWindowOption
{
    internal class VoteAdder
    {
        static readonly VoteAppDB DbContext = new();
        public async static Task<Voter> Vote(string CandidateName, Voter User)
        {
            var Candidate = await DbContext.Candidates.FirstOrDefaultAsync(C => C.Name == CandidateName);
            if (Candidate == null) return User;
            Candidate.Votes++;
            var Voter = await DbContext.Voters.FirstOrDefaultAsync(V => V.Email == User.Email);
            Voter.HasVoted = true;
            await DbContext.SaveChangesAsync();
            return Voter;

        }
    }
}
