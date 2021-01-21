using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SISSchedule_Entities
{
    [Table("ztblRGUserAppList",Schema ="dbo")]
   public class ztblRGUserAppList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    public string UserID { get; set; }
    public int ListID { get; set; }
    public int AppID { get; set; }
    }
}
