using System.Security.Cryptography;
using System.Text;
using Api.Data;
using Api.DTO;
using Api.Entities;
using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

public class AccountController : BaseController
{
    private readonly DataContext _context;
    private readonly ITokenService _tokenService;

    public AccountController(DataContext context,ITokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    [HttpPost("register")]
    public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
    {
        if (await IsExist(registerDto.Username))
            return BadRequest("already exist");

        using var hmac = new HMACSHA512();
        var user = new AppUser
        {
            UserName = registerDto.Username,
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
            PasswordSalt = hmac.Key
        };
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return new UserDto
        {
            Username = registerDto.Username,
            Token = _tokenService.CreateToken(user),
        };
    }

    [ApiExplorerSettings(IgnoreApi = true)]
    public async Task<bool> IsExist(string username)
    {
        return await _context.Users.AnyAsync(x => x.UserName == username);
    }

    [HttpPost("Login")]
    public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
    {
        var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == loginDto.Username);
        if (user == null) return Unauthorized("Invalid user");
        using var hmac = new HMACSHA512(user.PasswordSalt);
        var computerHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));
        if (!user.PasswordHash.SequenceEqual(computerHash)) return Unauthorized("Invalid password");
        return new UserDto
        {
            Username = loginDto.Username,
            Token = _tokenService.CreateToken(user),
        };
    }
    
    [HttpPost("AddPhone")]
    public async Task<ActionResult<UserDto>> AddPhone(PhoneDto addPhoneDto)
    {
        var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == addPhoneDto.Id);
        if (user == null) return Unauthorized("Invalid user");
        if (addPhoneDto.PhoneNumber.Length != 8 || !int.TryParse(addPhoneDto.PhoneNumber, out _)) return BadRequest("Invalid phone number");
        user.PhoneNumber = addPhoneDto.PhoneNumber;
        await _context.SaveChangesAsync();
        return new UserDto
        {
            Username = user.UserName,
            Token = _tokenService.CreateToken(user),
        };
    }
    
    [HttpPost("AddBirthday")]
    public async Task<ActionResult<UserDto>> AddBirthday(BirthdayDto addBirthdayDto)
    {
        var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == addBirthdayDto.Id);
        if (user == null) return Unauthorized("Invalid user");
        user.BirthDate = addBirthdayDto.BirthDate;
        user.Age = addBirthdayDto.Age;
        await _context.SaveChangesAsync();
        return new UserDto
        {
            Username = user.UserName,
            Token = _tokenService.CreateToken(user),
        };
    }
}