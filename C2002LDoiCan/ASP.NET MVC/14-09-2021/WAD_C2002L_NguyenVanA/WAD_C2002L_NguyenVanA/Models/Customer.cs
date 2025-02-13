//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WAD_C2002L_NguyenVanA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Customer
    {
        [Required]
        public int CustomerId { get; set; }
        
        [Required]
        [StringLength(32, MinimumLength = 3, ErrorMessage = "Length must be 3 to 32")]
        public string Fullname { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public System.DateTime Birthday { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 8, ErrorMessage ="Length must be 8 to 20")]
        [RegularExpression(@"^[A-Za-z0-9][A-Za-z0-9]*[A-Za-z0-9]$", 
            ErrorMessage = "Invalid username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Invalid password")]
        public string Password { get; set; }
                
        [Required(ErrorMessage = "Confirm Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Invalid password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password must match")]
        public string ConfirmPassword { get; set; }

        [Required]
        public int ClassId { get; set; }
    
        public virtual Class Class { get; set; }
    }
}
