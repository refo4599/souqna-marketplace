using System;
using System.Collections.Generic;
using System.Text;
using SouqnaAPI.Domain.Entities;
using SouqnaAPI.Domain.Enums;

namespace SouqnaAPI.Domain.Interfaces.Repositories;

public interface ISellerRepository : IGenericRepository<Seller>
{
    Task<IEnumerable<Seller>> GetByStatusAsync(SellerStatus status);
    Task<Seller?> GetByUserIdAsync(int userId);
    Task<Seller?> GetWithProductsAsync(int id);
}