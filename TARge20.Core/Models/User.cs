using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TARge20.Core.Models
{
    [Keyless]
    public partial class User
    {
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("username")]
        public string Username { get; set; }
        [Required]
        [Column("email")]
        public string Email { get; set; }
        [Column("phone_number")]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [Column("creation_date", TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
    }
}
