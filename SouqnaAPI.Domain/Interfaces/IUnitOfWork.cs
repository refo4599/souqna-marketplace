using System;
using System.Collections.Generic;
using System.Text;
using SouqnaAPI.Domain.Interfaces.Repositories;

namespace SouqnaAPI.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IProductRepository Products { get; }
    IOrderRepository Orders { get; }
    ISellerRepository Sellers { get; }

    Task<int> SaveChangesAsync();
}