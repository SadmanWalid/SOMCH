using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SOMCH.Models
{
    public class MetaClasses
    {
    }
    public class RegPatientRegInfoMetaClass
    {
        
       
    }


   [ModelMetadataType(typeof(RegPatientRegInfoMetaClass))]
    public partial class RegPatientRegInfo
    {

        public string Gender { get; set; }

    }
}
