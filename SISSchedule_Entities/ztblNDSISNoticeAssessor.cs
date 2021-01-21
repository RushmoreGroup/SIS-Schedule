using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblNDSISNoticeAssessor",Schema ="dbo")]
    public class ztblNDSISNoticeAssessor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public string Assessor { get; set; } 
       public string Email { get; set; }
       public string CellPhone { get; set; }
	   public string AlternateEmail { get; set; }
	   public DateTime EndUse { get; set; }

    }
}
