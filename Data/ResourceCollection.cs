namespace AcademicYearCalendar.Data
{
    public static partial class ResourceCollection
    {
        public static List<Resource> GetResourcesForGrouping()
        {
            return GetResources().ToList();
        }
        public static List<Resource> GetResources()
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
        public static List<Resource> GetResourceGroups()
        {
            return new List<Resource>() {
                new Resource() { Id=100, Name="البرامج المهنية"},
                new Resource() { Id=300, Name="الدورات التدريبية" },
                new Resource() { Id=200, Name="هيئة اعضاء التدريس" }
            };
        }
    }
}
