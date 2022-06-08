namespace CrimeAlertApi.Dtos.Query
{
    public class QueryResultDto
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public bool? Active { get; set; }
        public Guid? UserId { get; set; }
        public string? User { get; set; }
    }
}
