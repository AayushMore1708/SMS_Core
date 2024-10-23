using SMS_Core.Models;

namespace SMS_Core.ViewModel
{
     public class StudentListViewModel
    {
        public IEnumerable<tblStudentAdmission> Students { get; set; }
        public int TotalStudents { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }

    
}
