using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Movies.AppDbContext;
using Movies.Entities;
using Movies.Extensions;
using Movies.Interface;
using Movies.Request;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Movies.Service
{
    public class UserService : IUserService
    {
        private MovieDbContext _context;
        private readonly AppSettings _appSettings;
        private readonly IMapper _mapper;

        public UserService(
            MovieDbContext context,
            IOptions<AppSettings> appSettings,
            IMapper mapper)
        {
            _context = context;
            _appSettings = appSettings.Value;
            _mapper = mapper;
        }

        public Users Login(LoginRequest model)
        {
            var user = _context.Users.FirstOrDefault(x => !x.Deleted && 
                (x.UserName == model.UserName || x.Email == model.UserName));

            // Validate
            if (user == null || !BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
                throw new AppException("Username (email) or password is incorrect");

            // Authentication successful
            user.Token = generateJwtToken(user);
            return user;
        }

        public Users GetById(int id)
        {
            return getUser(id);
        }

        public void Register(RegisterRequest model)
        {
            // Validate
            if (_context.Users.Any(x => !x.Deleted 
                && (x.UserName == model.UserName || x.Email == model.Email))
               ) throw new AppException("Username or Email already taken");

            // Map model to new user object
            var user = _mapper.Map<Users>(model);

            // Hash password
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(model.Password);

            user.Created = DateTime.Now;
            user.CreatedBy = user.UserName;

            // Save user
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        private Users getUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) throw new KeyNotFoundException("User not found");
            if (user.Deleted) throw new AppException("User is deleted");
            return user;
        }

        private string generateJwtToken(Users user)
        {
            // Generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
