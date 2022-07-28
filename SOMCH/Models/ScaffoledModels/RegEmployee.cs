using System;
using System.Collections.Generic;

namespace SOMCH.Models.ScaffoledModels
{
    public partial class RegEmployee
    {
        public RegEmployee()
        {
            RegEmployeeDepartments = new HashSet<RegEmployeeDepartment>();
            RegEmployeeRooms = new HashSet<RegEmployeeRoom>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? BloodGroup { get; set; }
        public string? BloodGroupId { get; set; }
        public string? CardNo { get; set; }
        public string? ContactNumber { get; set; }
        public string? Degree1 { get; set; }
        public string? Degree2 { get; set; }
        public string? Degree3 { get; set; }
        public string? Degree4 { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Drivinglicenceno { get; set; }
        public string? EmailOfficial { get; set; }
        public string? EmailPersonal { get; set; }
        public string? Employeeid { get; set; }
        public string? EmployeeTypeEnumKey { get; set; }
        public string? EmployeeTypeEnumValue { get; set; }
        public string? FatherName { get; set; }
        public string? FirstName { get; set; }
        public string? FullName { get; set; }
        public string? GenderId { get; set; }
        public string? GenderName { get; set; }
        public double? IpdConsultationFee { get; set; }
        public string? JobTitle { get; set; }
        public string? JobTitleId { get; set; }
        public string? JobType { get; set; }
        public DateOnly? JoinDate { get; set; }
        public string? Keycloakemployeeid { get; set; }
        public string? LastName { get; set; }
        public string? MaritalStatus { get; set; }
        public string? MaritalStatusId { get; set; }
        public string? MotherName { get; set; }
        public string? Nationality { get; set; }
        public double? OpdConsultationFee { get; set; }
        public string? PassportNo { get; set; }
        public string? Permanentaddress1 { get; set; }
        public string? Permanentaddress2 { get; set; }
        public string? Permanentaddress3 { get; set; }
        public string? Permanentaddresscountry { get; set; }
        public string? Permanentaddressdistrict { get; set; }
        public string? Permanentaddresspost { get; set; }
        public string? PhoneHome { get; set; }
        public string? PhoneOffice { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? Presentaddress1 { get; set; }
        public string? Presentaddress2 { get; set; }
        public string? Presentaddress3 { get; set; }
        public string? Presentaddresscountry { get; set; }
        public string? Presentaddressdistrict { get; set; }
        public string? Presentaddresspost { get; set; }
        public string? Presentcareofaddress { get; set; }
        public string? ProfileImageFileId { get; set; }
        public string? Religion { get; set; }
        public string? ReligionId { get; set; }
        public string? ReportingTo { get; set; }
        public string? Salutation { get; set; }
        public string? SignatureFileId { get; set; }
        public string? SpouseName { get; set; }
        public string? TinNo { get; set; }
        public string? Username { get; set; }
        public double? ActIpdConsultationFee { get; set; }
        public int? AnaestesiologisInd { get; set; }
        public int? AvgDurationMin { get; set; }
        public int? AvgLoadPerDay { get; set; }
        public int? BlockLoad { get; set; }
        public double? DaycareConsultationFee { get; set; }
        public double? DaycareInd { get; set; }
        public string? Designation { get; set; }
        public int? DocComInd { get; set; }
        public double? DocComPct { get; set; }
        public string? DocLicNo { get; set; }
        public double? DoctorSignature { get; set; }
        public string? DrivinglcNo { get; set; }
        public int? DiscAloewd { get; set; }
        public int? DutyDoctorInd { get; set; }
        public string? Email { get; set; }
        public double? EmrConsultationFee { get; set; }
        public int? EmrConsultationInd { get; set; }
        public string? FaxNo { get; set; }
        public int? IntExtInd { get; set; }
        public int? IpdConsultationInd { get; set; }
        public long? JobtitlePkNo { get; set; }
        public string? MaritalId { get; set; }
        public string? MaritalTxt { get; set; }
        public int? NurseInd { get; set; }
        public double? OffdayRemarks { get; set; }
        public int? OpdAppointmentPol { get; set; }
        public int? OpdConfeecollPol { get; set; }
        public double? OpdConsultationFeeFl { get; set; }
        public double? OpdConsultationFeeRp { get; set; }
        public double? OpdConsultationFeeStaff { get; set; }
        public int? OpdConsultationInd { get; set; }
        public double? OpdConsultationPeriod { get; set; }
        public string? PeCareOfAddr { get; set; }
        public string? PrAddr1 { get; set; }
        public string? PrAddr2 { get; set; }
        public string? PrAddr3 { get; set; }
        public string? PrAddrCountry { get; set; }
        public string? PrAddrDist { get; set; }
        public string? PrAddrPost { get; set; }
        public string? PhoneMobile { get; set; }
        public string? PreferedAddr { get; set; }
        public string? PeAddr1 { get; set; }
        public string? PeAddr2 { get; set; }
        public string? PeAddr3 { get; set; }
        public string? PeAddrCountry { get; set; }
        public string? PeAddrDist { get; set; }
        public string? PeAddrPost { get; set; }
        public string? PreCareOfAddr { get; set; }
        public int? PrimaryDoctorInd { get; set; }
        public double? Qualification { get; set; }
        public int? ReferalInd { get; set; }
        public string? ReferralNotTeken { get; set; }
        public string? Remarks { get; set; }
        public string? RepType { get; set; }
        public int? ReportingInd { get; set; }
        public long? RoomNo { get; set; }
        public int? SampleCollInd { get; set; }
        public long? SpecializationPkNo { get; set; }
        public string? SsNo { get; set; }
        public int? SurgeonInd { get; set; }
        public int? WsInd { get; set; }
        public string? JobTitleName { get; set; }
        public string? JobTypeId { get; set; }
        public string? JobTypeName { get; set; }
        public uint? Menuwithapidtojson { get; set; }
        public string? Keycloakuserid { get; set; }
        public string? PermanentAddress11 { get; set; }
        public string? PermanentAddress21 { get; set; }
        public string? PermanentAddress31 { get; set; }
        public string? PermanentCountry { get; set; }
        public string? PermanentDistrict { get; set; }
        public string? PermanentDivision { get; set; }
        public string? PermanentPost { get; set; }
        public string? PermanentUpazila { get; set; }
        public string? PermanentCountryId { get; set; }
        public string? PermanentDistrictId { get; set; }
        public string? PermanentDivisionId { get; set; }
        public string? PermanentUpazilaId { get; set; }
        public string? PresentAddress11 { get; set; }
        public string? PresentAddress21 { get; set; }
        public string? PresentAddress31 { get; set; }
        public string? PresentCountry { get; set; }
        public string? PresentDistrict { get; set; }
        public string? PresentDivision { get; set; }
        public string? PresentPost { get; set; }
        public string? PresentUpazila { get; set; }
        public string? PresentCofAddress { get; set; }
        public string? PresentCountryId { get; set; }
        public string? PresentDistrictId { get; set; }
        public string? PresentDivisionId { get; set; }
        public string? PresentUpazilaId { get; set; }
        public string? ForgetPasswordCode { get; set; }
        public DateTime? ForgetPasswordCodeGeneratedTime { get; set; }

        public virtual ICollection<RegEmployeeDepartment> RegEmployeeDepartments { get; set; }
        public virtual ICollection<RegEmployeeRoom> RegEmployeeRooms { get; set; }
    }
}
