using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallengeV2.Models;

namespace CodeChallengeV2.Services
{
    public class GeocodeService : IGeocodeService
    {
        public Task<string> FindCountryCode(GeocodePayload payload)
        {
            return Task.FromResult("DK");
        }
    }
}
