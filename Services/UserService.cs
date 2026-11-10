using AutoMapper;
using AuthCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AuthCore.Data.Dtos;
using AuthCore.Data;

namespace AuthCore.Services;

public class UserService
{
    private IMapper _mapper;
    private UserManager<User> _userManager;
    private SignInManager<User> _signInManager;
    private TokenService _tokenService;

    public UserService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, TokenService tokenService)
    {
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenService = tokenService;
    }

    public async Task Register(CreateUserDto createUserDto)
    {
        User user = _mapper.Map<User>(createUserDto);

        IdentityResult result = await _userManager.CreateAsync(user, createUserDto.Password);

        if(!result.Succeeded)
        {
            throw new ApplicationException("failed to register");
        }
    }

    public async Task<string> Login(LoginUserDto loginUserDto)
    {
        var result = await _signInManager.PasswordSignInAsync(loginUserDto.Username, loginUserDto.Password, false, false);

        if(!result.Succeeded)
        {
            throw new ApplicationException("User not authenticated");
        }

        var user = _signInManager.UserManager.Users.FirstOrDefault(user => user.UserName == loginUserDto.Username);
        //var user = _userManager.Users.FirstOrDefault(user => user.UserName == loginUserDto.Username);

        var token = _tokenService.GenerateToken(user);

        return token;

    }

    public async Task<List<User>> GetUsers()
    {
        var users = _userManager.Users.ToList();

        if (users == null)
        {
            return null;
        }

        return users;
    }

}

