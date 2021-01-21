using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SISSchedule_Entities
{
    [Table("ztblRGAppConfig",Schema ="dbo")]
   public class ztblRGAppConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public string ConfigName { get; set; }
	public int ConfigAppID { get; set; }
	public string ConfigValue { get; set; }
	public string ConfigValueType { get; set; }
	public int ConfigValueLength { get; set; }
	public string ConfigValueList { get; set; }
	public string ConfigCategory { get; set; }
	public bool LoadGlobal { get; set; }
	public string DisplayCaption { get; set; }
	public string DisplayDescription { get; set; }

    }
}
