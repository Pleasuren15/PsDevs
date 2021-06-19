namespace PsDevs.Data
{
    public interface IRepositoryWrapper
    {
        IRepositoryCareer _repositoryCareer { get;}
        IRepositoryTeamMember _repositoryTeamMember { get; }
    }
}
