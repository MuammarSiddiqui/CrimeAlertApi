namespace CrimeAlertApi.Dtos.Complaint
{
    public class ComplaintDto
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }

        public string? UserId { get; set; }
    }
}
