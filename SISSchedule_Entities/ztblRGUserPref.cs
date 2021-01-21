using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblRGUserPref",Schema ="dbo")]
   public class ztblRGUserPref
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string PrefUserID { get; set; }
    public int PrefAppID { get; set; }
    public string PrefName { get; set; }
    public string PrefValue { get; set; }
    }
}
