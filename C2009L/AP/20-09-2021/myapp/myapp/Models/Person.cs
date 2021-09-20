using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp.Models
{
    //public struct Person
    public class Person
    {        
        //string? = optional string = "string that can be null"

        public string? Name {  get; set; }
        public string? Nationality {  get; set; }
        public int BirthYear { get; set; }
        public float NetWorth { get; set; }

    }
}
