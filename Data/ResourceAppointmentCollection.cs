using DevExpress.Blazor;
using Microsoft.EntityFrameworkCore;
using AcademicYearCalendar.Data;
using System;

namespace AcademicYearCalendar.Data
{
    public  class ResourceAppointmentCollection
    {
        AppDbContext AppDbContext;
        public ResourceAppointmentCollection(AppDbContext appDbContext) {
            AppDbContext = appDbContext;
        }

        public List<Appointment> GetAppointments()
        {
            return AppDbContext.Appointments.ToList();
        }
        private  List<Appointment> GetAppointments_OLD()
        {
            
            DateTime date = DateTime.Now.Date;
            var dataSource = new List<Appointment>() {
                new Appointment {
                    AppointmentType=(int)SchedulerAppointmentType.Pattern,
                    Caption = "محاضرة إدارة مشروعات البرمجيات",
                    StartDate = new DateTime(2025,3,7,08,30,0),
                    EndDate = new DateTime(2025,3,7,10,30,0),
                    Status = 2,
                    ResourceId = 0,
                    Resources = DxSchedulerResourceIdCollection.ToXml(0,1,8),
                    Recurrence = new DxSchedulerRecurrenceInfo(){
                        Start=new DateTime(2025,3,7,8,30,0),
                        Range=SchedulerRecurrenceRange.NoEndDate,
                        Type=SchedulerRecurrenceType.Weekly,
                        Frequency=1,
                        WeekDays=SchedulerWeekDays.Friday,
                        Id=Guid.NewGuid(),
                    }.ToXml(),
                },
                new Appointment {
                    AppointmentType=1,
                    Caption = "محاضرة التطوير الرشيق للبرمجيات",
                    StartDate = new DateTime(2025,3,7,13,0,0),
                    EndDate = new DateTime(2025,3,7,15,0,0),
                    Status = 2,
                    Resources = DxSchedulerResourceIdCollection.ToXml(0,2,5),
                    Recurrence = new DxSchedulerRecurrenceInfo(){
                        Start=new DateTime(2025,3,7,13,0,0),
                        Range=SchedulerRecurrenceRange.NoEndDate,
                        Type=SchedulerRecurrenceType.Weekly,
                        Frequency=1,
                        WeekDays=SchedulerWeekDays.Friday,
                        Id=Guid.NewGuid()
                    }.ToXml(),
                },
                new Appointment {
                    AppointmentType=1,
                    Caption = "محاضرة تصميم مواقع الويب",
                    StartDate = new DateTime(2025,3,7,21,0,0),
                    EndDate = new DateTime(2025,3,7,23,0,0),
                    Status = 2,
                    Resources = DxSchedulerResourceIdCollection.ToXml(0,3,6),
                    Recurrence = new DxSchedulerRecurrenceInfo(){
                        Start=new DateTime(2025,3,7,21,0,0),
                        Range=SchedulerRecurrenceRange.NoEndDate,
                        Type=SchedulerRecurrenceType.Weekly,
                        Frequency=1,
                        WeekDays=SchedulerWeekDays.Friday,
                        Id=Guid.NewGuid()
                    }.ToXml(),
                },
                new Appointment {
                    AppointmentType=1,
                    Caption = "محاضرة البرمجة في الأنظمة الكبيرة",
                    StartDate = new DateTime(2025,3,8,13,0,0),
                    EndDate = new DateTime(2025,3,8,15,0,0),
                    Status = 2,
                    ResourceId = 0,
                    Resources = DxSchedulerResourceIdCollection.ToXml(0,4,7),
                    Recurrence = new DxSchedulerRecurrenceInfo(){
                        Start=new DateTime(2025,3,8,13,0,0),
                        Range=SchedulerRecurrenceRange.NoEndDate,
                        Type=SchedulerRecurrenceType.Weekly,
                        Frequency=1,
                        WeekDays=SchedulerWeekDays.Saturday,
                        Id=Guid.NewGuid()
                    }.ToXml(),
                },
                new Appointment {                    
                    Caption = "امتحان نصف الفصل الدراسي -  SE108 - Agile Software Development - التطوير الرشيق للبرمجيات",
                    StartDate = new DateTime(2025,3,30,13,0,0),
                    EndDate = new DateTime(2025,3,30,15,0,0),
                    AllDay = true,
                    Status = 3,
                    ResourceId = 0,
                    Resources = DxSchedulerResourceIdCollection.ToXml(0,2),                    
                }
            };
            return dataSource;
        }
    }
}
