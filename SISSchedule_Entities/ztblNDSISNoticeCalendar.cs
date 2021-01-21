using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblNDSISNoticeCalendar", Schema ="dbo")]
    public class ztblNDSISNoticeCalendar
    {
	public int CalYear { get; set; }
	public int CalMonth { get; set; }
	public int CalWeek { get; set; }
	public int Sunday { get; set; }
	public int Monday { get; set; }
	public int 	Tuesday { get; set; }
	public int Wednesday { get; set; }
	public int Thursday { get; set; }
	public int Friday { get; set; }
	public int Saturday { get; set; }
	}
}
