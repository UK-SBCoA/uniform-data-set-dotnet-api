﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace UDS.Net.API.Client
{
    public static class UDSApiExtensions
    {
        public static void AddUDSApiClient(this IServiceCollection services, string baseAddress, double timeoutSeconds = 100)
        {
            if (!baseAddress.EndsWith("/"))
                baseAddress += "/"; // you MUST place a slash at the end of the baseaddress

            // Register all clients
            // TODO can be configured for retry and transient-fault-handling
            services.AddHttpClient<IVisitClient, VisitClient>(options =>
            {
                options.BaseAddress = new Uri(baseAddress);
                options.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
            });

            services.AddHttpClient<IParticipationClient, ParticipationClient>(options =>
            {
                options.BaseAddress = new Uri(baseAddress);
                options.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
            });

            services.AddHttpClient<ILookupClient, LookupClient>(options =>
            {
                options.BaseAddress = new Uri(baseAddress);
                options.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
            });

            services.AddHttpClient<IPacketClient, PacketClient>(options =>
            {
                options.BaseAddress = new Uri(baseAddress);
                options.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
            });

            services.AddHttpClient<IMilestoneClient, MilestoneClient>(options =>
            {
                options.BaseAddress = new Uri(baseAddress);
                options.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
            });

            // API client registered last
            services.AddSingleton<IApiClient, ApiClient>();
        }
    }

    /// <summary>
    /// Typed Client
    /// https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests
    /// </summary>
    public class ApiClient : IApiClient
    {
        public IVisitClient VisitClient { get; }
        public IParticipationClient ParticipationClient { get; }
        public ILookupClient LookupClient { get; }
        public IPacketClient PacketClient { get; }
        public IMilestoneClient MilestoneClient { get; }

        public ApiClient(IVisitClient visitClient, IParticipationClient participationClient, ILookupClient lookupClient, IPacketClient packetClient, IMilestoneClient milestoneClient)
        {
            VisitClient = visitClient;
            ParticipationClient = participationClient;
            LookupClient = lookupClient;
            PacketClient = packetClient;
            MilestoneClient = milestoneClient;
        }


    }
}

