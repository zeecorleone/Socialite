using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BaseApiController : ControllerBase
{
    //private readonly DataContext _context;

    //public BaseApiController(DataContext context)
    //{
    //    _context = context;
    //}
}
