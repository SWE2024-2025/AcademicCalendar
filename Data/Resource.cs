namespace AcademicYearCalendar.Data
{
    public class Resource
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string? TextCss { get; set; }
        
        public string? BackgroundCss { get; set; }

        //public bool IsGroup { get; set; }

        public int? ParentId { get; set; }
        public Resource ParentResource { get; set; }
        public ICollection<Resource> ChildrenResources { get; set; }


        public override bool Equals(object obj)
        {
            Resource resource = obj as Resource;
            return resource != null && resource.Id == Id;
        }
        public override int GetHashCode()
        {
            return Id;
        }
    }
}
