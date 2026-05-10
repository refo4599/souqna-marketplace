using System;
using System.Collections.Generic;
using System.Text;
using SouqnaAPI.Domain.Enums;

namespace SouqnaAPI.Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal PlatformFee { get; set; }
    public decimal SellerAmount { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    public string PaymentMethod { get; set; } = "COD";
    public string ShippingAddress { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public User Customer { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = [];
}