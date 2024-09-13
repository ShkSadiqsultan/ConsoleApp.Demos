using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobportal
{
    [Table("Applicant_Educations")]
    public class Applicant_Education
    {
      
        public Applicant_Education() { }

        [Column("Applicant")]
        public string Applicant { get; set; }
        [Column("Major")]
        public string Major { get; set; }

        [Column("Certificate_Diploma")]
        public string Certificate_Diploma { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime Completion_Date { get; set; }

        public int Completion_Percent { get;set; }

        public DateTime Time_Stamp { get; set; }



    }
}
