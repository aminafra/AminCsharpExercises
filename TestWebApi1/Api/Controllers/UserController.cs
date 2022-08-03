using Api.Data;
using Api.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class UserController : BaseController
{
    private readonly DataContext _context;

    public UserController(DataContext context)
    {
        _context = context;
    }

    [AllowAnonymous]
    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        return _context.Users.ToList();
    }

    
    [HttpGet("{Id:int}")]
    public ActionResult<AppUser?> GetUsersById(int Id)
    {
        return _context.Users.Find(Id);
    }
}