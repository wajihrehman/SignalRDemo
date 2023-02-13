using USAPrimeAPI.BusinessModels;

namespace SignalR.Interfaces
{
    public interface ITypedHubClient
    {
        Task BroadcastMessage(List<Years> year);

    }
}
