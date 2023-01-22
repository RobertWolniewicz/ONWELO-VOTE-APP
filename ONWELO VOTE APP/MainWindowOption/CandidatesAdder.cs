using Microsoft.EntityFrameworkCore;
using ONWELO_VOTE_APP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONWELO_VOTE_APP.MainWindowOption
{
    public class CandidatesAdder
    {
        static readonly VoteAppDB DbContext = new();
        public async static Task<Voter> Add(Candidate NewCandidate, Voter User)
        {
            await DbContext.Candidates.AddAsync(NewCandidate);
            var voter = await DbContext.Voters.FirstOrDefaultAsync(V => V.Email == User.Email);
            voter.AmountOfCandidats--;
            await DbContext.SaveChangesAsync();
            return voter;
        }
    }
}
