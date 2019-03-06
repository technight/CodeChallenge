using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CodeChallengeV2.Models
{
    /// <summary>
    /// Sensor payload from the Digital Matter SensorNode. 
    /// </summary>
    public partial class SensorPayload : PayloadBase
    {
        /// <summary>
        /// The LoraWAN Port used for the reading. The first ID is given by the LoRaWAN Port. 
        /// </summary>
        /// <example>43</example>
        public int FPort { get; set; }

        /// <summary>
        /// A hexidecimal representation of the data payload, data sheet defines delimiting values and lengths of payloads. Little Endian.
        /// </summary>
        /// <example>a2083714df12</example>
        public string Data { get; set; }
    }
}
