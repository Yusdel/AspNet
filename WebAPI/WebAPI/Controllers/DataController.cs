using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class DataController : ApiController
    {

        public SportMatch Get(int id)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {
                conn.Open();
            };
            /*SportMatch match = new SportMatch()
            {
                Id = 23,
                HomeTeam = "Italy",
                AwayTeam = "Faroe Island",
                HomeScore = 12,
                AwayScore = 10,
                Day = new DateTime(2019,10,10)
            };

            return match;*/
            return null;
        }
    }
}
