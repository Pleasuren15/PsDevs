using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace PsDevs.Models
{
    public class ManagementViewModel
    {
        public IEnumerable<IdentityUser> _identityUsers { get; set; }
        public IEnumerable<Career> _careers { get; set; }
    }
}
