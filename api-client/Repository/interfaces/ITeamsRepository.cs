namespace api_client.Repository.interfaces
{
    public interface ITeamsRepository
    {
        List<String> GetTeamsByDivision(int division);
    }
}