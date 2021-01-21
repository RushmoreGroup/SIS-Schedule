using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
	[Table("ztblNDSISProvider", Schema = "dbo")]
	public class Providers
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RecordID { get; set; }
		public string Provider { get; set; }
		public string Director { get; set; }
		public string DirectorEmail { get; set; }
		public string DirectorPhone { get; set; }
		public string DirectorFax { get; set; }
		public string DirectorAddress { get; set; }
		public string DirectorCity { get; set; }
		public string DirectorZip { get; set; }
		public string Website { get; set; }
		public string Notes { get; set; }
	}
}
