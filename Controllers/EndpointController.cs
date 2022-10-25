//Marcel Rodriguez
//10-25-22
//Say Hello Endpoint
//This controller will ask user for input in url and return string with name
//Peer review - Jovann: Code looks clean and works when I put in a name and returns the correct output.
using Microsoft.AspNetCore.Mvc;

namespace RodriguezMSayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class EndpointController : ControllerBase
{
    [HttpGet]
    [Route("hello/{name}")]

    public string SayHello(string name)
    {
        return $"Hello {name}, have a great day!";
    }
}
