using AutoMapper;
using AuthCore.Models;
using AuthCore.Data.Dtos;

namespace AuthCore.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, User>();
        }
    }
}
