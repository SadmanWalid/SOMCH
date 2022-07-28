using System;
using System.Collections.Generic;

namespace SOMCH.Models.ScaffoledModels
{
    public partial class RegPatientRegInfo
    {
        public RegPatientRegInfo()
        {
            RegPatientRegDocs = new HashSet<RegPatientRegDoc>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? AgeInDay { get; set; }
        public int? AgeInMonth { get; set; }
        public int? AgeInYear { get; set; }
        public string? BirthCertificateNo { get; set; }
        public string? BloodGroupId { get; set; }
        public string? BloodGroupName { get; set; }
        public string? CoName { get; set; }
        public string? CoPhoneNumber { get; set; }
        public string? CoRelationshipEnumKey { get; set; }
        public string? CoRelationshipEnumValue { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Email { get; set; }
        public string? EmergencyContractAddress { get; set; }
        public string? EmergencyContractName { get; set; }
        public string? EmergencyContractPhone { get; set; }
        public string? EmergencyContractRelationshipEnumKey { get; set; }
        public string? EmergencyContractRelationshipEnumValue { get; set; }
        public string? GenderId { get; set; }
        public string? GenderName { get; set; }
        public string? GovtIdType { get; set; }
        public string? IdentityMark { get; set; }
        public string? MaritalStatusId { get; set; }
        public string? MaritalStatusName { get; set; }
        public string? NationalId { get; set; }
        public string? NationalityId { get; set; }
        public string? NationalityName { get; set; }
        public string? OccupationId { get; set; }
        public string? OccupationName { get; set; }
        public string? PassportNo { get; set; }
        public string? PatientName { get; set; }
        public string PatientRegId { get; set; } = null!;
        public string PatientRelationTypeEnumKey { get; set; } = null!;
        public string PatientRelationTypeEnumValue { get; set; } = null!;
        public string PatientTypeEnumKey { get; set; } = null!;
        public string PatientTypeEnumValue { get; set; } = null!;
        public string? PermanentAddress { get; set; }
        public string? PermanentDistrict { get; set; }
        public string? PermanentDivision { get; set; }
        public string? PermanentThana { get; set; }
        public string? PermanentUpazila { get; set; }
        public string? PermanentDistrictId { get; set; }
        public string? PermanentDivisionId { get; set; }
        public string? PermanentThanaId { get; set; }
        public string? PermanentUpazilaId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PresentAddress { get; set; }
        public string? PresentDistrict { get; set; }
        public string? PresentDivision { get; set; }
        public string? PresentThana { get; set; }
        public string? PresentUpazila { get; set; }
        public string? PresentDistrictId { get; set; }
        public string? PresentDivisionId { get; set; }
        public string? PresentThanaId { get; set; }
        public string? PresentUpazilaId { get; set; }
        public string? ProfileImageFileId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string RegistrationTypeEnumKey { get; set; } = null!;
        public string RegistrationTypeEnumValue { get; set; } = null!;
        public string? ReligionId { get; set; }
        public string? ReligionName { get; set; }
        public string? CoRelationship { get; set; }
        public string? Occupation { get; set; }
        public string? PermanentAddr { get; set; }
        public long? PermanentDistrictLookupListPkNo { get; set; }
        public long? PermanentDivisionLookupListPkNo { get; set; }
        public long? PermanentUpazilaLookupListPkNo { get; set; }
        public string? PresentAddr { get; set; }
        public long? PresentDistrictLookupListPkNo { get; set; }
        public long? PresentDivisionLookupListPkNo { get; set; }
        public long? PresentUpazilaLookupListPkNo { get; set; }
        public string? PatientAccountId { get; set; }
        public string? EmergencyContractRelationship { get; set; }
        public bool? PrivilegedPatientApproved { get; set; }
        public string? PatientId { get; set; }

        public virtual RegPatientAccount? Patient { get; set; }
        public virtual RegPatientAccount? PatientAccount { get; set; }
        public virtual ICollection<RegPatientRegDoc> RegPatientRegDocs { get; set; }
    }
}
