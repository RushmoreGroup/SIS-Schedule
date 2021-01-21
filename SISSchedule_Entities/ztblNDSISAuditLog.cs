using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    

namespace SISSchedule_Entities
{
    [Table("ztblNDSISAuditLog",Schema ="dbo")]
    public class ztblNDSISAuditLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordID { get; set; }
        public DateTime EventDate { get; set; }
        public string Event { get; set; }
        public string EventData { get; set; }
	    public string EventSource { get; set; }
	    public string EventID { get; set; }
        public string UserID { get; set; }
    }
}
