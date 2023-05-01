using api_client.Repository.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_client.Controllers;

[ApiController]
[Route("[controller]")]
public class BrazilianSoccerTeamController : ControllerBase
{
    private readonly ITeamsRepository _repo;

     public BrazilianSoccerTeamController(ITeamsRepository repo)
     {
        _repo = repo;
     }

    [HttpGet("{division}")]
    public IActionResult GetbyDivision(int division)
    {
        return Ok(_repo.GetTeamsByDivision(division));
    }
}
