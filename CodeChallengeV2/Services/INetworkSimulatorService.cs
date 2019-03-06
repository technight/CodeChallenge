using CodeChallengeV2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeChallengeV2.Services
{
    public interface INetworkSimulatorService
    {
        Task<List<Node>> FindCritialGateways(NetworkGraph graph);
    }
}