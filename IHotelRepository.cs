using System.Threading.Tasks;

namespace HotelChainManagement.Repositories
{
    /// <summary>
    /// Interface for hotel repository.
    /// </summary>
    public interface IHotelRepository
    {
        /// <summary>
        /// Adds a new hotel asynchronously.
        /// </summary>
        /// <param name="hotelDto">The hotel data transfer object.</param>
        /// <returns>A task representing the asynchronous operation, with a boolean result indicating success or failure.</returns>
        Task<bool> AddHotelAsync(HotelDto hotelDto);

        // Define other data access methods, e.g., GetHotelByIdAsync, GetAllHotelsAsync, etc.
    }
}
