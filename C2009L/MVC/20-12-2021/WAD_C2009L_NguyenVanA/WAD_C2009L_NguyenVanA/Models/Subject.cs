using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WAD_C2009L_NguyenVanA.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public String SubjectName { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        //constructor
        public Subject()
        {
            this.Exams = new List<Exam>();
        }
    }
}