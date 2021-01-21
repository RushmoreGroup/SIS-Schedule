using System;

namespace SISSchedule_DTO
{
    /// <summary>
    /// DTO of provider class
    /// </summary>
    public class ProviderDTO
    {
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
