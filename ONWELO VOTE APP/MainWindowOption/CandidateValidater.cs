using Microsoft.EntityFrameworkCore;
using ONWELO_VOTE_APP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONWELO_VOTE_APP.MainWindowOption
{
    public class CandidateValidater
    {
        static readonly VoteAppDB DbContext = new();

        public static bool Validate(string CandidateName)
        {
            var result = DbContext.Candidates.FirstOrDefault(C => C.Name.ToLower() == CandidateName.ToLower());
            if (result == null) return true;
                return false;

        }
    }
}
