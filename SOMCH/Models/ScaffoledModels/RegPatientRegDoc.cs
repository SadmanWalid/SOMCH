using System;
using System.Collections.Generic;

namespace SOMCH.Models.ScaffoledModels
{
    public partial class RegPatientRegDoc
    {
        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? FileId { get; set; }
        public string? Name { get; set; }
        public string? PatientRegInfoId { get; set; }

        public virtual RegPatientRegInfo? PatientRegInfo { get; set; }
    }
}
