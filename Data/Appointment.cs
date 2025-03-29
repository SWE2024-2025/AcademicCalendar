namespace AcademicYearCalendar.Data
{
    public class Appointment
    {
        public Appointment() { }
        
        public int Id { get; set; }
        public int AppointmentType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Caption { get; set; }
        public string? Description { get; set; }
        public int? Label { get; set; }
        public int Status { get; set; }
        public bool AllDay { get; set; }
        public string? Recurrence { get; set; }
        public int? ResourceId { get; set; }
        public string? Resources { get; set; }
        public string? TextColor { get; set; }
        public string? BackgroundColor { get; set; }
        
    }
}
