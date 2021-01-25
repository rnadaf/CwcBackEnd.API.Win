using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CwcBackEnd.API.Base
{
    public class AppConstants
    {
        public static string CNNECTION_STRING { get { return "server=cwcmysqlserver.mysql.database.azure.com;port=3306;database=worldcup;user=cwcadmin;password=cwcMySQL15!"; } }
        public static string DISPLAY_DATE_FROMAT { get { return "EEEE MMMM d, yyyy, h: ss a"; } }
        public static string DATABSE_DATE_FROMAT { get { return "yyyy-MM-dd"; } }
        public static string DOB_DATE_FROMAT { get { return "MMM d, yyyy"; } }

        public static int INCLUDE_ALL_WORLDCUPS { get { return 1000; } }

        public static int MATCH_EVENT_GOAL { get { return 1; } }
        public static int MATCH_EVENT_SUBSTITUTION { get { return 2; } }
        public static int MATCH_EVENT_CAUTION { get { return 3; } }
        public static int MATCH_EVENT_PSO { get { return 4; } }
    }
}