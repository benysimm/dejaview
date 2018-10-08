using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dejaview_api.Model
{
    public class Address
    {
        // MD5 hash of address details
        public string Id { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string Suburb { get; set; }

        public string State { get; set; }

        public string PostCode { get; set; }

        public DateTime DateCreated { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}", Line1, Line2, Suburb, State, PostCode);
        }
    }
}