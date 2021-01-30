using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace PMSystem.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(3)]
        [Required]
        [Key]
        public string AreaCd { set; get; }

        [MaxLength(10)]
        [Required]
        [Key]
        public string UserCd { set; get; }

        [MaxLength(20)]
        public string Name { set; get; }

        [MaxLength(3)]
        public string Grp { set; get; }

        [MaxLength(20)]
        public Byte Logon { set; get; }

        [MaxLength(20)]
        public string LogonTime { set; get; }

        [MaxLength(15)]
        public string HtId { set; get; }
    }
}
