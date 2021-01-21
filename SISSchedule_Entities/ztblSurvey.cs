using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblSurvey",Schema ="dbo")]
   public class ztblSurvey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int RecordID { get; set; }
	public DateTime SurveyDate { get; set; }
	public string Assessor { get; set; }
    public DateTime AssessmentDate { get; set; }
    public string AssessmentTime { get; set; }
    public int A1 { get; set; }
    public int A2 { get; set; }  
	public int A3 { get; set; }
    public int A4 { get; set; }
    public int A5 { get; set; }
    public int A6 { get; set; }
    public int A7 { get; set; }
    public string CompletedBy { get; set; }  
	public int Role { get; set; }
    public int Score { get; set; }
    public string OtherRole { get; set; }
	public string Comments { get; set; }
	public string SurveyType { get; set; }
    }
}
