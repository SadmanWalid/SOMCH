using System;
using System.Collections.Generic;

namespace SOMCH.Models.ScaffoledModels
{
    public partial class RegRoom
    {
        public RegRoom()
        {
            RegDepartmentRooms = new HashSet<RegDepartmentRoom>();
            RegEmployeeRooms = new HashSet<RegEmployeeRoom>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? Capacity { get; set; }
        public string? Description { get; set; }
        public string? FloorName { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? BuildingId { get; set; }
        public string? BuildingName { get; set; }
        public string? FloorId { get; set; }

        public virtual ICollection<RegDepartmentRoom> RegDepartmentRooms { get; set; }
        public virtual ICollection<RegEmployeeRoom> RegEmployeeRooms { get; set; }
    }
}
