using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/api/test")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Hello()
    {
        return "Hello, World!";
    }

    [HttpPost]
    [Route("addData")]
    public string AddData()
    {
        return "HTTP POST method successfully called.";
    }
}
