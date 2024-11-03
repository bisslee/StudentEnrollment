namespace StudentEnrollment.Data.Entities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Credits { get; set; }        
    }
}
