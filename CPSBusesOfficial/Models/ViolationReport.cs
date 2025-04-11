using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CPSBusesOfficial.Models
{
    public class ViolationReport
    {
        public string VR_ID { get; set; }
        public string U_ID { get; set; }
        public string PlateNumber { get; set; }
        public string VR_Date { get; set; }
        public Violation UserViolation{  get; set; }
        [NotNull]
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
