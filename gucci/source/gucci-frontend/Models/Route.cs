using System;

namespace gucci_frontend.Models
{
    public class Route
    {
        public int id { get; set; }
        public int point_id { get; set; }
        public Point point { get; set; }
        public int stopnumber { get; set; }
    }
}