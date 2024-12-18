//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMS_Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class qryExamMarkSet
    {        [Key]
        public int ExamMarkID { get; set; }
        public string ExamName { get; set; }
        public string CourseName { get; set; }
        public string BatchName { get; set; }
        public string Subject { get; set; }
        public Nullable<int> Theory { get; set; }
        public Nullable<int> Practice { get; set; }
        public Nullable<int> TotalMark { get; set; }
        public Nullable<System.DateTime> ExamDate { get; set; }
        public Nullable<System.TimeSpan> ExamStartTime { get; set; }
        public Nullable<System.TimeSpan> ExamEndTime { get; set; }
        public string ExamDesc { get; set; }
        public string SubjectMarks { get; set; }
        public string AcadamicYear { get; set; }
        public Nullable<int> FormulationDaytoDayObservation { get; set; }
        public Nullable<int> FormulationOralwork { get; set; }
        public Nullable<int> FormulationPracticalExperiment { get; set; }
        public Nullable<int> FormulationActivity { get; set; }
        public Nullable<int> FormulationProject { get; set; }
        public Nullable<int> FormulationTestOpenBook { get; set; }
        public Nullable<int> FormulationHomeClasswork { get; set; }
        public Nullable<int> FormulationOthers { get; set; }
        public Nullable<int> FormulationTotalA { get; set; }
        public Nullable<int> SummativeTheory { get; set; }
        public Nullable<int> SummativeOralPractical { get; set; }
        public Nullable<int> SummativeTotalB { get; set; }
    }
}
