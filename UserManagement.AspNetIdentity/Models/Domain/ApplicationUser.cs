using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.AspNetIdentity.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
    }
}
