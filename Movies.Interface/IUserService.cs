using Movies.Entities;
using Movies.Request;

namespace Movies.Interface
{
    public interface IUserService
    {
        Users Login(LoginRequest model);
        void Register(RegisterRequest model);
        Users GetById(int id);
    }
}
