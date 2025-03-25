using DevExpress.Blazor;

namespace AcademicYearCalendar.Data
{
    public static partial class ResourceAppointmentCollection
    {
        public static List<Appointment> GetAppointments()
        {
            
            DateTime date = DateTime.Now.Date;
            var dataSource = new List<Appointment>() {
                new Appointment {
                    Caption = "محاضرة التطوير الرشيق للبرمجيات",
                    Accepted = false,
                    StartDate = new DateTime(2025,3,21,13,30,0),
                    EndDate = new DateTime(2025,3,21,15,30,0),
                    Status = 2,
                    Resources = DxSchedulerResourceIdCollection.ToXml(0),
                },
                new Appointment {
                    AppointmentType=1,
                    Accepted = false,
                    Caption = "محاضرة إدارة مشروعات البرمجيات ",                    
                    StartDate = new DateTime(2025,3,22,8,30,0),
                    EndDate = new DateTime(2025,3,22,10,30,0),
                    Status = 2,                    
                    Resources = DxSchedulerResourceIdCollection.ToXml(0,1,8),
                    Recurrence = new DxSchedulerRecurrenceInfo(){
                        Start=new DateTime(2025,3,1,8,30,0),
                        Range=SchedulerRecurrenceRange.NoEndDate,
                        Type=SchedulerRecurrenceType.Weekly,
                        Frequency=1,
                        WeekDays=SchedulerWeekDays.Saturday,
                        Id=Guid.NewGuid()
                    }.ToXml(),
                },
                //new Appointment {
                //    Caption = "محاضرة تصميم مواقع الويب",
                //    Accepted = false,
                //    StartDate = date + (new TimeSpan(1, 9, 30, 0)),
                //    EndDate = date + (new TimeSpan(1, 11, 30, 0)),
                //    Status = 3,
                //    ResourceId = 0
                //},
                //new Appointment {
                //    Caption = "محاضرة البرمجة في الأنظمة الكبيرة",
                //    Accepted = true,
                //    StartDate = date + (new TimeSpan(1, 13, 30, 0)),
                //    EndDate = date + (new TimeSpan(1, 15, 15, 0)),
                //    Status = 4,
                //    ResourceId = 0
                //},
                //new Appointment {
                //    Caption = "امتحان نصف الفصل الدراسي -  SE108 - Agile Software Development - التطوير الرشيق للبرمجيات",
                //    Accepted = false,
                //    StartDate = date + (new TimeSpan(1, 12, 0, 0)),
                //    EndDate = date + (new TimeSpan(1, 13, 0, 0)),
                //    AllDay = true,
                //    Status = 1,
                //    ResourceId = 0
                //}
            };
            return dataSource;
        }
    }
}
