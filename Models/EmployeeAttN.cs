using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Core.Models
{
    public class EmployeeAttN
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public string AttendanceTimeIn { get; set; }
        public string AttendanceTimeOut { get; set; }
        public string Department { get; set; }

    }
}