using Microsoft.AspNetCore.SignalR;
using SignalR.Interfaces;
using USAPrimeAPI.BusinessModels;

namespace SignalR.Hubs
{
    public class FirstHub:Hub<ITypedHubClient>
    {
        
    }
}
