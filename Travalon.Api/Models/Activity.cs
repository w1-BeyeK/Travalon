using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travalon.Api.Models
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public string ActivityName { get; set; }
        public DateTime? ActivityDate { get; set; }
        public long Lat { get; set; }
        public long Lon { get; set; }
        public List<Student> Participants { get; set; }
    }
}
