using System.Text.Json;
using api_client.Repository.interfaces;

namespace api_client.Repository
{
    public class TeamsRepository : ITeamsRepository
    {
        public List<String> GetTeamsByDivision(int division)
        {
            var result = new List<string>();
            if(division == 1)
                result = GetFirstDivision();
            else if(division == 2)
               result = GetSecondDivision();
            else
               result.Add("Not found!");    

            return result;   
        }

        private List<String> GetFirstDivision()
        {
            HttpClient client = new HttpClient();
            var teamList = client.GetStringAsync("http://localhost:5146/firstDivision").Result;
            var result = JsonSerializer.Deserialize<List<string>>(teamList.ToString())!;
            return result;
        }

        private List<String> GetSecondDivision()
        {
            HttpClient client = new HttpClient();
            var teamList = client.GetStringAsync("http://localhost:5146/secondDivision").Result;
            var result = JsonSerializer.Deserialize<List<string>>(teamList.ToString())!;
            return result;
        }
    }
}