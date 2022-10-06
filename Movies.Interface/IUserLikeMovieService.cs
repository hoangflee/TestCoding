using Movies.Entities;

namespace Movies.Interface
{
    public interface IUserLikeMovieService
    {
        UserLikeMovies GetByUserIdAndMovieId(int userId, int movieId);
    }
}
