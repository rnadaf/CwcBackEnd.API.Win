using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CwcBackEnd.API.Base;
using CwcBackEnd.API.Models;
using MySqlConnector;

namespace CwcBackEnd.API.Controllers
{
    public class ClubController : ApiController
    {
        private static readonly string DB_CONNECTION_STRING = AppConstants.CNNECTION_STRING;
        private static readonly string CLUB_BASE_QUERY = "SELECT Clubs.*, COUNT(PlayerWorldCup.Club_Control_ID) AS NumPlayers, Teams.Team_Name, Teams.Team_Initials, Teams.Flag " +
                "FROM Clubs INNER JOIN PlayerWorldCup ON Clubs.Club_Control_ID = PlayerWorldCup.Club_Control_ID INNER JOIN Teams ON Clubs.Team_Control_ID = Teams.Team_Control_ID ";

        [Route("api/clubs")]
        [HttpGet]
        public List<Club> GetClubs()
        {
            List<Club> clubs = new List<Club>();

            MySqlConnection connection = new MySqlConnection(DB_CONNECTION_STRING);
            connection.Open();

            string query = CLUB_BASE_QUERY + " GROUP BY Clubs.Club_Control_ID ORDER BY Clubs.Club";
            MySqlCommand command = new MySqlCommand(query, connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    clubs.Add(GetClubFromReader(reader));
                }
            }
            return clubs;
        }

        private Club GetClubFromReader(MySqlDataReader reader)
        {
            Club club = new Club
            {
                ClubControlId = Convert.ToInt32(reader["Club_Control_ID"]),
                TeamControlId = Convert.ToInt32(reader["Team_Control_ID"]),
                ClubName = reader["Club"].ToString(),
                NumPlayers = Convert.ToInt32(reader["NumPlayers"]),
                TeamName = reader["Team_Name"].ToString(),
                TeamInitials = reader["Team_Initials"].ToString(),
                TeamFlag = (byte[])(reader["Flag"])
            };
            return club;
        }
    }
}
