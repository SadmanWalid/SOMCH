using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SOMCH.Models
{
    [ModelMetadataType(typeof(RegUserInfoMetadata))]
    public partial class RegUserInfo
    {

    }

    public class RegUserInfoMetadata
    {
        [Display(Name = "Username")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Username")]
        [Phone]
        public string? MobileNumber { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
