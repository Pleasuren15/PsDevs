using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsDevs.Models
{
    public class TeamMember
    {
        [BindNever]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamMemberId { get; set; }

        [Required]
        public string TeamMemberName { get; set; }

        [Required]
        public string TeamMemberPosition { get; set; }

        [Required]
        public string TeamMemberImageUrl { get; set; }
    }
}
