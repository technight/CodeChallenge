using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallengeV2.Attributes;
using CodeChallengeV2.Models;
using CodeChallengeV2.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallengeV2.Controllers
{
    public class GeocodeController : Controller
    {
        private readonly IGeocodeService geocodeService;

        public GeocodeController(IGeocodeService geocodeService)
        {
            this.geocodeService = geocodeService;
        }
        /// <summary>
        /// Looks up country code from Longitude and Latitude
        /// </summary>
        /// <param name="body">Sensor identification and GPS position in Longitude and Latitude.</param>
        [HttpPost]
        [Route("api/sensors/geocode")]
        [ValidateModelState]
        [Produces(typeof(string[]))]
        public virtual async Task<IActionResult> CountryNamePostAsync([FromBody]GeocodePayload[] body)
        {
            // Feel free to change any implementation of the code to suit your style.
            // *As long as endpoint locations are not altered*
            var res = new List<GeocodePayloadDecoded>();
            foreach (var item in body)
            {
               res.Add(new GeocodePayloadDecoded {
                   DevEUI = item.DevEUI,
                   Time = item.Time,
                   CountryCode = await geocodeService.FindCountryCode(item)
               });

            }

            return new ObjectResult(res);
        }
    }
}