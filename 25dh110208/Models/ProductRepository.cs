using System.Collections.Generic;

namespace 25dh110208.Models
{
    // Repository mẫu cung cấp dữ liệu để thử tính năng.
    // Khi làm với database của lớp, thay danh sách này bằng truy vấn database.
    public static class ProductRepository
    {
        public static List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Nike Air Force 1", ProductDescription = "Giày sneaker Nike màu trắng", UnitPrice = 2500000m },
                new Product { ProductID = 2, ProductName = "Adidas Superstar", ProductDescription = "Giày Adidas phong cách cổ điển", UnitPrice = 2100000m },
                new Product { ProductID = 3, ProductName = "Adidas Grand Court", ProductDescription = "Giày thể thao dùng hằng ngày", UnitPrice = 1600000m },
                new Product { ProductID = 4, ProductName = "Nike Dunk Low", ProductDescription = "Giày sneaker kiểu dáng thấp", UnitPrice = 2900000m },
                new Product { ProductID = 5, ProductName = "Puma Smash", ProductDescription = "Giày Puma đơn giản", UnitPrice = 1400000m },
                new Product { ProductID = 6, ProductName = "Converse Chuck Taylor", ProductDescription = "Giày vải cổ điển", UnitPrice = 1300000m },
                new Product { ProductID = 7, ProductName = "New Balance 574", ProductDescription = "Giày thể thao phong cách retro", UnitPrice = 2600000m },
                new Product { ProductID = 8, ProductName = "Vans Old Skool", ProductDescription = "Giày skate dùng hằng ngày", UnitPrice = 1750000m },
                new Product { ProductID = 9, ProductName = "Nike Revolution", ProductDescription = "Giày chạy bộ nhẹ", UnitPrice = 1800000m },
                new Product { ProductID = 10, ProductName = "Adidas Runfalcon", ProductDescription = "Giày chạy bộ Adidas", UnitPrice = 1500000m },
                new Product { ProductID = 11, ProductName = "Asics Gel", ProductDescription = "Giày chạy bộ có đệm", UnitPrice = 3200000m },
                new Product { ProductID = 12, ProductName = "Reebok Classic", ProductDescription = "Giày phong cách cổ điển", UnitPrice = 1900000m },
                new Product { ProductID = 13, ProductName = "Mizuno Wave", ProductDescription = "Giày chạy bộ thể thao", UnitPrice = 2800000m },
                new Product { ProductID = 14, ProductName = "Fila Disruptor", ProductDescription = "Giày đế dày phong cách chunky", UnitPrice = 2200000m },
                new Product { ProductID = 15, ProductName = "Under Armour Charged", ProductDescription = "Giày tập luyện", UnitPrice = 2400000m }
            };
        }
    }
}
