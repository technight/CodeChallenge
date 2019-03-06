using CodeChallengeV2.Models;
using CodeChallengeV2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengeV2.Tests
{
    public class GeocodeServiceTest
    {

        [Theory]
        [InlineData("12.484492", "55.781619")]
        public async Task GeocodeTest(string Long, string Lat)
        {
            var obj = new GeocodePayload()
            {
                DevEUI = "Test",
                Time = DateTime.UtcNow,
                Long = Long,
                Lat = Lat
            };

            var res = await new GeocodeService().FindCountryCode(obj);

            Assert.Equal("DK", res);
        }
    }
}
