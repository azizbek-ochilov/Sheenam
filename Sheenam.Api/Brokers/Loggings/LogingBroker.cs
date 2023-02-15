//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//=================================

using Microsoft.Extensions.Logging;
using System;

namespace Sheenam.Api.Brokers.Loggings
{
    public class LogingBroker : ILoggingBroker
    {
        private readonly ILogger<LogingBroker> logger;

        public LogingBroker(ILogger<LogingBroker> logger) =>
            this.logger = logger;

        public void LogCritical(Exception exception) =>
            this.logger.LogCritical(exception, exception.Message);

        public void LogError(Exception exception) =>
            this.logger.LogError(exception, exception.Message);
    }
}
