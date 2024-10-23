using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Core.Models
{
    public class EmployeeAtt
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public string AttendanceTimeIn { get; set; }
        public string SubjectName { get; set; }

    }
}