using BidBattle.Models;

namespace BidBattle.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();
    }
}
