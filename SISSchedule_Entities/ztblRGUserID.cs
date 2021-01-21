using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISSchedule_Entities
{
    [Table("ztblRGUserID",Schema ="dbo")]
    public class ztblRGUserID
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int ID { get; set; }
	public string UserID { get; set; }
	public string Password { get; set; }
	public string LastName { get; set; }
	public string FirstName { get; set; }
	public int UserType { get; set; }
	public string UserEmail { get; set; }
	public string UserPhone { get; set; }
	public string UserCell { get; set; }
	public string UserLocation { get; set; }
	public string UserToken { get; set; }
	public DateTime UserLastSignOn { get; set; }
	public DateTime UserLastActivity { get; set; }
	public string UserAddress1 { get; set; }
	public string UserAddress2 { get; set; }
	public string UserCity { get; set; }
	public string UserState { get; set; }
	public string UserZipCode { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public string LogonGUID { get; set; }
	public DateTime LogonGUIDExpire { get; set; }
	public string UserName { get; set; }
    }
}
