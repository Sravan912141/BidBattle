using BidBattle.Models;

namespace BidBattle.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
