using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dejaview_api.Controllers
{
    [Route("api/[controller]")]
    public class AssetsController : Controller
    {
        // GET api/scrapjob
        // Returns a list of scrap jobs that need to be done.
        public IEnumerable<string> Get()
        {
            return new string[]
            {
                "4f817e9d3ad82887d8cac11f1c41e198", 
                "08d7baf2c4338914f8d10a85f28c2a67"
            };
        }

        // GET api/assets/20-Haines-Street-Curtin-ACT-2605
        [HttpGet("{id}")]
        public IEnumerable<Model.Asset> Get(string id)
        {
            var assetList = new List<Model.Asset>();

            Console.WriteLine("Running Get: " + id);
            var rootDirectoryName = "/home/ben/git/dejaview/dejaview-frontend/images/" + id;

            if (Directory.Exists(rootDirectoryName) == false) 
            {
                return assetList;
            }

            var dirs = Directory.GetDirectories(rootDirectoryName);

            foreach (var dir in dirs)
            {
                var source = Path.GetFileName(dir);

                foreach (var file in Directory.GetFiles(dir))
                {
                    

                    var asset = new Model.Asset() {
                        Id = "foo",
                        BlobUri = "./images/" + id + "/" + source + "/" + Path.GetFileName(file),
                        DateCreated = new DateTime(2018, 1, 28),
                        Source = source
                    };

                    Console.WriteLine("BlobUri : " + asset.BlobUri);

                    assetList.Add(asset);
                }
            }


            return assetList;


            return new List<Model.Asset>() {
                new Model.Asset() {
                    Id = "One",
                    BlobUri = "./images/20-haines-st-curtin-act-2605/025ee00bf350b530827d0b3a93ba1f97_hd.jpg",
                    DateCreated = new DateTime(2018, 1, 28),
                    Source = "allhomes.com.au"
                },
                new Model.Asset() {
                    Id = "Two",
                    BlobUri = "./images/20-haines-st-curtin-act-2605/4bdab746fdcb055f00c49e8e496fc596_hd.jpg",
                    DateCreated = new DateTime(2018, 1, 30),
                    Source = "allhomes.com.au"
                },
                new Model.Asset() {
                    Id = "Three",
                    BlobUri = "./images/640x480.png",
                    DateCreated = new DateTime(2018, 1, 30),
                    Source = "allhomes.com.au"
                }
            };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
