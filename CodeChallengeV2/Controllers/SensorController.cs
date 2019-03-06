using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallengeV2.Attributes;
using CodeChallengeV2.Models;
using CodeChallengeV2.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CodeChallengeV2.Controllers
{
    public class SensorController : Controller
    {
        private readonly ISensorService sensorService;
        public SensorController(ISensorService _sensorService)
        {
            sensorService = _sensorService;
        }
        /// <summary>
        /// Decodes raw DigitalMatter SensorNode payloads.
        /// </summary>
        /// <remarks>Expects a list of raw SensorNode payloads, should output decoded and parsed sensor data.</remarks>
        /// <param name="body">IoT device payload and identification.</param>
        [HttpPost]
        [Route("api/sensors/parse")]
        [ValidateModelState]
        [Produces(typeof(SensorPayloadDecoded[]))]
        public virtual async Task<IActionResult> SensorsParsePostAsync([FromBody]SensorPayload[] body)
        {
            // Feel free to change any implementation of the code to suit your style.
            // *As long as endpoint locations are not altered*
            var res = new List<SensorPayloadDecoded>();
            foreach(var element in body)
            {
                res.Add(await sensorService.DecodePayload(element));
            }

            return new ObjectResult(res);
        }
    }
}