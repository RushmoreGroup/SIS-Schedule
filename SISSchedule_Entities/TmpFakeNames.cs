using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("tbl_TmpFakeNames", Schema ="dbo")]
   public class TmpFakeNames
    {
    public string FakeName { get; set; }
	public string MedicaidID { get; set; }
    }
}
