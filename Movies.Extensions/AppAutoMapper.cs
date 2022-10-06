using AutoMapper;
using Movies.Entities;
using Movies.Request;

namespace Movies.Extensions
{
    public class AppAutoMapper : Profile
    {
        public AppAutoMapper()
        {
            // User -> LoginRequest
            CreateMap<Users, LoginRequest>();

            // RegisterRequest -> User
            CreateMap<RegisterRequest, Users>();
        }
    }
}
