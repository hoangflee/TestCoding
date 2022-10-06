namespace Movies.Interface
{
    public interface IMovieService
    {
        IEnumerable<Entities.Movies> GetAll(int skip, int take);
        void ChangedLiked(int movieId);
    }
}
