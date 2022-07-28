using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SOMCH.Models.ScaffoledModels
{
    public partial class registration2Context : DbContext
    {
        public registration2Context()
        {
        }

        public registration2Context(DbContextOptions<registration2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Databasechangelog> Databasechangelogs { get; set; } = null!;
        public virtual DbSet<Databasechangeloglock> Databasechangeloglocks { get; set; } = null!;
        public virtual DbSet<FileInfo> FileInfos { get; set; } = null!;
        public virtual DbSet<RegDepartment> RegDepartments { get; set; } = null!;
        public virtual DbSet<RegDepartmentRoom> RegDepartmentRooms { get; set; } = null!;
        public virtual DbSet<RegDoctorRoomLog> RegDoctorRoomLogs { get; set; } = null!;
        public virtual DbSet<RegEmployee> RegEmployees { get; set; } = null!;
        public virtual DbSet<RegEmployeeDepartment> RegEmployeeDepartments { get; set; } = null!;
        public virtual DbSet<RegEmployeeRoom> RegEmployeeRooms { get; set; } = null!;
        public virtual DbSet<RegLookupDetail> RegLookupDetails { get; set; } = null!;
        public virtual DbSet<RegLookupDetailRelation> RegLookupDetailRelations { get; set; } = null!;
        public virtual DbSet<RegPatientAccount> RegPatientAccounts { get; set; } = null!;
        public virtual DbSet<RegPatientRegDoc> RegPatientRegDocs { get; set; } = null!;
        public virtual DbSet<RegPatientRegInfo> RegPatientRegInfos { get; set; } = null!;
        public virtual DbSet<RegPriceSetup> RegPriceSetups { get; set; } = null!;
        public virtual DbSet<RegRoom> RegRooms { get; set; } = null!;
        public virtual DbSet<RegUserInfo> RegUserInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Name=ConnectionStrings:RegistrationDatabase");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Databasechangelog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("databasechangelog");

                entity.Property(e => e.Author)
                    .HasMaxLength(255)
                    .HasColumnName("author");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.Contexts)
                    .HasMaxLength(255)
                    .HasColumnName("contexts");

                entity.Property(e => e.Dateexecuted)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dateexecuted");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Exectype)
                    .HasMaxLength(10)
                    .HasColumnName("exectype");

                entity.Property(e => e.Filename)
                    .HasMaxLength(255)
                    .HasColumnName("filename");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Labels)
                    .HasMaxLength(255)
                    .HasColumnName("labels");

                entity.Property(e => e.Liquibase)
                    .HasMaxLength(20)
                    .HasColumnName("liquibase");

                entity.Property(e => e.Md5sum)
                    .HasMaxLength(35)
                    .HasColumnName("md5sum");

                entity.Property(e => e.Orderexecuted).HasColumnName("orderexecuted");

                entity.Property(e => e.Tag)
                    .HasMaxLength(255)
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<Databasechangeloglock>(entity =>
            {
                entity.ToTable("databasechangeloglock");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.Lockedby)
                    .HasMaxLength(255)
                    .HasColumnName("lockedby");

                entity.Property(e => e.Lockgranted)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lockgranted");
            });

            modelBuilder.Entity<FileInfo>(entity =>
            {
                entity.ToTable("file_info");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Filecategoryenumkey)
                    .HasMaxLength(255)
                    .HasColumnName("filecategoryenumkey");

                entity.Property(e => e.Filenamewithextension)
                    .HasMaxLength(255)
                    .HasColumnName("filenamewithextension");

                entity.Property(e => e.Filerelativepath)
                    .HasMaxLength(255)
                    .HasColumnName("filerelativepath");

                entity.Property(e => e.Filerootpath)
                    .HasMaxLength(255)
                    .HasColumnName("filerootpath");

                entity.Property(e => e.Filetypeenumkey)
                    .HasMaxLength(255)
                    .HasColumnName("filetypeenumkey");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");
            });

            modelBuilder.Entity<RegDepartment>(entity =>
            {
                entity.ToTable("reg_department");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Cashpoint).HasColumnName("cashpoint");

                entity.Property(e => e.Centralstore).HasColumnName("centralstore");

                entity.Property(e => e.Clinical).HasColumnName("clinical");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Defaultind).HasColumnName("defaultind");

                entity.Property(e => e.Dental).HasColumnName("dental");

                entity.Property(e => e.DepartmentHead)
                    .HasMaxLength(255)
                    .HasColumnName("department_head");

                entity.Property(e => e.DepartmentParentId)
                    .HasMaxLength(255)
                    .HasColumnName("department_parent_id");

                entity.Property(e => e.Dispensary).HasColumnName("dispensary");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Eye).HasColumnName("eye");

                entity.Property(e => e.Ipd).HasColumnName("ipd");

                entity.Property(e => e.Medical).HasColumnName("medical");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Opd).HasColumnName("opd");

                entity.Property(e => e.Pathology).HasColumnName("pathology");

                entity.Property(e => e.Prescriptionstore).HasColumnName("prescriptionstore");

                entity.Property(e => e.Radiology).HasColumnName("radiology");

                entity.Property(e => e.ReportHeader)
                    .HasMaxLength(255)
                    .HasColumnName("report_header");

                entity.Property(e => e.Requisitionto).HasColumnName("requisitionto");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");

                entity.HasOne(d => d.DepartmentParent)
                    .WithMany(p => p.InverseDepartmentParent)
                    .HasForeignKey(d => d.DepartmentParentId)
                    .HasConstraintName("fk_reg_department_department_parent_id");
            });

            modelBuilder.Entity<RegDepartmentRoom>(entity =>
            {
                entity.ToTable("reg_department_room");

                entity.HasIndex(e => new { e.DepartmentId, e.RoomId }, "uk_reg_department_room_department_id_room_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(255)
                    .HasColumnName("department_id");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.RoomId)
                    .HasMaxLength(255)
                    .HasColumnName("room_id");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.RegDepartmentRooms)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("fk_reg_department_department_id");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.RegDepartmentRooms)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("fk_reg_department_room_room_id");
            });

            modelBuilder.Entity<RegDoctorRoomLog>(entity =>
            {
                entity.ToTable("reg_doctor_room_log");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Doctorroomstatusenumkey)
                    .HasMaxLength(255)
                    .HasColumnName("doctorroomstatusenumkey");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");
            });

            modelBuilder.Entity<RegEmployee>(entity =>
            {
                entity.ToTable("reg_employee");

                entity.HasIndex(e => e.Username, "uk_reg_employee_username")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.ActIpdConsultationFee).HasColumnName("act_ipd_consultation_fee");

                entity.Property(e => e.AnaestesiologisInd).HasColumnName("anaestesiologis_ind");

                entity.Property(e => e.AvgDurationMin).HasColumnName("avg_duration_min");

                entity.Property(e => e.AvgLoadPerDay).HasColumnName("avg_load_per_day");

                entity.Property(e => e.BlockLoad).HasColumnName("block_load");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(255)
                    .HasColumnName("blood_group");

                entity.Property(e => e.BloodGroupId)
                    .HasMaxLength(255)
                    .HasColumnName("blood_group_id");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(255)
                    .HasColumnName("card_no");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(255)
                    .HasColumnName("contact_number");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DaycareConsultationFee).HasColumnName("daycare_consultation_fee");

                entity.Property(e => e.DaycareInd).HasColumnName("daycare_ind");

                entity.Property(e => e.Degree1)
                    .HasMaxLength(255)
                    .HasColumnName("degree1");

                entity.Property(e => e.Degree2)
                    .HasMaxLength(255)
                    .HasColumnName("degree2");

                entity.Property(e => e.Degree3)
                    .HasMaxLength(255)
                    .HasColumnName("degree3");

                entity.Property(e => e.Degree4)
                    .HasMaxLength(255)
                    .HasColumnName("degree4");

                entity.Property(e => e.Designation)
                    .HasMaxLength(255)
                    .HasColumnName("designation");

                entity.Property(e => e.DiscAloewd).HasColumnName("disc_aloewd");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.DocComInd).HasColumnName("doc_com_ind");

                entity.Property(e => e.DocComPct).HasColumnName("doc_com_pct");

                entity.Property(e => e.DocLicNo)
                    .HasMaxLength(255)
                    .HasColumnName("doc_lic_no");

                entity.Property(e => e.DoctorSignature).HasColumnName("doctor_signature");

                entity.Property(e => e.DrivinglcNo)
                    .HasMaxLength(255)
                    .HasColumnName("drivinglc_no");

                entity.Property(e => e.Drivinglicenceno)
                    .HasMaxLength(255)
                    .HasColumnName("drivinglicenceno");

                entity.Property(e => e.DutyDoctorInd).HasColumnName("duty_doctor_ind");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.EmailOfficial)
                    .HasMaxLength(255)
                    .HasColumnName("email_official");

                entity.Property(e => e.EmailPersonal)
                    .HasMaxLength(255)
                    .HasColumnName("email_personal");

                entity.Property(e => e.EmployeeTypeEnumKey)
                    .HasMaxLength(35)
                    .HasColumnName("employee_type_enum_key");

                entity.Property(e => e.EmployeeTypeEnumValue)
                    .HasMaxLength(50)
                    .HasColumnName("employee_type_enum_value");

                entity.Property(e => e.Employeeid)
                    .HasMaxLength(255)
                    .HasColumnName("employeeid");

                entity.Property(e => e.EmrConsultationFee).HasColumnName("emr_consultation_fee");

                entity.Property(e => e.EmrConsultationInd).HasColumnName("emr_consultation_ind");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(255)
                    .HasColumnName("father_name");

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(255)
                    .HasColumnName("fax_no");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.ForgetPasswordCode)
                    .HasMaxLength(255)
                    .HasColumnName("forget_password_code");

                entity.Property(e => e.ForgetPasswordCodeGeneratedTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("forget_password_code_generated_time");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("full_name");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(255)
                    .HasColumnName("gender_id");

                entity.Property(e => e.GenderName)
                    .HasMaxLength(255)
                    .HasColumnName("gender_name");

                entity.Property(e => e.IntExtInd).HasColumnName("int_ext_ind");

                entity.Property(e => e.IpdConsultationFee).HasColumnName("ipd_consultation_fee");

                entity.Property(e => e.IpdConsultationInd).HasColumnName("ipd_consultation_ind");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(255)
                    .HasColumnName("job_title");

                entity.Property(e => e.JobTitleId)
                    .HasMaxLength(255)
                    .HasColumnName("job_title_id");

                entity.Property(e => e.JobTitleName)
                    .HasMaxLength(255)
                    .HasColumnName("job_title_name");

                entity.Property(e => e.JobType)
                    .HasMaxLength(255)
                    .HasColumnName("job_type");

                entity.Property(e => e.JobTypeId)
                    .HasMaxLength(255)
                    .HasColumnName("job_type_id");

                entity.Property(e => e.JobTypeName)
                    .HasMaxLength(255)
                    .HasColumnName("job_type_name");

                entity.Property(e => e.JobtitlePkNo).HasColumnName("jobtitle_pk_no");

                entity.Property(e => e.JoinDate).HasColumnName("join_date");

                entity.Property(e => e.Keycloakemployeeid)
                    .HasMaxLength(255)
                    .HasColumnName("keycloakemployeeid");

                entity.Property(e => e.Keycloakuserid)
                    .HasMaxLength(255)
                    .HasColumnName("keycloakuserid");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.MaritalId)
                    .HasMaxLength(255)
                    .HasColumnName("marital_id");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(255)
                    .HasColumnName("marital_status");

                entity.Property(e => e.MaritalStatusId)
                    .HasMaxLength(255)
                    .HasColumnName("marital_status_id");

                entity.Property(e => e.MaritalTxt)
                    .HasMaxLength(255)
                    .HasColumnName("marital_txt");

                entity.Property(e => e.Menuwithapidtojson)
                    .HasColumnType("oid")
                    .HasColumnName("menuwithapidtojson");

                entity.Property(e => e.MotherName)
                    .HasMaxLength(255)
                    .HasColumnName("mother_name");

                entity.Property(e => e.Nationality)
                    .HasMaxLength(255)
                    .HasColumnName("nationality");

                entity.Property(e => e.NurseInd).HasColumnName("nurse_ind");

                entity.Property(e => e.OffdayRemarks).HasColumnName("offday_remarks");

                entity.Property(e => e.OpdAppointmentPol).HasColumnName("opd_appointment_pol");

                entity.Property(e => e.OpdConfeecollPol).HasColumnName("opd_confeecoll_pol");

                entity.Property(e => e.OpdConsultationFee).HasColumnName("opd_consultation_fee");

                entity.Property(e => e.OpdConsultationFeeFl).HasColumnName("opd_consultation_fee_fl");

                entity.Property(e => e.OpdConsultationFeeRp).HasColumnName("opd_consultation_fee_rp");

                entity.Property(e => e.OpdConsultationFeeStaff).HasColumnName("opd_consultation_fee_staff");

                entity.Property(e => e.OpdConsultationInd).HasColumnName("opd_consultation_ind");

                entity.Property(e => e.OpdConsultationPeriod).HasColumnName("opd_consultation_period");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(255)
                    .HasColumnName("passport_no");

                entity.Property(e => e.PeAddr1)
                    .HasMaxLength(255)
                    .HasColumnName("pe_addr1");

                entity.Property(e => e.PeAddr2)
                    .HasMaxLength(255)
                    .HasColumnName("pe_addr2");

                entity.Property(e => e.PeAddr3)
                    .HasMaxLength(255)
                    .HasColumnName("pe_addr3");

                entity.Property(e => e.PeAddrCountry)
                    .HasMaxLength(255)
                    .HasColumnName("pe_addr_country");

                entity.Property(e => e.PeAddrDist)
                    .HasMaxLength(255)
                    .HasColumnName("pe_addr_dist");

                entity.Property(e => e.PeAddrPost)
                    .HasMaxLength(255)
                    .HasColumnName("pe_addr_post");

                entity.Property(e => e.PeCareOfAddr)
                    .HasMaxLength(255)
                    .HasColumnName("pe_care_of_addr");

                entity.Property(e => e.PermanentAddress11)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_address_1");

                entity.Property(e => e.PermanentAddress21)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_address_2");

                entity.Property(e => e.PermanentAddress31)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_address_3");

                entity.Property(e => e.PermanentCountry)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_country");

                entity.Property(e => e.PermanentCountryId)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_country_id");

                entity.Property(e => e.PermanentDistrict)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_district");

                entity.Property(e => e.PermanentDistrictId)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_district_id");

                entity.Property(e => e.PermanentDivision)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_division");

                entity.Property(e => e.PermanentDivisionId)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_division_id");

                entity.Property(e => e.PermanentPost)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_post");

                entity.Property(e => e.PermanentUpazila)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_upazila");

                entity.Property(e => e.PermanentUpazilaId)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_upazila_id");

                entity.Property(e => e.Permanentaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("permanentaddress1");

                entity.Property(e => e.Permanentaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("permanentaddress2");

                entity.Property(e => e.Permanentaddress3)
                    .HasMaxLength(255)
                    .HasColumnName("permanentaddress3");

                entity.Property(e => e.Permanentaddresscountry)
                    .HasMaxLength(255)
                    .HasColumnName("permanentaddresscountry");

                entity.Property(e => e.Permanentaddressdistrict)
                    .HasMaxLength(255)
                    .HasColumnName("permanentaddressdistrict");

                entity.Property(e => e.Permanentaddresspost)
                    .HasMaxLength(255)
                    .HasColumnName("permanentaddresspost");

                entity.Property(e => e.PhoneHome)
                    .HasMaxLength(255)
                    .HasColumnName("phone_home");

                entity.Property(e => e.PhoneMobile)
                    .HasMaxLength(255)
                    .HasColumnName("phone_mobile");

                entity.Property(e => e.PhoneOffice)
                    .HasMaxLength(255)
                    .HasColumnName("phone_office");

                entity.Property(e => e.PlaceOfBirth)
                    .HasMaxLength(255)
                    .HasColumnName("place_of_birth");

                entity.Property(e => e.PrAddr1)
                    .HasMaxLength(255)
                    .HasColumnName("pr_addr1");

                entity.Property(e => e.PrAddr2)
                    .HasMaxLength(255)
                    .HasColumnName("pr_addr2");

                entity.Property(e => e.PrAddr3)
                    .HasMaxLength(255)
                    .HasColumnName("pr_addr3");

                entity.Property(e => e.PrAddrCountry)
                    .HasMaxLength(255)
                    .HasColumnName("pr_addr_country");

                entity.Property(e => e.PrAddrDist)
                    .HasMaxLength(255)
                    .HasColumnName("pr_addr_dist");

                entity.Property(e => e.PrAddrPost)
                    .HasMaxLength(255)
                    .HasColumnName("pr_addr_post");

                entity.Property(e => e.PreCareOfAddr)
                    .HasMaxLength(255)
                    .HasColumnName("pre_care_of_addr");

                entity.Property(e => e.PreferedAddr)
                    .HasMaxLength(255)
                    .HasColumnName("prefered_addr");

                entity.Property(e => e.PresentAddress11)
                    .HasMaxLength(255)
                    .HasColumnName("present_address_1");

                entity.Property(e => e.PresentAddress21)
                    .HasMaxLength(255)
                    .HasColumnName("present_address_2");

                entity.Property(e => e.PresentAddress31)
                    .HasMaxLength(255)
                    .HasColumnName("present_address_3");

                entity.Property(e => e.PresentCofAddress)
                    .HasMaxLength(255)
                    .HasColumnName("present_cof_address");

                entity.Property(e => e.PresentCountry)
                    .HasMaxLength(255)
                    .HasColumnName("present_country");

                entity.Property(e => e.PresentCountryId)
                    .HasMaxLength(255)
                    .HasColumnName("present_country_id");

                entity.Property(e => e.PresentDistrict)
                    .HasMaxLength(255)
                    .HasColumnName("present_district");

                entity.Property(e => e.PresentDistrictId)
                    .HasMaxLength(255)
                    .HasColumnName("present_district_id");

                entity.Property(e => e.PresentDivision)
                    .HasMaxLength(255)
                    .HasColumnName("present_division");

                entity.Property(e => e.PresentDivisionId)
                    .HasMaxLength(255)
                    .HasColumnName("present_division_id");

                entity.Property(e => e.PresentPost)
                    .HasMaxLength(255)
                    .HasColumnName("present_post");

                entity.Property(e => e.PresentUpazila)
                    .HasMaxLength(255)
                    .HasColumnName("present_upazila");

                entity.Property(e => e.PresentUpazilaId)
                    .HasMaxLength(255)
                    .HasColumnName("present_upazila_id");

                entity.Property(e => e.Presentaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("presentaddress1");

                entity.Property(e => e.Presentaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("presentaddress2");

                entity.Property(e => e.Presentaddress3)
                    .HasMaxLength(255)
                    .HasColumnName("presentaddress3");

                entity.Property(e => e.Presentaddresscountry)
                    .HasMaxLength(255)
                    .HasColumnName("presentaddresscountry");

                entity.Property(e => e.Presentaddressdistrict)
                    .HasMaxLength(255)
                    .HasColumnName("presentaddressdistrict");

                entity.Property(e => e.Presentaddresspost)
                    .HasMaxLength(255)
                    .HasColumnName("presentaddresspost");

                entity.Property(e => e.Presentcareofaddress)
                    .HasMaxLength(255)
                    .HasColumnName("presentcareofaddress");

                entity.Property(e => e.PrimaryDoctorInd).HasColumnName("primary_doctor_ind");

                entity.Property(e => e.ProfileImageFileId)
                    .HasMaxLength(255)
                    .HasColumnName("profile_image_file_id");

                entity.Property(e => e.Qualification).HasColumnName("qualification");

                entity.Property(e => e.ReferalInd).HasColumnName("referal_ind");

                entity.Property(e => e.ReferralNotTeken)
                    .HasMaxLength(255)
                    .HasColumnName("referral_not_teken");

                entity.Property(e => e.Religion)
                    .HasMaxLength(255)
                    .HasColumnName("religion");

                entity.Property(e => e.ReligionId)
                    .HasMaxLength(255)
                    .HasColumnName("religion_id");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(255)
                    .HasColumnName("remarks");

                entity.Property(e => e.RepType)
                    .HasMaxLength(255)
                    .HasColumnName("rep_type");

                entity.Property(e => e.ReportingInd).HasColumnName("reporting_ind");

                entity.Property(e => e.ReportingTo)
                    .HasMaxLength(255)
                    .HasColumnName("reporting_to");

                entity.Property(e => e.RoomNo).HasColumnName("room_no");

                entity.Property(e => e.Salutation)
                    .HasMaxLength(255)
                    .HasColumnName("salutation");

                entity.Property(e => e.SampleCollInd).HasColumnName("sample_coll_ind");

                entity.Property(e => e.SignatureFileId)
                    .HasMaxLength(255)
                    .HasColumnName("signature_file_id");

                entity.Property(e => e.SpecializationPkNo).HasColumnName("specialization_pk_no");

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(255)
                    .HasColumnName("spouse_name");

                entity.Property(e => e.SsNo)
                    .HasMaxLength(255)
                    .HasColumnName("ss_no");

                entity.Property(e => e.SurgeonInd).HasColumnName("surgeon_ind");

                entity.Property(e => e.TinNo)
                    .HasMaxLength(255)
                    .HasColumnName("tin_no");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");

                entity.Property(e => e.WsInd).HasColumnName("ws_ind");
            });

            modelBuilder.Entity<RegEmployeeDepartment>(entity =>
            {
                entity.ToTable("reg_employee_department");

                entity.HasIndex(e => new { e.EmployeeId, e.DepartmentId }, "uk_reg_employee_department_employee_id_department_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(255)
                    .HasColumnName("department_id");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .HasColumnName("employee_id");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.RegEmployeeDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("fk_reg_employee_department_department_id");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.RegEmployeeDepartments)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("fk_reg_employee_department_employee_id");
            });

            modelBuilder.Entity<RegEmployeeRoom>(entity =>
            {
                entity.ToTable("reg_employee_room");

                entity.HasIndex(e => new { e.EmployeeId, e.RoomId }, "uk_reg_employee_room_employee_id_room_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .HasColumnName("employee_id");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.RoomId)
                    .HasMaxLength(255)
                    .HasColumnName("room_id");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.RegEmployeeRooms)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("fk_reg_employee_room_employee_id");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.RegEmployeeRooms)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("fk_reg_employee_room_room_id");
            });

            modelBuilder.Entity<RegLookupDetail>(entity =>
            {
                entity.ToTable("reg_lookup_detail");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.LookupDetailEnumKey)
                    .HasMaxLength(255)
                    .HasColumnName("lookup_detail_enum_key");

                entity.Property(e => e.LookupDetailEnumValue)
                    .HasMaxLength(255)
                    .HasColumnName("lookup_detail_enum_value");

                entity.Property(e => e.LookupDetailStatusKey)
                    .HasMaxLength(255)
                    .HasColumnName("lookup_detail_status_key");

                entity.Property(e => e.LookupDetailStatusValue)
                    .HasMaxLength(255)
                    .HasColumnName("lookup_detail_status_value");

                entity.Property(e => e.LookupEnumKey)
                    .HasMaxLength(255)
                    .HasColumnName("lookup_enum_key");

                entity.Property(e => e.LookupEnumValue)
                    .HasMaxLength(255)
                    .HasColumnName("lookup_enum_value");

                entity.Property(e => e.LookupStatusKey)
                    .HasMaxLength(255)
                    .HasColumnName("lookup_status_key");

                entity.Property(e => e.LookupStatusValue)
                    .HasMaxLength(255)
                    .HasColumnName("lookup_status_value");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(255)
                    .HasColumnName("parent_id");

                entity.Property(e => e.SerialNo).HasColumnName("serial_no");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fk_reg_lookup_detail_parent_id");
            });

            modelBuilder.Entity<RegLookupDetailRelation>(entity =>
            {
                entity.ToTable("reg_lookup_detail_relation");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.LookupDetailIdMany1)
                    .HasMaxLength(255)
                    .HasColumnName("lookup_detail_id_many");

                entity.Property(e => e.LookupDetailIdOne1)
                    .HasMaxLength(255)
                    .HasColumnName("lookup_detail_id_one");

                entity.Property(e => e.Lookupdetailidmany)
                    .HasMaxLength(255)
                    .HasColumnName("lookupdetailidmany");

                entity.Property(e => e.Lookupdetailidone)
                    .HasMaxLength(255)
                    .HasColumnName("lookupdetailidone");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");

                entity.HasOne(d => d.LookupDetailIdMany1Navigation)
                    .WithMany(p => p.RegLookupDetailRelationLookupDetailIdMany1Navigations)
                    .HasForeignKey(d => d.LookupDetailIdMany1)
                    .HasConstraintName("fk_reg_lookup_detail_relation_lookup_detail_id_many");

                entity.HasOne(d => d.LookupDetailIdOne1Navigation)
                    .WithMany(p => p.RegLookupDetailRelationLookupDetailIdOne1Navigations)
                    .HasForeignKey(d => d.LookupDetailIdOne1)
                    .HasConstraintName("fk_reg_lookup_detail_relation_lookup_detail_id_one");
            });

            modelBuilder.Entity<RegPatientAccount>(entity =>
            {
                entity.ToTable("reg_patient_account");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(255)
                    .HasColumnName("mobile");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");
            });

            modelBuilder.Entity<RegPatientRegDoc>(entity =>
            {
                entity.ToTable("reg_patient_reg_doc");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.FileId)
                    .HasMaxLength(255)
                    .HasColumnName("file_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.PatientRegInfoId)
                    .HasMaxLength(255)
                    .HasColumnName("patient_reg_info_id");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");

                entity.HasOne(d => d.PatientRegInfo)
                    .WithMany(p => p.RegPatientRegDocs)
                    .HasForeignKey(d => d.PatientRegInfoId)
                    .HasConstraintName("fks5ldsykaw0q5ubeu0js6xubfr");
            });

            modelBuilder.Entity<RegPatientRegInfo>(entity =>
            {
                entity.ToTable("reg_patient_reg_info");

                entity.HasIndex(e => e.PatientRegId, "uk_reg_patient_reg_info_patient_reg_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.AgeInDay).HasColumnName("age_in_day");

                entity.Property(e => e.AgeInMonth).HasColumnName("age_in_month");

                entity.Property(e => e.AgeInYear).HasColumnName("age_in_year");

                entity.Property(e => e.BirthCertificateNo)
                    .HasMaxLength(255)
                    .HasColumnName("birth_certificate_no");

                entity.Property(e => e.BloodGroupId)
                    .HasMaxLength(255)
                    .HasColumnName("blood_group_id");

                entity.Property(e => e.BloodGroupName)
                    .HasMaxLength(255)
                    .HasColumnName("blood_group_name");

                entity.Property(e => e.CoName)
                    .HasMaxLength(255)
                    .HasColumnName("co_name");

                entity.Property(e => e.CoPhoneNumber)
                    .HasMaxLength(255)
                    .HasColumnName("co_phone_number");

                entity.Property(e => e.CoRelationship)
                    .HasMaxLength(255)
                    .HasColumnName("co_relationship");

                entity.Property(e => e.CoRelationshipEnumKey)
                    .HasMaxLength(255)
                    .HasColumnName("co_relationship_enum_key");

                entity.Property(e => e.CoRelationshipEnumValue)
                    .HasMaxLength(255)
                    .HasColumnName("co_relationship_enum_value");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.EmergencyContractAddress)
                    .HasMaxLength(255)
                    .HasColumnName("emergency_contract_address");

                entity.Property(e => e.EmergencyContractName)
                    .HasMaxLength(255)
                    .HasColumnName("emergency_contract_name");

                entity.Property(e => e.EmergencyContractPhone)
                    .HasMaxLength(255)
                    .HasColumnName("emergency_contract_phone");

                entity.Property(e => e.EmergencyContractRelationship)
                    .HasMaxLength(255)
                    .HasColumnName("emergency_contract_relationship");

                entity.Property(e => e.EmergencyContractRelationshipEnumKey)
                    .HasMaxLength(255)
                    .HasColumnName("emergency_contract_relationship_enum_key");

                entity.Property(e => e.EmergencyContractRelationshipEnumValue)
                    .HasMaxLength(255)
                    .HasColumnName("emergency_contract_relationship_enum_value");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(255)
                    .HasColumnName("gender_id");

                entity.Property(e => e.GenderName)
                    .HasMaxLength(255)
                    .HasColumnName("gender_name");

                entity.Property(e => e.GovtIdType)
                    .HasMaxLength(120)
                    .HasColumnName("govt_id_type");

                entity.Property(e => e.IdentityMark)
                    .HasMaxLength(255)
                    .HasColumnName("identity_mark");

                entity.Property(e => e.MaritalStatusId)
                    .HasMaxLength(255)
                    .HasColumnName("marital_status_id");

                entity.Property(e => e.MaritalStatusName)
                    .HasMaxLength(255)
                    .HasColumnName("marital_status_name");

                entity.Property(e => e.NationalId)
                    .HasMaxLength(255)
                    .HasColumnName("national_id");

                entity.Property(e => e.NationalityId)
                    .HasMaxLength(255)
                    .HasColumnName("nationality_id");

                entity.Property(e => e.NationalityName)
                    .HasMaxLength(255)
                    .HasColumnName("nationality_name");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(255)
                    .HasColumnName("occupation");

                entity.Property(e => e.OccupationId)
                    .HasMaxLength(255)
                    .HasColumnName("occupation_id");

                entity.Property(e => e.OccupationName)
                    .HasMaxLength(255)
                    .HasColumnName("occupation_name");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(255)
                    .HasColumnName("passport_no");

                entity.Property(e => e.PatientAccountId)
                    .HasMaxLength(255)
                    .HasColumnName("patient_account_id");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(255)
                    .HasColumnName("patient_id");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(255)
                    .HasColumnName("patient_name");

                entity.Property(e => e.PatientRegId)
                    .HasMaxLength(255)
                    .HasColumnName("patient_reg_id");

                entity.Property(e => e.PatientRelationTypeEnumKey)
                    .HasMaxLength(255)
                    .HasColumnName("patient_relation_type_enum_key");

                entity.Property(e => e.PatientRelationTypeEnumValue)
                    .HasMaxLength(255)
                    .HasColumnName("patient_relation_type_enum_value");

                entity.Property(e => e.PatientTypeEnumKey)
                    .HasMaxLength(255)
                    .HasColumnName("patient_type_enum_key");

                entity.Property(e => e.PatientTypeEnumValue)
                    .HasMaxLength(255)
                    .HasColumnName("patient_type_enum_value");

                entity.Property(e => e.PermanentAddr)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_addr");

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_address");

                entity.Property(e => e.PermanentDistrict)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_district");

                entity.Property(e => e.PermanentDistrictId)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_district_id");

                entity.Property(e => e.PermanentDistrictLookupListPkNo).HasColumnName("permanent_district_lookup_list_pk_no");

                entity.Property(e => e.PermanentDivision)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_division");

                entity.Property(e => e.PermanentDivisionId)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_division_id");

                entity.Property(e => e.PermanentDivisionLookupListPkNo).HasColumnName("permanent_division_lookup_list_pk_no");

                entity.Property(e => e.PermanentThana)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_thana");

                entity.Property(e => e.PermanentThanaId)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_thana_id");

                entity.Property(e => e.PermanentUpazila)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_upazila");

                entity.Property(e => e.PermanentUpazilaId)
                    .HasMaxLength(255)
                    .HasColumnName("permanent_upazila_id");

                entity.Property(e => e.PermanentUpazilaLookupListPkNo).HasColumnName("permanent_upazila_lookup_list_pk_no");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .HasColumnName("phone_number");

                entity.Property(e => e.PresentAddr)
                    .HasMaxLength(255)
                    .HasColumnName("present_addr");

                entity.Property(e => e.PresentAddress)
                    .HasMaxLength(255)
                    .HasColumnName("present_address");

                entity.Property(e => e.PresentDistrict)
                    .HasMaxLength(255)
                    .HasColumnName("present_district");

                entity.Property(e => e.PresentDistrictId)
                    .HasMaxLength(255)
                    .HasColumnName("present_district_id");

                entity.Property(e => e.PresentDistrictLookupListPkNo).HasColumnName("present_district_lookup_list_pk_no");

                entity.Property(e => e.PresentDivision)
                    .HasMaxLength(255)
                    .HasColumnName("present_division");

                entity.Property(e => e.PresentDivisionId)
                    .HasMaxLength(255)
                    .HasColumnName("present_division_id");

                entity.Property(e => e.PresentDivisionLookupListPkNo).HasColumnName("present_division_lookup_list_pk_no");

                entity.Property(e => e.PresentThana)
                    .HasMaxLength(255)
                    .HasColumnName("present_thana");

                entity.Property(e => e.PresentThanaId)
                    .HasMaxLength(255)
                    .HasColumnName("present_thana_id");

                entity.Property(e => e.PresentUpazila)
                    .HasMaxLength(255)
                    .HasColumnName("present_upazila");

                entity.Property(e => e.PresentUpazilaId)
                    .HasMaxLength(255)
                    .HasColumnName("present_upazila_id");

                entity.Property(e => e.PresentUpazilaLookupListPkNo).HasColumnName("present_upazila_lookup_list_pk_no");

                entity.Property(e => e.PrivilegedPatientApproved).HasColumnName("privileged_patient_approved");

                entity.Property(e => e.ProfileImageFileId)
                    .HasMaxLength(255)
                    .HasColumnName("profile_image_file_id");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("registration_date");

                entity.Property(e => e.RegistrationTypeEnumKey)
                    .HasMaxLength(255)
                    .HasColumnName("registration_type_enum_key");

                entity.Property(e => e.RegistrationTypeEnumValue)
                    .HasMaxLength(255)
                    .HasColumnName("registration_type_enum_value");

                entity.Property(e => e.ReligionId)
                    .HasMaxLength(255)
                    .HasColumnName("religion_id");

                entity.Property(e => e.ReligionName)
                    .HasMaxLength(255)
                    .HasColumnName("religion_name");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");

                entity.HasOne(d => d.PatientAccount)
                    .WithMany(p => p.RegPatientRegInfoPatientAccounts)
                    .HasForeignKey(d => d.PatientAccountId)
                    .HasConstraintName("fk_reg_patient_reg_info_patient_account_id");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.RegPatientRegInfoPatients)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("fkj24vnnowr0uuh0wuxg16fs2mb");
            });

            modelBuilder.Entity<RegPriceSetup>(entity =>
            {
                entity.ToTable("reg_price_setup");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Ticketprice).HasColumnName("ticketprice");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");
            });

            modelBuilder.Entity<RegRoom>(entity =>
            {
                entity.ToTable("reg_room");

                entity.HasIndex(e => e.Name, "uk_reg_room_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.BuildingId)
                    .HasMaxLength(255)
                    .HasColumnName("building_id");

                entity.Property(e => e.BuildingName)
                    .HasMaxLength(255)
                    .HasColumnName("building_name");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.FloorId)
                    .HasMaxLength(255)
                    .HasColumnName("floor_id");

                entity.Property(e => e.FloorName)
                    .HasMaxLength(255)
                    .HasColumnName("floor_name");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Size)
                    .HasMaxLength(255)
                    .HasColumnName("size");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");
            });

            modelBuilder.Entity<RegUserInfo>(entity =>
            {
                entity.ToTable("reg_user_info");

                entity.HasIndex(e => e.Username, "uk_reg_user_info_username")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("created_by");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .HasColumnName("employee_id");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Keycloakuserid)
                    .HasMaxLength(255)
                    .HasColumnName("keycloakuserid");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(255)
                    .HasColumnName("mobile_number");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("update_at");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("update_by");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
