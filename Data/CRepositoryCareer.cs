using PsDevs.Models;

namespace PsDevs.Data
{
    public class CRepositoryCareer : CRepositoryBase<Career>, IRepositoryCareer
    {
        public CRepositoryCareer(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

    }
}
