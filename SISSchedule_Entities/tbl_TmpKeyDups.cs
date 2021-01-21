using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("tbl_TmpKeyDups", Schema = "dbo")]
    public class tbl_TmpKeyDups
    {
        public string FakeName { get; set; }
        public int MedicaidID { get; set; }
    }
}
