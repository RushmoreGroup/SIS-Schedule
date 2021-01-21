using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblNDSISQueryList",Schema ="dbo")]
    public class ztblNDSISQueryList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public string QueryName { get; set; }
 
     public string QueryProc { get; set; }
  
     public string Description { get; set; }
    }
}
