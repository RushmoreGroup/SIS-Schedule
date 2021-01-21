using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SISSchedule_Entities
{
    [Table("ztblRGAppSetting" , Schema ="dbo")]
  public class ztblRGAppSetting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    public int AppID { get; set; }
    public string SettingName { get; set; }
    public string SettingValue { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
       
    }
}
