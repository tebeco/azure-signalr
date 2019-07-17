﻿namespace Microsoft.Azure.SignalR
{
    interface IServiceConnectionFactory
    {
        IServiceConnection Create(HubServiceEndpoint endpoint, IServiceMessageHandler serviceMessageHandler, ServerConnectionType type);
    }
}
