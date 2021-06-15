namespace PsDevs.Data
{
    public class CRepositoryWrapper : IRepositoryWrapper
    {
        CRepositoryCareer repositoryCareer = null;
        public AppDbContext _appDbContext { get; }

        public CRepositoryWrapper(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IRepositoryCareer _repositoryCareer
        {
            get
            {
                if (repositoryCareer == null)
                    repositoryCareer = new CRepositoryCareer(_appDbContext);
                return repositoryCareer;
            }
        }

    }
}
