using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblRGUserApp",Schema ="dbo")]
   public class ztblRGUserApp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public string AppUserID { get; set; }
       public int AppID { get; set; }
    }
}
