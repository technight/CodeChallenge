using CodeChallengeV2.Attributes;
using CodeChallengeV2.Models;
using CodeChallengeV2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeV2.Controllers
{
    public class NetworkPlanningController : Controller
    {
        private readonly INetworkSimulatorService simulator;

        public NetworkPlanningController(INetworkSimulatorService simulator)
        {
            this.simulator = simulator;
        }
        /// <summary>
        /// Detects critical gateways in the network. A critial gateway is a gateway that, if missing, would leave devices unable to connect. 
        /// </summary>
        /// <param name="body">Graph containing verticies and edges of a LoRaWAN network topology.</param>
        [HttpPost]
        [Route("api/networkplanning/simulate")]
        [ValidateModelState]
        [Produces(typeof(Node[]))]
        public virtual async Task<IActionResult> NetworkPlanningPostAsync([FromBody]NetworkGraph body)
        {
            // Feel free to change any implementation of the code to suit your style.
            // *As long as endpoint locations are not altered*
            List<Node> res = await this.simulator.FindCritialGateways(body);

            return new ObjectResult(res);
        }
    }
}
