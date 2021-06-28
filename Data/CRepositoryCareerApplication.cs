using PsDevs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsDevs.Data
{
    public class CRepositoryCareerApplication : CRepositoryBase<CareerApplication>, IRepositoryCareerApplication
    {
        public CRepositoryCareerApplication(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

    }
}
