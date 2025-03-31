using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Blazor;
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

        private DxSchedulerRecurrenceInfo dxSchedulerRecurrenceInfo;

        [NotMapped]
        public string RepeatEndDate
        {
            get
            {
                if (IsRecurrence)
                {
                    setDxSchedulerRecurrenceInfo();
                    return dxSchedulerRecurrenceInfo.End.ToString("yyyy-MM-dd");
                }
                return "";
            }
        }

        [NotMapped]
        public string RepeatDay
        {
            get
            {
                if (IsRecurrence)
                {
                    setDxSchedulerRecurrenceInfo();
                    if (dxSchedulerRecurrenceInfo.Type == SchedulerRecurrenceType.Daily)
                    {
                        return " يوميا ";
                    }
                    else if (dxSchedulerRecurrenceInfo.Type == SchedulerRecurrenceType.Weekly)
                    {
                        switch (dxSchedulerRecurrenceInfo.WeekDays)
                        {
                            case SchedulerWeekDays.Saturday:
                                return "سبت";
                            case SchedulerWeekDays.Sunday:
                                return "احد";
                            case SchedulerWeekDays.Monday:
                                return "اثنين";
                            case SchedulerWeekDays.Tuesday:
                                return "ثلاثاء";
                            case SchedulerWeekDays.Wednesday:
                                return "اربعاء";
                            case SchedulerWeekDays.Thursday:
                                return "خميس";
                            case SchedulerWeekDays.Friday:
                                return "جمعة";
                        }
                    }
                    else if(dxSchedulerRecurrenceInfo.Type == SchedulerRecurrenceType.Monthly)
                    {
                        return dxSchedulerRecurrenceInfo.DayNumber.ToString() + " من كل شهر ";
                    }
                }
                return "";
            }
        }

        private bool IsRecurrence
        {
            get
            {
                return !string.IsNullOrEmpty(Recurrence);
            }
        }

        private void setDxSchedulerRecurrenceInfo()
        {
            if (dxSchedulerRecurrenceInfo != null || !IsRecurrence)
                return;
            dxSchedulerRecurrenceInfo=new DxSchedulerRecurrenceInfo();
            dxSchedulerRecurrenceInfo.FromXml(Recurrence);
        }

    }
}
