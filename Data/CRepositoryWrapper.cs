namespace PsDevs.Data
{
    public class CRepositoryWrapper : IRepositoryWrapper
    {
        CRepositoryCareer repositoryCareer = null;
        CRepositoryTeamMember repositoryTeamMember = null;
        CRepositoryCareerApplication repositoryCareerApplication = null;

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

        public IRepositoryTeamMember _repositoryTeamMember
        {
            get
            {
                if (repositoryTeamMember == null)
                    repositoryTeamMember = new CRepositoryTeamMember(_appDbContext);
                return repositoryTeamMember;
            }
        }

        public IRepositoryCareerApplication _repositoryCareerApplication
        {
            get
            {
                if (repositoryCareerApplication == null)
                    repositoryCareerApplication = new CRepositoryCareerApplication(_appDbContext);
                return repositoryCareerApplication;
            }
        }
    }
}
