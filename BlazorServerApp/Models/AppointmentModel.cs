namespace BlazorServerApp.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }

        public string AvailableAppointmentId { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Reason { get; set; } = string.Empty;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
