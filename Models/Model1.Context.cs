using Microsoft.EntityFrameworkCore;
using System;

namespace SMS_Core.Models
{
    public partial class Entities : DbContext
    {
        public Entities(DbContextOptions<Entities> options) : base(options) { }

        public virtual DbSet<MstVoucher> MstVouchers { get; set; }
        public virtual DbSet<tblAcadamicYear> tblAcadamicYears { get; set; }
        public virtual DbSet<tblAccountGroup> tblAccountGroups { get; set; }
        public virtual DbSet<tblAssignment> tblAssignments { get; set; }
        public virtual DbSet<tblAssignmentNote> tblAssignmentNotes { get; set; }
        public virtual DbSet<tblBook> tblBooks { get; set; }
        public virtual DbSet<tblBookCategory> tblBookCategories { get; set; }
        public virtual DbSet<tblBookIssue> tblBookIssues { get; set; }
        public virtual DbSet<tblBookRequest> tblBookRequests { get; set; }
        public virtual DbSet<tblBookReturn> tblBookReturns { get; set; }
        public virtual DbSet<tblCertification> tblCertifications { get; set; }
        public virtual DbSet<tblCircular> tblCirculars { get; set; }
        public virtual DbSet<tblClassTeacherAllocation> tblClassTeacherAllocations { get; set; }
        public virtual DbSet<tblCourseBatch> tblCourseBatches { get; set; }
        public virtual DbSet<tblEmployeeSalaryDT> tblEmployeeSalaryDTs { get; set; }
        public virtual DbSet<tblEmployeeSalaryHD> tblEmployeeSalaryHDs { get; set; }
        public virtual DbSet<tblExamHall> tblExamHalls { get; set; }
        public virtual DbSet<tblExamHallManagement> tblExamHallManagements { get; set; }
        public virtual DbSet<tblExamTerm> tblExamTerms { get; set; }
        public virtual DbSet<tblFeeCategory> tblFeeCategories { get; set; }
        public virtual DbSet<tblFeeSubCategory> tblFeeSubCategories { get; set; }
        public virtual DbSet<tblFeeSubCategoryFine> tblFeeSubCategoryFines { get; set; }
        public virtual DbSet<tblFeeWaiver> tblFeeWaivers { get; set; }
        public virtual DbSet<tblGenerateCertificate> tblGenerateCertificates { get; set; }
        public virtual DbSet<tblLeaveApplication> tblLeaveApplications { get; set; }
        public virtual DbSet<tblLeaveCategory> tblLeaveCategories { get; set; }
        public virtual DbSet<tblLeaveDetail> tblLeaveDetails { get; set; }
        public virtual DbSet<tblMiscCat> tblMiscCats { get; set; }
        public virtual DbSet<tblPayHead> tblPayHeads { get; set; }
        public virtual DbSet<tblStockIssue> tblStockIssues { get; set; }
        public virtual DbSet<tblStoreInventoryCatg> tblStoreInventoryCatgs { get; set; }
        public virtual DbSet<tblStoreVendor> tblStoreVendors { get; set; }
        public virtual DbSet<tblStudentEnquiry> tblStudentEnquiries { get; set; }
        public virtual DbSet<tblStudentGatePass> tblStudentGatePasses { get; set; }
        public virtual DbSet<tblSubject> tblSubjects { get; set; }
        public virtual DbSet<tblSubjectAllocationEmp> tblSubjectAllocationEmps { get; set; }
        public virtual DbSet<tblTransportAllocation> tblTransportAllocations { get; set; }
        public virtual DbSet<tblTransportDestinationFee> tblTransportDestinationFees { get; set; }
        public virtual DbSet<tblTransportDriver> tblTransportDrivers { get; set; }
        public virtual DbSet<tblTransportFeeCollection> tblTransportFeeCollections { get; set; }
        public virtual DbSet<tblTransportRoute> tblTransportRoutes { get; set; }
        public virtual DbSet<tblTransportVehicle> tblTransportVehicles { get; set; }
        public virtual DbSet<tblVoucher> tblVouchers { get; set; }
        public virtual DbSet<tblVoucherHead> tblVoucherHeads { get; set; }
        public virtual DbSet<tblInstitute> tblInstitutes { get; set; }
        public virtual DbSet<qryAcadamicYear> qryAcadamicYears { get; set; }
        public virtual DbSet<tblAssignSubject> tblAssignSubjects { get; set; }
        public virtual DbSet<tblAutoIncrement> tblAutoIncrements { get; set; }
        public virtual DbSet<tblLessonPlanning> tblLessonPlannings { get; set; }
        public virtual DbSet<tblLessonPlanningDT> tblLessonPlanningDTs { get; set; }
        public virtual DbSet<tblFeeAllocation> tblFeeAllocations { get; set; }
        public virtual DbSet<qryCategoryName> qryCategoryNames { get; set; }
        public virtual DbSet<qryFeeSubCategory> qryFeeSubCategories { get; set; }
        public virtual DbSet<tblAcadamicCource> tblAcadamicCources { get; set; }
        public virtual DbSet<lkpCaste> lkpCastes { get; set; }
        public virtual DbSet<lkpCategory> lkpCategories { get; set; }
        public virtual DbSet<lkpDepartment> lkpDepartments { get; set; }
        public virtual DbSet<lkpDesignation> lkpDesignations { get; set; }
        public virtual DbSet<lkpReligion> lkpReligions { get; set; }
        public virtual DbSet<tblTimeTableDT> tblTimeTableDTs { get; set; }
        public virtual DbSet<tblTimeTableHD> tblTimeTableHDs { get; set; }
        public virtual DbSet<lkpExam> lkpExams { get; set; }
        public virtual DbSet<lkpGradePoint> lkpGradePoints { get; set; }
        public virtual DbSet<tblExamMarkSet> tblExamMarkSets { get; set; }
        public virtual DbSet<qryExamTerm> qryExamTerms { get; set; }
        public virtual DbSet<qryExamMarkObtained> qryExamMarkObtaineds { get; set; }
        public virtual DbSet<tblExamMarkObtained> tblExamMarkObtaineds { get; set; }
        public virtual DbSet<tblStudentAttendance> tblStudentAttendances { get; set; }
        public virtual DbSet<tblVisitor> tblVisitors { get; set; }
        public virtual DbSet<qryBookIssue> qryBookIssues { get; set; }
        public virtual DbSet<qryTaskView> qryTaskViews { get; set; }
        public virtual DbSet<TaskDTM> TaskDTMs { get; set; }
        public virtual DbSet<TaskM> TaskMs { get; set; }
        public virtual DbSet<tblPurchaseOrder> tblPurchaseOrders { get; set; }
        public virtual DbSet<tblPurchaseOrderDT> tblPurchaseOrderDTs { get; set; }
        public virtual DbSet<qryStoreVendor> qryStoreVendors { get; set; }
        public virtual DbSet<tblStockItem> tblStockItems { get; set; }
        public virtual DbSet<tblPurchaseReceipt> tblPurchaseReceipts { get; set; }
        public virtual DbSet<tblStockInventoryItem> tblStockInventoryItems { get; set; }
        public virtual DbSet<tblInventoryIssue> tblInventoryIssues { get; set; }
        public virtual DbSet<tblInventoryIssueDtl> tblInventoryIssueDtls { get; set; }
        public virtual DbSet<tblSalaryHD> tblSalaryHDs { get; set; }
        public virtual DbSet<tblSalaryMaster> tblSalaryMasters { get; set; }
        public virtual DbSet<tblAcadamicCertificate> tblAcadamicCertificates { get; set; }
        public virtual DbSet<tblLeavingCertificate> tblLeavingCertificates { get; set; }
        public virtual DbSet<tblConversation> tblConversations { get; set; }
        public virtual DbSet<qryUser> qryUsers { get; set; }
        public virtual DbSet<qryBook> qryBooks { get; set; }
        public virtual DbSet<qryEmployee> qryEmployees { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<PayHead> PayHeads { get; set; }
        public virtual DbSet<TaskDT> TaskDTs { get; set; }
        public virtual DbSet<tblEmployeeAttendance> tblEmployeeAttendances { get; set; }
        public virtual DbSet<qryBookReturn> qryBookReturns { get; set; }
        public virtual DbSet<qryClassTeacher> qryClassTeachers { get; set; }
        public virtual DbSet<qrySubjectTeacher> qrySubjectTeachers { get; set; }
        public virtual DbSet<qryStudentAttendance> qryStudentAttendances { get; set; }
        public virtual DbSet<qryTimeTable> qryTimeTables { get; set; }
        public virtual DbSet<qryConversation> qryConversations { get; set; }
        public virtual DbSet<ContinuousDescriptiveNote> ContinuousDescriptiveNotes { get; set; }
        public virtual DbSet<tblStudentAdmission> tblStudentAdmissions { get; set; }
        public virtual DbSet<qryExamMarkSet> qryExamMarkSets { get; set; }
        public virtual DbSet<tblFeePayment> tblFeePayments { get; set; }
        public virtual DbSet<tblFeePaymentDT> tblFeePaymentDTs { get; set; }
        public virtual DbSet<qryStudentNew> qryStudentNews { get; set; }
        public virtual DbSet<qryExamMarkObtainedNew> qryExamMarkObtainedNews { get; set; }
        public virtual DbSet<HDdailyUpdate> HDdailyUpdates { get; set; }
        public virtual DbSet<DTDailyUpdate> DTDailyUpdates { get; set; }
        public virtual DbSet<qryFeePayment> qryFeePayments { get; set; }
        public virtual DbSet<qryFeePaymentOld> qryFeePaymentOlds { get; set; }
        public virtual DbSet<qryFeePaymentReport> qryFeePaymentReports { get; set; }
        public virtual DbSet<qryFeePaymentBalance> qryFeePaymentBalances { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<qryFeePaymentNew> qryFeePaymentNews { get; set; }
        public virtual DbSet<qryCollectionSummary> qryCollectionSummaries { get; set; }
        public virtual DbSet<PrimEngFee> PrimEngFees { get; set; }
        public virtual DbSet<qryReport1Student> qryReport1Student { get; set; }
        public virtual DbSet<qryBalancePending> qryBalancePendings { get; set; }
        public virtual DbSet<tblOnlinePayment> tblOnlinePayments { get; set; }
        public virtual DbSet<qryFeeSubCategoryNew> qryFeeSubCategoryNews { get; set; }
        public virtual DbSet<qryStudentAdmission> qryStudentAdmissions { get; set; }
        public virtual DbSet<qryFeepaymentNew1> qryFeepaymentNew1 { get; set; }
        public virtual DbSet<qryCollectionSummaryNew> qryCollectionSummaryNews { get; set; }
        public virtual DbSet<qryStudentAdmissionAY25> qryStudentAdmissionAY25 { get; set; }
        public virtual DbSet<qryFeePaymentNewAY25> qryFeePaymentNewAY25 { get; set; }
        public virtual DbSet<tblStudentAdmissionAY25> tblStudentAdmissionAY25 { get; set; }
        public virtual DbSet<qryFeePaymentAY25> qryFeePaymentAY25 { get; set; }
        public virtual DbSet<qryFeeSubCategory25> qryFeeSubCategory25 { get; set; }
        public virtual DbSet<tblFeePaymentAY25> tblFeePaymentAY25 { get; set; }
        public virtual DbSet<tblFeePaymentDTAY25> tblFeePaymentDTAY25 { get; set; }
        public virtual DbSet<qryCollectionSummaryNew25> qryCollectionSummaryNew25 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Example: Configure a table mapping (if needed)
            modelBuilder.Entity<MstVoucher>().ToTable("MstVoucher");

            // Additional configurations can go here

            base.OnModelCreating(modelBuilder);
        }
    }
}
