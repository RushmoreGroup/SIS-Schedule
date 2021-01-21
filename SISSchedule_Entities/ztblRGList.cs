using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblRGList",Schema ="dbo")]
    public class ztblRGList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ListID { get; set; }
    public string ListName { get; set; }
    public string ListValue { get; set; }
    public int EditType { get; set; }
	public DateTime EndDate { get; set; }
    }
}
