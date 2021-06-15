﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PsDevs.Models
{
    public class Career
    {
        [BindNever]
        [Required]
        [DisplayName("Id")]
        public int CareerId { get; set; }
        [Required]
        [DisplayName("Name")]
        public string CareerName { get; set; }
        [Required]
        [DisplayName("Description")]
        public string CareerDescription { get; set; }
        [Required]
        [DisplayName("Years Experience")]
        public string CareerYearsExperience { get; set; }
        [Required]
        [DisplayName("Type")]
        public CareerType CareerType { get; set; }
    }

    public enum CareerType
    {
        Temporary, Permanent
    }
}