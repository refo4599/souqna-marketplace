using System;
using System.Collections.Generic;
using System.Text;
namespace SouqnaAPI.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public int SellerId { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Images { get; set; } = "[]";
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Seller Seller { get; set; } = null!;
    public Category Category { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = [];
}