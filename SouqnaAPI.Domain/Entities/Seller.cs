using System;
using System.Collections.Generic;
using System.Text;
using SouqnaAPI.Domain.Enums;

namespace SouqnaAPI.Domain.Entities;

public class Seller
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string ShopName { get; set; } = string.Empty;
    public string ShopDesc { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string? Logo { get; set; }
    public SellerStatus Status { get; set; } = SellerStatus.Pending;

    public User User { get; set; } = null!;
    public ICollection<Product> Products { get; set; } = [];
}