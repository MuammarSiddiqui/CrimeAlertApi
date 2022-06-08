namespace CrimeAlertApi.Dtos.EmergencyComplaint
{
    public class EmergencyComplaintDto
    {
        public Guid? Id { get; set; }
        public string? YourName { get; set; }
        public string? Phone { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }

    }
}
