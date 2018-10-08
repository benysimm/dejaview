using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dejaview_api.Model
{
    public class Asset
    {
        public string Id { get; set; }

        // MD5 hash of address
        public string AddressId { get; set; }

        // URI to the blob (e.g. AWS S3)
        public string BlobUri { get; set; }
        
        // MIME type e.g. text/xml, text/json, text/plain, image/png, image/jpeg, etc
        public string BlobType { get; set; }

        public int BlobSize { get; set; }

        // Where did this asset come from (e.g. the scrapper responsible)
        public string Source { get; set; }

        public DateTime DateCreated { get; set; }
    }
}