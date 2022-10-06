namespace Movies.Entities
{
    public class UserLikeMovies : DomainEntities
    {
        public int UserId { get; set; } = 0;

        public int MovieId { get; set; } = 0;

        public bool IsLike { get; set; } = true;
    }
}
