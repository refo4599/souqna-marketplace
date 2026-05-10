using System;
using System.Collections.Generic;
using System.Text;
using SouqnaAPI.Domain.Entities;

namespace SouqnaAPI.Domain.Interfaces.Repositories;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<(IEnumerable<Product> Items, int Total)> GetPagedAsync(
        string? search, int? categoryId,
        decimal? minPrice, decimal? maxPrice,
        int page, int pageSize);

    Task<IEnumerable<Product>> GetBySellerAsync(int sellerId);
    Task<Product?> GetWithDetailsAsync(int id);
}