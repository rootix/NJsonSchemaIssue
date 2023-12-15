using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.Geometries;

namespace Net80NJsonSchema11.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    [HttpGet(Name = "GetPoint")]
    public Point Get()
    {
        return new Point(new Coordinate(1.0, 2.0));
    }
}