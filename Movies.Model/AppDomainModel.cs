namespace Movies.Model
{
    public class AppDomainModel
    {
        public int Id { get; set; }

        public DateTime? Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Updated { get; set; }

        public string UpdatedBy { get; set; }

        public bool Deleted { get; set; }
    }
}
