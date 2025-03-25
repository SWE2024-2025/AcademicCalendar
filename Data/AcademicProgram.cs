using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicYearCalendar.Data
{
    public class AcademicProgram
    {
        public int Id { get; set; }

        public string ProgramName { get; set; }

        public List<StudySubject> StudySubjects { get; set; }

        [NotMapped]
        public string SubjectNames => StudySubjects != null
            ? string.Join(Environment.NewLine, StudySubjects.Select(s => s.SubjectName))
            : string.Empty;

    }
}
