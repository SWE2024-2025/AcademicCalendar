using System.ComponentModel.DataAnnotations;

namespace AcademicYearCalendar.Data
{
    public class StudySubject
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "يجب ادخال اسم المادة الدراسية")]
        [Display(Name = "اسم المادة الدراسية")]
        public string SubjectName { get; set; }

        public List<AcademicProgram> AcademicPrograms { get; set; }
    }
}
