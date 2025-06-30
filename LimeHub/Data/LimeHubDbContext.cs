using Microsoft.EntityFrameworkCore;
using LimeHub.Models;

namespace LimeHub.Data
{
    public class LimeHubDbContext:DbContext
    {
        public LimeHubDbContext(DbContextOptions<LimeHubDbContext> options) :
base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Harley-Davidson Iron 883", Price = 25000, Detail = "Xe moto classic với động cơ V-Twin mạnh mẽ.", ImageUrl = "https://d2bywgumb0o70j.cloudfront.net/2021/01/20/220b7566e1ba42e4bafe043cb3d6846b_4a03e718d1581c31.jpg" },
                new Product { Id = 2, Name = "Kawasaki Ninja 400", Price = 18000, Detail = "Xe sportbike tầm trung, linh hoạt và tốc độ.", ImageUrl = "https://thuongmotor.com/wp-content/uploads/2020/11/Kawasaki-Ninja-400-ABS-SE-01.jpg" },
                new Product { Id = 3, Name = "Yamaha MT-07", Price = 20000, Detail = "Xe naked bike với mô-men xoắn cao, dễ lái.", ImageUrl = "https://motorrock.com.vn/upload/hinhanh/mt077431.jpg" },
                new Product { Id = 4, Name = "Ducati Monster", Price = 30000, Detail = "Xe naked bike hiệu suất cao từ Ý.", ImageUrl = "https://vuongkhangmotor.com/upload/product/444-7625-6153.jpg" },
                new Product { Id = 5, Name = "BMW R 1250 GS", Price = 35000, Detail = "Xe adventure touring hàng đầu, phù hợp mọi địa hình.", ImageUrl = "https://autopro8.mediacdn.vn/2021/12/20/7r1250gs-1639988992690260853955.jpg" },
                new Product { Id = 6, Name = "Honda CBR650R", Price = 22000, Detail = "Xe sportbike đa dụng, cân bằng giữa hiệu suất và sự thoải mái.", ImageUrl = "https://hondamotor.vn/upload/hinhanh/cbr650r3712.jpg" }
            );
        }
    }
}


