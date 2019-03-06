using CodeChallengeV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeV2.Services
{
    public interface IGeocodeService
    {
        Task<string> FindCountryCode(GeocodePayload payload);
    }
}
