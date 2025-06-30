namespace LimeHub.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Detail { get; set; }

        public string? ImageUrl { get; set; }

        public int Price { get; set; }

        public bool IsTrendingProduct { get; set; }

        public string? VehicleType { get; set; } // Loại

        public int YearsUsed { get; set; } // Năm sử dụng

        public int Mileage { get; set; } // Số km 

        public string? Condition { get; set; }

        public int ManufactureYear { get; set; } // Năm sản xuất

        public string? FuelTransmission { get; set; } // Fuel / Transmission

        public string? EngineDisplacement { get; set; } // Động cơ 

        public string? Color { get; set; } // Màu sắc

        public string? Location { get; set; } // Khu vực 

        public DateTime PostedDate { get; set; } // Thời gian đăng 

        public int ViewsCount { get; set; } // Lượt xem
    }
}
