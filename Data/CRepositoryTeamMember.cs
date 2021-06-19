using PsDevs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsDevs.Data
{
    public class CRepositoryTeamMember : CRepositoryBase<TeamMember>,IRepositoryTeamMember
    {
        public AppDbContext _appDbContext { get; set; }
        public CRepositoryTeamMember(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
