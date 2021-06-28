using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsDevs.Models
{
    public class CareerApplication
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ApplicatioId { get; set; }

        [Required]
        [DisplayName("Career")]
        public string ApplicationCareer { get; set; }

        [Required]
        [DisplayName("First Names")]
        public string ApplicationFirstNames { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string ApplicationLastName { get; set; }


        [Required]
        [DisplayName("ID Number")]
        public string ApplicationIDNumber { get; set; }

        [Required]
        [DisplayName("Date Of Birth")]
        public DateTime ApplicationDateOfBirth { get; set; } = DateTime.Now;

        [Required]
        [DisplayName("Gender")]
        public string ApplicationGender { get; set; }

        [Required]
        [DisplayName("Race")]
        public string ApplicationRace { get; set; }

        [Required]
        [DisplayName("Email")]
        public string ApplicationEmail { get; set; }

        [Required]
        [DisplayName("Phone Number 1")]
        public string ApplicationPhoneNumber1 { get; set; }

        [Required]
        [DisplayName("Phone Number 2")]
        public string ApplicationPhoneNumber2 { get; set; }

        [Required]
        [DisplayName("ID Copy")]
        public string ApplicationIDCopy { get; set; }

        [Required]
        [DisplayName("CV Copy")]
        public string ApplicationCVCopy { get; set; }

        [Required]
        [DisplayName("Academic Transcipts")]
        public string ApplicationAcademicTransciptsCopy { get; set; }

        [Required]
        [DisplayName("Additional Comments")]
        [MaxLength(50)]
        public string ApplicationAdditionalComments { get; set; }

        private string GenerateId()
        {
            string sDateTime = DateTime.Now.ToString();

            while (sDateTime.IndexOf($"\\") > 0)
            {
                sDateTime = sDateTime.Remove(sDateTime.IndexOf($"\\"));
            }

            return sDateTime;
        }
    }
}
