using System;
using System.Collections.Generic;

namespace SOMCH.Models.ScaffoledModels
{
    public partial class RegLookupDetail
    {
        public RegLookupDetail()
        {
            InverseParent = new HashSet<RegLookupDetail>();
            RegLookupDetailRelationLookupDetailIdMany1Navigations = new HashSet<RegLookupDetailRelation>();
            RegLookupDetailRelationLookupDetailIdOne1Navigations = new HashSet<RegLookupDetailRelation>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? Description { get; set; }
        public string? LookupEnumKey { get; set; }
        public string? LookupEnumValue { get; set; }
        public string? Name { get; set; }
        public string? ParentId { get; set; }
        public int? SerialNo { get; set; }
        public string? LookupStatusKey { get; set; }
        public string? LookupStatusValue { get; set; }
        public string? LookupDetailEnumKey { get; set; }
        public string? LookupDetailEnumValue { get; set; }
        public string? LookupDetailStatusKey { get; set; }
        public string? LookupDetailStatusValue { get; set; }

        public virtual RegLookupDetail? Parent { get; set; }
        public virtual ICollection<RegLookupDetail> InverseParent { get; set; }
        public virtual ICollection<RegLookupDetailRelation> RegLookupDetailRelationLookupDetailIdMany1Navigations { get; set; }
        public virtual ICollection<RegLookupDetailRelation> RegLookupDetailRelationLookupDetailIdOne1Navigations { get; set; }
    }
}
