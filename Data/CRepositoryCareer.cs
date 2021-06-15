using PsDevs.Models;

namespace PsDevs.Data
{
    public class CRepositoryCareer : CRepositoryBase<Career>, IRepositoryCareer
    {
        public AppDbContext _appDbContext { get; set; }
        public CRepositoryCareer(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

    }
}
