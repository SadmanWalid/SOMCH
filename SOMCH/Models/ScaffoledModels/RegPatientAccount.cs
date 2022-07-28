using System;
using System.Collections.Generic;

namespace SOMCH.Models.ScaffoledModels
{
    public partial class RegPatientAccount
    {
        public RegPatientAccount()
        {
            RegPatientRegInfoPatientAccounts = new HashSet<RegPatientRegInfo>();
            RegPatientRegInfoPatients = new HashSet<RegPatientRegInfo>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Password { get; set; }

        public virtual ICollection<RegPatientRegInfo> RegPatientRegInfoPatientAccounts { get; set; }
        public virtual ICollection<RegPatientRegInfo> RegPatientRegInfoPatients { get; set; }
    }
}
