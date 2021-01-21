using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblNDSISBookHotel",Schema ="dbo")]
    public class ztblNDSISBookHotel
    {
	public int RecID { get; set; }
	public DateTime CheckIn { get; set; }
	public DateTime CheckOut { get; set; }
	public string AssessorName { get; set; }
	public string Hotel { get; set; }
	public string City { get; set; }
	public string HotelPhone { get; set; }
	public string ConfirmationCode { get; set; }
	}
}
