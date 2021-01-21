using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblNDSISNoticeU4",Schema ="dbo")]
    public class ztblNDSISNoticeU4
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RecordID { get; set; }
        public int Region { get; set; }
	public string Client { get; set; }
	public string MedicaidID { get; set; }
	public DateTime ClientDOB { get; set; }
	public int ClientAge { get; set; }
	public string Diagnosis { get; set; }
	public string Service { get; set; }
	public string Race { get; set; }
	public string TherapID { get; set; }
	public char IsMobile { get; set; }
	public char IsVerbal { get; set; }
	public char IsEnglish { get; set; }
	public char IsDeaf { get; set; }
	public string Provider { get; set; }
	public string Director { get; set; }
	public string DirectorEmail { get; set; }
	public string DirectorPhone { get; set; }
	public string DirectorFax { get; set; }
	public string DirectorAddress { get; set; }
	public string DirectorCity { get; set; }
	public string DirectorZip { get; set; }
	public string Website { get; set; }
	public string PrgAdminName { get; set; }
	public string PrgAdminEmail { get; set; }
	public string PrgAdminContact { get; set; }
	public string PrgManagerName { get; set; }
	public string PrgManagerEmail { get; set; }
	public string PrgManagerContact { get; set; }
	public string PrgCoordName { get; set; }
	public string PrgCoordEmail { get; set; }
	public string PrgCoordContact { get; set; }
	public string Notes { get; set; }
	public string AssessorName { get; set; }
	public DateTime AssessmentDate { get; set; }
	public DateTime AssessmentTime { get; set; }
	public string AssessmentLocation { get; set; }
	public string AssessmentAddress { get; set; }
	public string AssessmentCity { get; set; }
	public string AssessmentNotes { get; set; }
	public string ProviderGUID { get; set; }
	public string ProviderPassword { get; set; }
	public DateTime DateEmail1 { get; set; }
	public DateTime DateEmail2 { get; set; }
	public DateTime DateAccessed { get; set; }
	public string StateGUID { get; set; }
	public string StatePassword { get; set; }
	public char PrgAdminNotify { get; set; }
	public DateTime PrgAdminDateNotify { get; set; }
	public DateTime PrgAdminDateView { get; set; }
	public char PrgManagerNotify { get; set; }
	public DateTime PrgManagerDateNotify { get; set; }
	public DateTime PrgManagerDateView { get; set; }
	public char PrgCoordNotify { get; set; }
	public DateTime PrgCoordDateNotify { get; set; }
	public DateTime PrgCoordDateView { get; set; }
	public char Letter1 { get; set; }
	public char Letter2 { get; set; }
	public char Letter3 { get; set; }
	public char Scheduled { get; set; }
	public char Pilot { get; set; }
	public string ClientStatus { get; set; }
	public char Completed { get; set; }
	public string FundSource { get; set; }
	public string SampleName { get; set; }
    }
}
