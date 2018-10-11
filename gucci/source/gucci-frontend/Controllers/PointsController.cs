using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gucci_frontend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gucci_frontend.Controllers
{
    [Route("api/[controller]")]
public class PointsController : Controller
{
    // GET: api/<controller>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<controller>/5
    [HttpGet("{id}")]
    public Point Get(int id)
    {
            var a = new Point();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "guccidb-server.database.windows.net";
            builder.UserID = "obiwan";
            builder.Password = "Gucci2018";
            builder.InitialCatalog = "gucci-db";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {

                connection.Open();
                String sql = "SELECT Latitude, Longtitude FROM [dbo].[Points] WHERE Id = @id";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    var param = new SqlParameter("id", System.Data.SqlDbType.Int);
                    param.Value = id;
                    command.Parameters.Add(param);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            a = new Point() {
                                id = id,
                                latitude = reader.GetDouble(0),
                                longtitude = reader.GetDouble(1)
                            };
                        }
                    }
                }
            }
            return a;
        }

    // POST api/<controller>
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/<controller>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
}
