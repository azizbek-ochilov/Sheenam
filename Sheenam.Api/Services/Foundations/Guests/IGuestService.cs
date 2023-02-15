using Sheenam.Api.Models.Foundations.Guests;
using System.Threading.Tasks;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public interface IGuestService
    {
        ValueTask<Guest> AddGuestAsync(Guest guest);
    }
}
