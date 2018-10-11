using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gucci_frontend.Models;
using System.Data;

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
                String sql = "SELECT Latitude, Longitude FROM [dbo].[Points] WHERE Id = @id";

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
                                longitude = reader.GetDouble(1)
                            };
                        }
                    }
                }
            }
            return a;
        }

    // POST api/<controller>
    [HttpPost]
    public int Post([FromBody]Point value)
    {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "guccidb-server.database.windows.net";
            builder.UserID = "obiwan";
            builder.Password = "Gucci2018";
            builder.InitialCatalog = "gucci-db";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {

                connection.Open();
                String sql = "INSERT INTO [dbo].[Points] (Latitude, Longitude) VALUES (@Latitude, @Longitude) SET @ID = SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    var param1 = new SqlParameter("Latitude", System.Data.SqlDbType.Float);
                    var param2 = new SqlParameter("Longitude", System.Data.SqlDbType.Float);

                    param1.Value = value.latitude;
                    param2.Value = value.longitude;
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);
                    command.Parameters.Add("@ID", System.Data.SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                    command.ExecuteNonQuery();
                    return (int)command.Parameters["@ID"].Value;
                }
            }



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
