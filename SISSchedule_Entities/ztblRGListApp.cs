using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblRGListApp",Schema ="dbo")]
   public class ztblRGListApp
    {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AppListID { get; set; }
    public int AppID { get; set; }
    public int CustomerID { get; set; }
    public DateTime EndDate { get; set; }

    } 
}
