using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AcademicYearCalendar.Data;

public class AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
}
