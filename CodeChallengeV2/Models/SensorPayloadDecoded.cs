using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeV2.Models
{
    /// <summary>
    /// Decoded sensor data from the Digital Matter SensorNode. 
    /// </summary>
    public class SensorPayloadDecoded : PayloadBase
    {
        /// <summary>
        /// Decoded battery value of port 20
        /// </summary>
        public int? Battery { get; set; }
        /// <summary>
        /// Decoded value of port 40
        /// </summary>
        public double? TempInternal { get; set; }
        /// <summary>
        /// Decoded value of port 41
        /// </summary>
        public double? TempRed { get; set; }
        /// <summary>
        /// Decoded value of port 42
        /// </summary>
        public double? TempBlue { get; set; }
        /// <summary>
        /// Decoded temperature value of port 43
        /// </summary>
        public double? TempHumidity { get; set; }
        /// <summary>
        /// Decoded humidity value of port 43
        /// </summary>
        public double? Humidity { get; set; }
    }
}
