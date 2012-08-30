using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace Achei.Amigos.Web.Controllers
{
    public class LocationController : ApiController
    {
        // POST /api/location
        public string Post(string latitude, string longitude)
        {
            return string.Format("Latitude: {0} Longitude: {1}", latitude, longitude);
        }
    }
}
