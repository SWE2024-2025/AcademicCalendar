namespace AcademicYearCalendar.Data
{
    public class StudySubject
    {
        public int Id { get; set; }

        public string SubjectName { get; set; }

        public List<AcademicProgram> AcademicPrograms { get; set; }
    }
}
