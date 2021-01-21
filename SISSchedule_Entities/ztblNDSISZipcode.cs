using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblNDSISZipcode",Schema ="dbo")]
   public class ztblNDSISZipcode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public Double  Zip { get; set; }
	  public String City { get; set; }
    }
}
