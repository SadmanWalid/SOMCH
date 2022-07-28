using System;
using System.Collections.Generic;

namespace SOMCH.Models.ScaffoledModels
{
    public partial class RegLookupDetailRelation
    {
        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? Lookupdetailidmany { get; set; }
        public string? Lookupdetailidone { get; set; }
        public string? LookupDetailIdMany1 { get; set; }
        public string? LookupDetailIdOne1 { get; set; }

        public virtual RegLookupDetail? LookupDetailIdMany1Navigation { get; set; }
        public virtual RegLookupDetail? LookupDetailIdOne1Navigation { get; set; }
    }
}
