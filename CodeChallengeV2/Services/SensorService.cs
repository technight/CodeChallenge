using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallengeV2.Models;

namespace CodeChallengeV2.Services
{
    public class SensorService : ISensorService
    {
        public Task<SensorPayloadDecoded> DecodePayload(SensorPayload payload)
        {
            //TODO: implement decoding
            var res = new SensorPayloadDecoded()
            {
                DevEUI = payload.DevEUI,
                Time = payload.Time
            };

            return Task.FromResult(res);
        }
    }
}
