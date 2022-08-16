using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAP_Cxxx_NguyenVanA.Models
{
    public class Customer
    {        
        public int CustomerId { get; set; }
        [Required]
        [StringLength(32, MinimumLength =3)]
        public string FullName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }

    }
}