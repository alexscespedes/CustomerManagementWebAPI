using System;
using System.ComponentModel.DataAnnotations;
using CustomerManagementWebAPI.Enums;

namespace CustomerManagementWebAPI.Models;

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public OrderStatus OrderStatus { get; set; }
    public string? Notes { get; set; }
    public required virtual Customer Customer { get; set; }
    public required virtual Product Product { get; set; }
}
