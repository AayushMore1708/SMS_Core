using Microsoft.EntityFrameworkCore;

namespace SMS_Core.Models
{
    public class SMSDbContext : DbContext
    {
        public SMSDbContext(DbContextOptions<SMSDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define primary keys for the tables
            modelBuilder.Entity<tblStudentAdmission>().HasKey(e => e.StudentAdmissionId);
            modelBuilder.Entity<tblLessonPlanning>().HasKey(e => e.LessonPlanningId);
            modelBuilder.Entity<tblMiscCat>().HasKey(e => e.AcadamicMiscId);
            modelBuilder.Entity<tblPayHead>().HasKey(e => e.PayHeadId);
            modelBuilder.Entity<tblPurchaseOrder>().HasKey(e => e.PurcahseOrderId);
            modelBuilder.Entity<tblStockItem>().HasKey(e => e.ItemId);
            modelBuilder.Entity<tblSubject>().HasKey(e => e.SubjectId);
            modelBuilder.Entity<tblEmployee>().HasKey(e => e.UserID);
            // Add more primary key definitions as required
        }

        // DbSets (tables)
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<tblLessonPlanning> tblLessonPlanning { get; set; }
        public DbSet<tblInstitute> tblInstitute { get; set; }
        public DbSet<tblAcadamicYear> tblAcadamicYear { get; set; }

        public DbSet<TaskM> TaskM { get; set; }
        public DbSet<tblLessonPlanningDT> tblLessonPlanningDT { get; set; }
        public DbSet<lkpReligion> lkpReligion { get; set; }
        public DbSet<TaskDTM> TaskDTM { get; set; }
        public DbSet<tblMiscCat> tblMiscCat { get; set; }
        public DbSet<tblPayHead> tblPayHead { get; set; }
        public DbSet<tblPurchaseOrder> tblPurchaseOrder { get; set; }
        public DbSet<tblPurchaseOrderDT> tblPurchaseOrderDT { get; set; }
        public DbSet<tblPurchaseReceipt> tblPurchaseReceipt { get; set; }
        public DbSet<tblSalaryHD> tblSalaryHD { get; set; }
        public DbSet<tblSalaryMaster> tblSalaryMaster { get; set; }
        public DbSet<tblStockInventoryItem> tblStockInventoryItem { get; set; }
        public DbSet<tblStockIssue> tblStockIssue { get; set; }
        public DbSet<tblStockItem> tblStockItem { get; set; }
        public DbSet<tblStoreInventoryCatg> tblStoreInventoryCatg { get; set; }
        public DbSet<tblStudentAdmission> tblStudentAdmission { get; set; }
        public DbSet<tblStudentEnquiry> tblStudentEnquiry { get; set; }
        public DbSet<tblStudentGatePass> tblStudentGatePass { get; set; }
        public DbSet<tblSubject> tblSubject { get; set; }
        public DbSet<tblTransportAllocation> tblTransportAllocation { get; set; }
        public DbSet<tblTransportDriver> tblTransportDriver { get; set; }
        public DbSet<tblTransportFeeCollection> tblTransportFeeCollection { get; set; }
        public DbSet<tblTransportVehicle> tblTransportVehicle { get; set; }
        public DbSet<lkpCaste> lkpCaste { get; set; }
        public DbSet<lkpCategory> lkpCategory { get; set; }
        public DbSet<lkpDepartment> lkpDepartment { get; set; }
        public DbSet<lkpDesignation> lkpDesignation { get; set; }
        public DbSet<lkpExam> lkpExam { get; set; }
        public DbSet<lkpGradePoint> lkpGradePoint { get; set; }
        public DbSet<tblTimeTableDT> tblTimeTableDT { get; set; }
        public DbSet<MstVoucher> MstVoucher { get; set; }
        public DbSet<tblTimeTableHD> tblTimeTableHD { get; set; }
        public DbSet<tblBookCategory> tblBookCategory { get; set; }
        public DbSet<tblBook> tblBook { get; set; }
        public DbSet<tblBookIssue> tblBookIssue { get; set; }
        public DbSet<tblBookReturn> tblBookReturn { get; set; }
        public DbSet<tblFeePaymentDTAY25> tblFeePaymentDTAY25 { get; set; }
        public DbSet<tblFeePaymentDT> tblFeePaymentDT { get; set; }
        public DbSet<tblFeeCategory> tblFeeCategory { get; set; }
        public DbSet<tblFeeSubCategory> tblFeeSubCategory { get; set; }
        public DbSet<tblLeaveApplication> tblLeaveApplication { get; set; }
        public DbSet<tblLeaveCategory> tblLeaveCategory { get; set; }
        public DbSet<tblLeaveDetail> tblLeaveDetail { get; set; }
        public DbSet<tblExamTerm> tblExamTerm { get; set; }
        public DbSet<tblExamMarkSet> tblExamMarkSet { get; set; }
        public DbSet<tblExamMarkObtained> tblExamMarkObtained { get; set; }
        public DbSet<tblCertification> tblCertification { get; set; }
        public DbSet<tblAssignment> tblAssignment { get; set; }
        public DbSet<tblAssignmentNote> tblAssignmentNote { get; set; }
        public DbSet<tblConversation> tblConversation { get; set; }
        public DbSet<tblInventoryIssue> tblInventoryIssue { get; set; }
        public DbSet<tblInventoryIssueDtl> tblInventoryIssueDtl { get; set; }
        public DbSet<tblClassTeacherAllocation> tblClassTeacherAllocation { get; set; }
        public DbSet<tblStudentAdmissionAY25> tblStudentAdmissionAY25 { get; set; }
        public DbSet<tblExamHall> tblExamHall { get; set; }
        public DbSet<tblExamHallManagement> tblExamHallManagement { get; set; }
        public DbSet<tblFeeAllocation> tblFeeAllocation { get; set; }
        public DbSet<tblFeeSubCategoryFine> tblFeeSubCategoryFine { get; set; }
        public DbSet<tblAcadamicCource> tblAcadamicCource { get; set; }
        public DbSet<tblFeeWaiver> tblFeeWaiver { get; set; }
        public DbSet<tblGenerateCertificate> tblGenerateCertificate { get; set; }
        public DbSet<tblStoreVendor> tblStoreVendor { get; set; }
        public DbSet<tblCourseBatch> tblCourseBatch { get; set; }
        public DbSet<tblEmployeeAttendance> tblEmployeeAttendance { get; set; }
        public DbSet<tblEmployeeSalaryDT> tblEmployeeSalaryDT { get; set; }
        public DbSet<tblEmployeeSalaryHD> tblEmployeeSalaryHD { get; set; }
        public DbSet<tblStudentAttendance> tblStudentAttendance { get; set; }
        public DbSet<tblVisitor> tblVisitor { get; set; }
        public DbSet<tblVoucher> tblVoucher { get; set; }
        public DbSet<tblVoucherHead> tblVoucherHead { get; set; }
     
        public DbSet<PrimEngFee> PrimEngFee { get; set; }
        public DbSet<StudentMarks> StudentMarks { get; set; }
        public DbSet<HDdailyUpdate> HDdailyUpdate { get; set; }
        public DbSet<DTDailyUpdate> DTDailyUpdate { get; set; }
        public DbSet<tblAutoIncrement> tblAutoIncrement { get; set; }
    }
}