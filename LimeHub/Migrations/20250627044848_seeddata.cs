using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LimeHub.Migrations
{
    /// <inheritdoc />
    public partial class Seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Xe moto classic với động cơ V-Twin mạnh mẽ.", "https://d2bywgumb0o70j.cloudfront.net/2021/01/20/220b7566e1ba42e4bafe043cb3d6846b_4a03e718d1581c31.jpg", false, "Harley-Davidson Iron 883", 25000 },
                    { 2, "Xe sportbike tầm trung, linh hoạt và tốc độ.", "https://thuongmotor.com/wp-content/uploads/2020/11/Kawasaki-Ninja-400-ABS-SE-01.jpg", false, "Kawasaki Ninja 400", 18000 },
                    { 3, "Xe naked bike với mô-men xoắn cao, dễ lái.", "https://motorrock.com.vn/upload/hinhanh/mt077431.jpg", false, "Yamaha MT-07", 20000 },
                    { 4, "Xe naked bike hiệu suất cao từ Ý.", "https://vuongkhangmotor.com/upload/product/444-7625-6153.jpg", false, "Ducati Monster", 30000 },
                    { 5, "Xe adventure touring hàng đầu, phù hợp mọi địa hình.", "https://autopro8.mediacdn.vn/2021/12/20/7r1250gs-1639988992690260853955.jpg", false, "BMW R 1250 GS", 35000 },
                    { 6, "Xe sportbike đa dụng, cân bằng giữa hiệu suất và sự thoải mái.", "https://hondamotor.vn/upload/hinhanh/cbr650r3712.jpg", false, "Honda CBR650R", 22000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
