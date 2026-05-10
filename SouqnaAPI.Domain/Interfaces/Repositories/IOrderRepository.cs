using System;
using System.Collections.Generic;
using System.Text;
using SouqnaAPI.Domain.Entities;

namespace SouqnaAPI.Domain.Interfaces.Repositories;

public interface IOrderRepository : IGenericRepository<Order>
{
    Task<IEnumerable<Order>> GetByCustomerAsync(int customerId);
    Task<IEnumerable<Order>> GetBySellerAsync(int sellerId);
    Task<Order?> GetWithDetailsAsync(int id);
    Task<IEnumerable<Order>> GetAllWithDetailsAsync(int page, int pageSize);
    Task<int> GetTotalCountAsync();
}