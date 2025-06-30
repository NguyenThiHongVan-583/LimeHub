using LimeHub.Data;
using LimeHub.Models.Interfaces;
using LimeHub.Models.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<LimeHubDbContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("LimeHubDbContextConnection"))); // [cite: 229]

builder.Services.AddScoped<IProductRepository, ProductRepository>(); // [cite: 229]
builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>(ShoppingCartRepository.GetCart); // [cite: 229]

// Đăng ký HttpContextAccessor và Session TẠI ĐÂY (trước builder.Build())
builder.Services.AddHttpContextAccessor(); // [cite: 228, 229]
builder.Services.AddSession(); // [cite: 228, 229]

var app = builder.Build(); // [cite: 229]

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Kích hoạt Session sau UseRouting và trước UseAuthorization
app.UseSession(); // [cite: 229]

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
