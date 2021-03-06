// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Payment_Module.DiuSac
{
    public partial class Application
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string ApplicationTypeId { get; set; }
        public string ApplicationBody { get; set; }
        public string ApplicationStatusId { get; set; }
        public string SemesterId { get; set; }
        public DateTime AppliedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string RowVersion { get; set; }
        public string CampusId { get; set; }
        public string ExamDecision { get; set; }
        public string AccountsDecision { get; set; }
        public string CoordinationOfficeDecision { get; set; }
        public bool? Paid { get; set; }

        public virtual ApplicationType ApplicationType { get; set; }
        public virtual Student Student { get; set; }
    }
}