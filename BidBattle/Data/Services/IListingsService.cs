﻿using BidBattle.Models;

namespace BidBattle.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);

        Task<Listing> GetById(int? id);
        Task SaveChanges();
    }
}
