using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SISSchedule_Entities
{
    [Table("ztblNDSISScheduleChange",Schema ="dbo")]
   public class ztblNDSISScheduleChange
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int RecordID { get; set; }
	public string Client { get; set; }
	public string AssessorName { get; set; }
	public DateTime AssessmentDate { get; set; }
	public DateTime AssessmentTime { get; set; }
	public string AssessmentLocation { get; set; }
	public string AssessmentAddress { get; set; }
	public string AssessmentCity { get; set; }
	public DateTime ChangedOn { get; set; }
		

	}
}
