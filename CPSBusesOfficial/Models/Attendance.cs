using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CPSBusesOfficial.Models
{
    internal class Attendance
    {
        public string U_ID { get; set; }
        public string TimeOfEnter { get; set; }
        public string TimeOfLeave { get; set; }
        public string EntryLocation { get; set; }
        public string LeavingLocation { get; set; }
        public float TimeDuration { get; set; }
        [NotNull]
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
