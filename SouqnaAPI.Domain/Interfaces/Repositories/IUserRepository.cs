using System;
using System.Collections.Generic;
using System.Text;
using SouqnaAPI.Domain.Entities;

namespace SouqnaAPI.Domain.Interfaces.Repositories;

public interface IUserRepository : IGenericRepository<User>
{
    Task<User?> GetByEmailAsync(string email);
    Task<User?> GetWithSellerAsync(string email);
    Task<bool> EmailExistsAsync(string email);
}