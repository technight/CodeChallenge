using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeV2.Models
{
    /// <summary>
    /// Geocode payload from the Digital Matter SensorNode. 
    /// </summary>
    public class GeocodePayload : PayloadBase
    {
        /// <summary>
        /// Longitude of the device, as a string.
        /// </summary>        
        /// <example>12.484492</example>
        public string Long { get; set; }
        /// <summary>
        /// DeviceLatitude of the device, as a string.
        /// </summary>        
        /// <example>55.781619</example>
        public string Lat { get; set; }

    }
}
