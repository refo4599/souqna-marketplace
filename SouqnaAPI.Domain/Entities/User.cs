using System;
using System.Collections.Generic;
using System.Text;
using SouqnaAPI.Domain.Enums;

namespace SouqnaAPI.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public UserRole Role { get; set; } = UserRole.Customer;
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Seller? Seller { get; set; }
    public ICollection<Order> Orders { get; set; } = [];
}