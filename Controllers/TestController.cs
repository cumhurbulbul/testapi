using Microsoft.AspNetCore.Mvc;

namespace testapi.Controllers;

[ApiController]
[Route("/test")]
public class TestController : ControllerBase
{

    [HttpGet]
    public string Get()
    {
       return "fenerbahce";
    }
}
