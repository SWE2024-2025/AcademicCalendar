using System.ComponentModel.DataAnnotations;

namespace AcademicYearCalendar.Data
{
    public class Staff
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "يجب ادخال اسم عضو هيئة التدريس")]
        [Display(Name = "اسم عضو هيئة التدريس")]
        public string StaffName { get; set; }
    }
}
