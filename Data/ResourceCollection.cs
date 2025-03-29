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
        private List<Resource> GetResources_old()
        {
            return new List<Resource>() {
                new Resource() { Id=0 , Name="دبلوم هندسة البرمجيات", ParentId=100, BackgroundCss="dxbl-green-color", TextCss="text-white" },
                new Resource() { Id=1 , Name="SE106 - Software Project Management - إدارة مشروعات البرمجيات", ParentId=300, BackgroundCss="dxbl-orange-color", TextCss="text-white" },
                new Resource() { Id=2 , Name="SE108 - Agile Software Development - التطوير الرشيق للبرمجيات", ParentId=300, BackgroundCss="dxbl-purple-color", TextCss="text-white" },
                new Resource() { Id=3 , Name="SE107 - Web Design and Architecture - تصميم مواقع الويب", ParentId=300, BackgroundCss="dxbl-indigo-color", TextCss="text-white" },
                new Resource() { Id=4 , Name="SE109 - Programming in the Large (OOP) - البرمجة في الأنظمة الكبيرة", ParentId=300, BackgroundCss="dxbl-red-color", TextCss="text-white" },
                new Resource() { Id=5 , Name="د.عاطف رسلان", ParentId=200, BackgroundCss="dxbl-red-color", TextCss="text-white" },
                new Resource() { Id=6 , Name="د. حسين عبد الجواد", ParentId=200, BackgroundCss="dxbl-red-color", TextCss="text-white" },
                new Resource() { Id=7 , Name="د. نسرين عبد العظيم", ParentId=200, BackgroundCss="dxbl-red-color", TextCss="text-white" },
                new Resource() { Id=8 , Name="د. رضا احمد عبد الصادق", ParentId=200, BackgroundCss="dxbl-red-color", TextCss="text-white" }
            };
        }

        public List<Resource> GetResourceGroups()
        {
            return AppDbContext.Resources.Where(r => r.ParentId == null).ToList();
        }

        private List<Resource> GetResourceGroups_old()
        {
            return new List<Resource>() {
                new Resource() { Id=100, Name="البرامج المهنية"},
                new Resource() { Id=300, Name="الدورات التدريبية" },
                new Resource() { Id=200, Name="هيئة اعضاء التدريس" }
            };
        }
    }
}
