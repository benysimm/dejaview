using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dejaview_api.Model
{
    public class ScrapJob
    {
        public string Id { get; set; }

        // MD5 hash of address
        public string AddressId { get; set; }

        public bool IsComplete { get; set; }
        
        public bool IsRunning { get; set; }

        public DateTime LastScrapDate { get; set; }

        public DateTime DateCreated { get; set; }
    }
}