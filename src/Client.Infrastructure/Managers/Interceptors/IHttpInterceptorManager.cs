﻿using System.Threading.Tasks;
using Toolbelt.Blazor;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Interceptors
{
    public interface IHttpInterceptorManager : IManager
    {
        void RegisterEvent();

        Task InterceptBeforeHttpAsync(object sender, HttpClientInterceptorEventArgs e);

        void DisposeEvent();
    }
}