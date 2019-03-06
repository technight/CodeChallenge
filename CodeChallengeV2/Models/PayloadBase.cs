using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeV2.Models
{
    public abstract class PayloadBase
    {
        /// <summary>
        /// Device EUI, LoRaWAN devices have a 64 bit unique identifier (DevEUI) that is assigned to the device by the chip manufacturer. 
        /// </summary>        
        /// <example>1234</example>
        public string DevEUI { get; set; }

        /// <summary>
        /// The time the sensor reading was recorded. 
        /// </summary>
        /// <example>2018-06-04T15:17:23.433+02:00</example>
        public DateTime Time { get; set; }
    }
}
