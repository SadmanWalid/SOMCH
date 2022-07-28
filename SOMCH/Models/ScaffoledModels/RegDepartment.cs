using System;
using System.Collections.Generic;

namespace SOMCH.Models.ScaffoledModels
{
    public partial class RegDepartment
    {
        public RegDepartment()
        {
            InverseDepartmentParent = new HashSet<RegDepartment>();
            RegDepartmentRooms = new HashSet<RegDepartmentRoom>();
            RegEmployeeDepartments = new HashSet<RegEmployeeDepartment>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DepartmentParentId { get; set; }
        public string? Name { get; set; }
        public bool? Ipd { get; set; }
        public string? ReportHeader { get; set; }
        public string? DepartmentHead { get; set; }
        public bool? Clinical { get; set; }
        public bool? Defaultind { get; set; }
        public bool? Dental { get; set; }
        public bool? Dispensary { get; set; }
        public bool? Eye { get; set; }
        public bool? Medical { get; set; }
        public bool? Pathology { get; set; }
        public bool? Radiology { get; set; }
        public bool? Opd { get; set; }
        public bool? Cashpoint { get; set; }
        public bool? Centralstore { get; set; }
        public bool? Prescriptionstore { get; set; }
        public bool? Requisitionto { get; set; }

        public virtual RegDepartment? DepartmentParent { get; set; }
        public virtual ICollection<RegDepartment> InverseDepartmentParent { get; set; }
        public virtual ICollection<RegDepartmentRoom> RegDepartmentRooms { get; set; }
        public virtual ICollection<RegEmployeeDepartment> RegEmployeeDepartments { get; set; }
    }
}
