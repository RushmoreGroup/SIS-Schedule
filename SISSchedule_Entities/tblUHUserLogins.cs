﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("tblUHUserLogins",Schema ="dbo")]
    public class tblUHUserLogins
    {
        [Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int logRecordID { get; set; }
		public string logUserLogin { get; set; }
		public string logPassword { get; set; }  
		public string logFirstName { get; set; }
		public string logLastName { get; set; }
		public string logMiddleName { get; set; }
		public int logActive { get; set; }
		public DateTime logEndDate { get; set; }
		public int logAliasID { get; set; }
	}
}
