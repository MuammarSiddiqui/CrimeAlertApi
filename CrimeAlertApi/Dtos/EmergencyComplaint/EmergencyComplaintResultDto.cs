namespace CrimeAlertApi.Dtos.EmergencyComplaint
{
    public class EmergencyComplaintResultDto
    {
        public Guid? Id { get; set; }
        public string? YourName { get; set; }
        public string? Phone { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public bool? Active { get; set; }
    }
}
