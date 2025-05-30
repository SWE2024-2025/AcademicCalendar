using Microsoft.EntityFrameworkCore;
using AcademicYearCalendar.Data;

namespace AcademicYearCalendar.Data
{
    public class ResourceCollection
    {
        AppDbContext AppDbContext;
        public ResourceCollection(AppDbContext appDbContext) {
            AppDbContext = appDbContext;
        }
        public List<Resource> GetResourcesForGrouping()
        {
            //return AppDbContext.Resources.Where(r => r.ParentId == null).ToList();
            return AppDbContext.Resources.ToList();
            //return GetResources().ToList();
        }

        public List<Resource> GetResources()
        {
            return AppDbContext.Resources.Where(r=>r.ParentId != null).ToList();
        }

        public List<Resource> GetResourceGroups()
        {
            return AppDbContext.Resources.Where(r => r.ParentId == null).ToList();
        }

        
    }
}
