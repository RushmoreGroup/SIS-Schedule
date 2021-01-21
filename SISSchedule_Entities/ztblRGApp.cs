using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SISSchedule_Entities
{
    [Table("ztblRGApp",Schema ="dbo")]
   public class ztblRGApp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationID { get; set; }
    public string ApplicationName { get; set; }
    public string ApplicationDisplayTitle { get; set; }
	public string ButtonText { get; set; }
	public int SortOrder { get; set; }
    }
}
