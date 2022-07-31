using System;
using System.Collections.Generic;

namespace SOMCH.Models
{
    public partial class RegEmployeeDepartment
    {
        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DepartmentId { get; set; }
        public string? EmployeeId { get; set; }
        public int? Status { get; set; }

        public virtual RegDepartment? Department { get; set; }
        public virtual RegEmployee? Employee { get; set; }
    }
}
