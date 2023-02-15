//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//=================================

using Sheenam.Api.Brokers.Loggings;
using Sheenam.Api.Brokers.Storages;
using Sheenam.Api.Models.Foundations.Guests;
using System;
using System.Threading.Tasks;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public class GuestService : IGuestService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public GuestService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker)
            {
                this.storageBroker = storageBroker;
                this.loggingBroker = loggingBroker;
            }

        public async ValueTask<Guest> AddGuestAsync(Guest guest)
        {
            this.loggingBroker.LogError(new Exception("Something"));
            return await this.storageBroker.InsertGuestAsync(guest);
        }
    }
}
