using System;
namespace MyDietSchedule.Data.Interfaces
{
    public interface INetworkConnection
    {
        bool IsConnected { get; set; }
        void CheckNetworkConnection();
    }
}
