using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CwcBackEnd.API.Models
{
    public class ClubPlayer
    {
		public int PlayerControlId { get; set; }
		public int WorldCup { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public String PlayerDisplayName { get; set; }
		public String TeamName { get; set; }
		public String TeamInitials { get; set; }
		public byte[] TeamFlag { get; set; }
	}
}