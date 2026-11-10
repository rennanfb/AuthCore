using AuthCore.Data.Dtos;
using AuthCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthCore.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private UserService _userService;

    public UserController(UserService userService, TokenService tokenService)
    {
        _userService = userService;
    }

    /// <summary>
    /// Creates a new user
    /// </summary>
    /// <param name="createUserDto">Data needed to create a user</param>
    /// <returns>ok if it worked</returns>
    [HttpPost("Register")]
    public async Task<IActionResult> Post([FromBody] CreateUserDto createUserDto)
    {
        await _userService.Register(createUserDto);

        return Ok("Added new user");
    }

    /// <summary>
    /// Authenticate a existing user
    /// </summary>
    /// <param name="loginUserDto">Data needed to try to login</param>
    /// <returns>ok if login was successfull</returns>
    [HttpPost("Login")]
    public async Task<IActionResult> Login(LoginUserDto loginUserDto)
    {
        var token = await _userService.Login(loginUserDto);

        return Ok(token);
    }

    /// <summary>
    /// Returns all users
    /// </summary>
    /// <returns>returns a list containing all the users from the database</returns>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        if (_userService.GetUsers() == null) return BadRequest();

        return Ok(_userService.GetUsers());
    }

}

