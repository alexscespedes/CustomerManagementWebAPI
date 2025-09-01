using System;
using CustomerManagementWebAPI.Enums;
using CustomerManagementWebAPI.Models;

namespace CustomerManagementWebAPI.Data;

public class DbInitializer
{
    public static void Seed(AppDbContext context)
    {
        if (context.Customers.Any() || context.Products.Any() || context.Orders.Any())
        {
            return;
        }

        var customers = new List<Customer>
        {
            new Customer
            {
                Name = "John Smith",
                Email = "john.smith@email.com",
                Phone = "+1-555-0101",
                CustomerType = CustomerType.Premium
            },
            new Customer
            {
                Name = "Sarah Johnson",
                Email = "sarah.j@email.com",
                Phone = "+1-555-0102",
                CustomerType = CustomerType.VIP
            },
            new Customer
            {
                Name = "Michael Brown",
                Email = "m.brown@email.com",
                Phone = "+1-555-0103",
                CustomerType = CustomerType.Regular
            },
            new Customer
            {
                Name = "Emily Davis",
                Email = "emily.davis@email.com",
                Phone = "+1-555-0104",
                CustomerType = CustomerType.Premium
            },
            new Customer
            {
                Name = "David Wilson",
                Email = "d.wilson@email.com",
                Phone = "+1-555-0105",
                CustomerType = CustomerType.Regular
            },
            new Customer
            {
                Name = "Lisa Martinez",
                Email = "lisa.martinez@email.com",
                Phone = "+1-555-0106",
                CustomerType = CustomerType.VIP
            },
            new Customer
            {
                Name = "Robert Taylor",
                Email = "r.taylor@email.com",
                Phone = "+1-555-0107",
                CustomerType = CustomerType.Regular
            },
            new Customer
            {
                Name = "Jennifer Anderson",
                Email = "j.anderson@email.com",
                Phone = "+1-555-0108",
                CustomerType = CustomerType.Premium
            },
            new Customer
            {
                Name = "William Garcia",
                Email = "w.garcia@email.com",
                Phone = "+1-555-0109",
                CustomerType = CustomerType.Regular
            },
            new Customer
            {
                Name = "Maria Rodriguez",
                Email = "maria.rodriguez@email.com",
                Phone = "+1-555-0110",
                CustomerType = CustomerType.VIP
            }
        };

        context.Customers.AddRange(customers);
        context.SaveChanges();

        var products = new List<Product>
        {
            // Electronics Category
            new Product
            {
                Name = "Gaming Laptop",
                Description = "17-inch 4K display, RTX 4070, 32GB RAM",
                Price = 2499.99m,
                StockQuantity = 8,
                Category = "Electronics",
                ImageUrl = "/images/gaming-laptop.jpg"
            },
            new Product
            {
                Name = "Wireless Headphones",
                Description = "Noise-canceling, 30-hour battery life",
                Price = 299.95m,
                StockQuantity = 45,
                Category = "Electronics",
                ImageUrl = "/images/wireless-headphones.jpg"
            },
            new Product
            {
                Name = "Smartphone Pro",
                Description = "5G enabled, 256GB storage, triple camera",
                Price = 1199.00m,
                StockQuantity = 22,
                Category = "Electronics",
                ImageUrl = "/images/smartphone-pro.jpg"
            },
            new Product
            {
                Name = "4K Monitor",
                Description = "27-inch IPS display, USB-C hub",
                Price = 449.99m,
                StockQuantity = 15,
                Category = "Electronics",
                ImageUrl = "/images/4k-monitor.jpg"
            },
            new Product
            {
                Name = "Wireless Mouse",
                Description = "Ergonomic design, precision tracking",
                Price = 89.99m,
                StockQuantity = 67,
                Category = "Electronics",
                ImageUrl = "/images/wireless-mouse.jpg"
            },

            // Books Category
            new Product
            {
                Name = "The Tech Entrepreneur",
                Description = "Bestselling business guide for startups",
                Price = 24.99m,
                StockQuantity = 75,
                Category = "Books",
                ImageUrl = "/images/tech-entrepreneur.jpg"
            },
            new Product
            {
                Name = "Mystery of the Lost Code",
                Description = "Thrilling cyberpunk novel",
                Price = 16.95m,
                StockQuantity = 120,
                Category = "Books",
                ImageUrl = "/images/mystery-lost-code.jpg"
            },
            new Product
            {
                Name = "Learning ASP.NET Core",
                Description = "Complete guide to web development",
                Price = 39.99m,
                StockQuantity = 35,
                Category = "Books",
                ImageUrl = "/images/learning-aspnet.jpg"
            },
            new Product
            {
                Name = "Digital Photography Basics",
                Description = "Master the art of digital photography",
                Price = 29.95m,
                StockQuantity = 58,
                Category = "Books",
                ImageUrl = "/images/photography-basics.jpg"
            },

            // Clothing Category
            new Product
            {
                Name = "Premium Cotton T-Shirt",
                Description = "100% organic cotton, unisex fit, multiple colors",
                Price = 19.99m,
                StockQuantity = 150,
                Category = "Clothing",
                ImageUrl = "/images/cotton-tshirt.jpg"
            },
            new Product
            {
                Name = "Denim Jacket",
                Description = "Classic blue denim, vintage style",
                Price = 79.99m,
                StockQuantity = 28,
                Category = "Clothing",
                ImageUrl = "/images/denim-jacket.jpg"
            },
            new Product
            {
                Name = "Running Shoes",
                Description = "Lightweight, breathable mesh, cushioned sole",
                Price = 129.99m,
                StockQuantity = 42,
                Category = "Clothing",
                ImageUrl = "/images/running-shoes.jpg"
            },
            new Product
            {
                Name = "Wool Sweater",
                Description = "Merino wool, cable knit pattern",
                Price = 89.95m,
                StockQuantity = 33,
                Category = "Clothing",
                ImageUrl = "/images/wool-sweater.jpg"
            },

            // Home & Garden Category
            new Product
            {
                Name = "Smart Coffee Maker",
                Description = "WiFi enabled, programmable, 12-cup capacity",
                Price = 199.99m,
                StockQuantity = 18,
                Category = "Home & Garden",
                ImageUrl = "/images/smart-coffee-maker.jpg"
            },
            new Product
            {
                Name = "LED Desk Lamp",
                Description = "Adjustable brightness, USB charging port",
                Price = 49.99m,
                StockQuantity = 55,
                Category = "Home & Garden",
                ImageUrl = "/images/led-desk-lamp.jpg"
            },
            new Product
            {
                Name = "Garden Tool Set",
                Description = "5-piece set with carrying case",
                Price = 69.99m,
                StockQuantity = 24,
                Category = "Home & Garden",
                ImageUrl = "/images/garden-tool-set.jpg"
            },

            // Sports & Fitness Category
            new Product
            {
                Name = "Yoga Mat",
                Description = "Non-slip surface, eco-friendly material",
                Price = 34.99m,
                StockQuantity = 78,
                Category = "Sports & Fitness",
                ImageUrl = "/images/yoga-mat.jpg"
            },
            new Product
            {
                Name = "Resistance Band Set",
                Description = "5 bands with different resistance levels",
                Price = 24.95m,
                StockQuantity = 92,
                Category = "Sports & Fitness",
                ImageUrl = "/images/resistance-bands.jpg"
            },
            new Product
            {
                Name = "Water Bottle",
                Description = "Stainless steel, 32oz, temperature control",
                Price = 29.99m,
                StockQuantity = 110,
                Category = "Sports & Fitness",
                ImageUrl = "/images/water-bottle.jpg"
            }
        };

        context.Products.AddRange(products);
        context.SaveChanges();

        var orders = new List<Order>
        {
            new Order
            {
                CustomerId = 1, // John Smith
                ProductId = 1,  // Gaming Laptop
                Quantity = 1,
                TotalAmount = 2249.99m, // Premium discount applied
                OrderDate = DateTime.Now.AddDays(-5),
                Status = OrderStatus.Delivered,
                Notes = "Express delivery requested"
            },
            new Order
            {
                CustomerId = 2, // Sarah Johnson
                ProductId = 3,  // Smartphone Pro
                Quantity = 2,
                TotalAmount = 2158.20m, // VIP discount applied
                OrderDate = DateTime.Now.AddDays(-3),
                Status = OrderStatus.Shipped,
                Notes = "Gift wrapping requested"
            },
            new Order
            {
                CustomerId = 3, // Michael Brown
                ProductId = 10, // Premium Cotton T-Shirt
                Quantity = 3,
                TotalAmount = 59.97m, // Regular customer, no discount
                OrderDate = DateTime.Now.AddDays(-2),
                Status = OrderStatus.Processing
            },
            new Order
            {
                CustomerId = 4, // Emily Davis
                ProductId = 6,  // The Tech Entrepreneur
                Quantity = 1,
                TotalAmount = 22.49m, // Premium discount applied
                OrderDate = DateTime.Now.AddDays(-1),
                Status = OrderStatus.Pending,
                Notes = "Customer requested specific edition"
            },
            new Order
            {
                CustomerId = 5, // David Wilson
                ProductId = 17, // Yoga Mat
                Quantity = 2,
                TotalAmount = 69.98m, // Regular customer, no discount
                OrderDate = DateTime.Now,
                Status = OrderStatus.Pending
            }
        };
        
        context.Orders.AddRange(orders);
        context.SaveChanges();
    }
}
