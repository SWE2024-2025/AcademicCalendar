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
       
    }
}
