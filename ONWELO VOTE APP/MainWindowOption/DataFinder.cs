using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ONWELO_VOTE_APP.Entity;
using ONWELO_VOTE_APP.Models;
using ONWELO_VOTE_APP.Sieve;
using Sieve.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONWELO_VOTE_APP.MainWindowOption
{
    public class DataFinder
    {
        readonly VoteAppDB DbContext = new();
        readonly ApplicationSieveProcessor SieveProcessor = new(Options.Create(new SieveOptions()));
        public async Task<PageResult<VoterDto>> GetVotersData(SieveModel query)
        {
            var Voters = DbContext.Voters.Select(V => new VoterDto
            {
                Name = V.Name,
                HasVoted = V.HasVoted,

            });
            var result = await SieveProcessor.Apply(query, Voters).ToListAsync();
            var totalCount = await SieveProcessor.Apply(query, Voters, applySorting: false, applyPagination: false).CountAsync();
            var data = new PageResult<VoterDto>(result, totalCount, query.PageSize.Value, query.Page.Value );
            return data;
        }
        public async Task<PageResult<CandidateDto>> GetCandidatesData(SieveModel query)
        {
            var Candidates = DbContext.Candidates.Select(C => new CandidateDto
            {
                Name = C.Name,
                Votes = C.Votes,

            });
            var result = await SieveProcessor.Apply(query, Candidates).ToListAsync();
            var totalCount = await SieveProcessor.Apply(query, Candidates, applySorting: false, applyPagination: false).CountAsync();
            var data = new PageResult<CandidateDto>(result, totalCount, query.PageSize.Value, query.Page.Value);
            return data;
        }
        public async Task<PageResult<VoterDto>> FindVoters(string SearchingPhrase, SieveModel query)
        {
            var Voters = DbContext.Voters.Where(V=>V.Name.ToLower().Contains(SearchingPhrase.ToLower())).Select(V => new VoterDto
            {
                Name = V.Name,
                HasVoted = V.HasVoted,

            });
            var result = await SieveProcessor.Apply(query, Voters).ToListAsync();
            var totalCount = await SieveProcessor.Apply(query, Voters, applySorting: false, applyPagination: false).CountAsync();
            var data = new PageResult<VoterDto>(result, totalCount, query.PageSize.Value, query.Page.Value);
            return data;
        }
        public async Task<PageResult<CandidateDto>> FindCandidates(string SearchingPhrase, SieveModel query)
        {
            var Candidates = DbContext.Candidates.Where(C => C.Name.ToLower().Contains(SearchingPhrase.ToLower())).Select(C => new CandidateDto
            {
                Name = C.Name,
                Votes = C.Votes,

            });
            var result = await SieveProcessor.Apply(query, Candidates).ToListAsync();
            var totalCount = await SieveProcessor.Apply(query, Candidates, applySorting: false, applyPagination: false).CountAsync();
            var data = new PageResult<CandidateDto>(result, totalCount, query.PageSize.Value, query.Page.Value);
            return data;
        }
    }
}
