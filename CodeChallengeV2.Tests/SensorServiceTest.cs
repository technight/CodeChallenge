using CodeChallengeV2.Models;
using CodeChallengeV2.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengeV2.Tests
{
    public class SensorServiceTests
    {
        [Theory]
        [InlineData(41, "5f052afb0528e005")]
        public async Task DecodePayload1(int port, string data)
        {
            var obj = new SensorPayload()
            {
                DevEUI = "Test",
                Time = DateTime.UtcNow,
                FPort = port,
                Data = data,
            };

            var res = await new SensorService().DecodePayload(obj);

            Assert.Equal(obj.DevEUI, res.DevEUI);
            Assert.Equal(obj.Time, res.Time);
            Assert.Equal(13.75, res.TempRed);
            Assert.Equal(15.31, res.TempBlue);
            Assert.Equal(15.04, res.TempInternal);
        }

        [Theory]
        [InlineData(43, "f2083214df12")]
        public async Task DecodePayload2(int port, string data)
        {
            var obj = new SensorPayload()
            {
                DevEUI = "Test",
                Time = DateTime.UtcNow,
                FPort = port,
                Data = data,
            };

            var res = await new SensorService().DecodePayload(obj);

            Assert.Equal(obj.DevEUI, res.DevEUI);
            Assert.Equal(obj.Time, res.Time);
            Assert.Equal(22.9, res.TempHumidity);
            Assert.Equal(25, res.Humidity);
        }
    }
}
