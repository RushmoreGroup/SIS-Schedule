using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("tbl_TmpWork",Schema ="dbo")]
    public class tbl_TmpWork
    {
        public int id { get; set; }
        public int counter { get; set; }
    }
}
