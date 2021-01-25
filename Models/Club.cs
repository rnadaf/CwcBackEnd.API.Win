using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CwcBackEnd.API.Models
{
    public class Club
    {
        public int ClubControlId { get; set; }
        public int TeamControlId { get; set; }
        public string ClubName { get; set; }
        public int NumPlayers { get; set; }
        public String TeamName { get; set; }
        public String TeamInitials { get; set; }
        public byte[] TeamFlag { get; set; }
    }
}