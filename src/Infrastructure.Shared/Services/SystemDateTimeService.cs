using HelpDesk.Architecture.Application.Interfaces.Services;
using System;

namespace HelpDesk.Architecture.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}