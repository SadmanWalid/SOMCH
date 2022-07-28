using System;
using System.Collections.Generic;

namespace SOMCH.Models.ScaffoledModels
{
    public partial class RegUserInfo
    {
        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? EmployeeId { get; set; }
        public string? Keycloakuserid { get; set; }
        public string? MobileNumber { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Username { get; set; }
    }
}
