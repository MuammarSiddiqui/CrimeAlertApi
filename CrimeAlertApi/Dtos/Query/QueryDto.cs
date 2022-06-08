namespace CrimeAlertApi.Dtos.Query
{
    public class QueryDto
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public Guid? UserId { get; set; }
    }
}
