using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travalon.Api.Models
{
    /* DateTime? for nullable datetimes */
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public ICollection<Student> Friends { get; set; }
        //public ICollection<Activity> Activities { get; set; }
    }
}
