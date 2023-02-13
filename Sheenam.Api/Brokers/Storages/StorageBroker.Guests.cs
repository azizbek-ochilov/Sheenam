using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Models.Foundations.Guests;
using System.Threading.Tasks;

namespace Sheenam.Api.Brokers.Storages
{
    public partial class  StorageBroker
    {
        DbSet<Guest> Guests { get; set; }
        public async ValueTask<Guest> InsertGuestAsync(Guest guest)
        {
            using var broker = new SorageBroker(this.configuration);

            await broker.Guests.AddAsync(guest);
            await broker.SaveChangesAsync();
        }
    }
}
