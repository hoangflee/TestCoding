using Microsoft.AspNetCore.Http;
using Movies.AppDbContext;
using Movies.Entities;
using Movies.Extensions;
using Movies.Interface;

namespace Movies.Service
{
    public class MovieService : IMovieService
    {
        private MovieDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserLikeMovieService _userLikeMovieService;

        public MovieService(
            MovieDbContext context,
            IHttpContextAccessor httpContextAccessor,
            IUserLikeMovieService userLikeMovieService)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userLikeMovieService = userLikeMovieService;
        }

        public IEnumerable<Entities.Movies> GetAll(int skip, int take)
        {
            var movies = _context.Movies.Where(e => !e.Deleted).Skip(skip).Take(take);
            if (!movies.Any()) return null;

            var user = (Users)_httpContextAccessor.HttpContext.Items["User"];
            foreach (var item in movies)
            {
                var userLike = _userLikeMovieService.GetByUserIdAndMovieId(user.Id, item.Id);
                if (userLike != null && userLike.IsLike)
                    item.IsLiked = true;
            }

            return movies;
        }

        public void ChangedLiked(int movieId)
        {
            var movie = _context.Movies.Find(movieId);
            if (movie == null) throw new KeyNotFoundException("Movie not found");
            if (movie.Deleted) throw new AppException("Movie is deleted");

            var user = (Users)_httpContextAccessor.HttpContext.Items["User"];
            var userLike = _userLikeMovieService.GetByUserIdAndMovieId(user.Id, movie.Id);
            if (userLike == null)
            {
                var userLikeNew = new UserLikeMovies();
                userLikeNew.UserId = user.Id;
                userLikeNew.MovieId = movie.Id;
                userLikeNew.IsLike = true;
                userLikeNew.Created = DateTime.Now;
                userLikeNew.CreatedBy = user.UserName;

                _context.UserLikeMovies.Add(userLikeNew);

                movie.Likes += 1;
            }
            else
            {
                userLike.IsLike = !userLike.IsLike;
                userLike.Updated = DateTime.Now;
                userLike.UpdatedBy = user.UserName;

                if (userLike.IsLike) movie.Likes += 1;
                else movie.Likes -= 1; 

                _context.UserLikeMovies.Update(userLike);
            }

            movie.Updated = DateTime.Now;
            movie.UpdatedBy = user.UserName;

            _context.Movies.Update(movie);
            _context.SaveChanges();
        }
    }
}
