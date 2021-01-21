using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblNDSISRegion",Schema ="dbo")]
    public class ztblNDSISRegion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int RegionNumber { get; set; }
        public string RegionName { get; set; }
    }
}
