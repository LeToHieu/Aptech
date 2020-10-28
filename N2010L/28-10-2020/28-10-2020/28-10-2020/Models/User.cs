using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _28_10_2020.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public int YearOfBirth { get; set; }
        public string TokenKey { get; set; }
    }
}
