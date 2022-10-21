//==============================================
//Copyright (c) Coalition Good-Hearted Engineers
//Free to Use Comfort And Peace
//==============================================


using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Brokers.Storages
{
    public partial class StorageBrokers
    {
        public DbSet<Guest>Guests{get; set;}
    }
}
