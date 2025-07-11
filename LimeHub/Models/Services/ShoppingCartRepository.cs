﻿using LimeHub.Data;
using LimeHub.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LimeHub.Models.Services
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private LimeHubDbContext dbContext;
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();

        public string? ShoppingCartId { set; get; }

        public ShoppingCartRepository(LimeHubDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public static ShoppingCartRepository GetCart(IServiceProvider services)
        {
            ISession? session =
            services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            LimeHubDbContext context = services.GetService<LimeHubDbContext>() ??
            throw new Exception("Error initializing limehubdbcontext");
            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();
            session?.SetString("CartId", cartId);
            return new ShoppingCartRepository(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product product)
        {
            var shoppingCartItem = dbContext.ShoppingCartItems.FirstOrDefault(s =>
                s.Product != null && s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    Qty = 1,
                };
                dbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Qty++;
            }
            dbContext.SaveChanges();
        }

        public void ClearCart()
        {
            var cartItems = dbContext.ShoppingCartItems.Where(s => s.ShoppingCartId ==
            ShoppingCartId);
            dbContext.ShoppingCartItems.RemoveRange(cartItems);
            dbContext.SaveChanges();
        }

        public List<ShoppingCartItem> GetAllShoppingCartItems()
        {
            return ShoppingCartItems ??= dbContext.ShoppingCartItems.Where(s =>
                s.ShoppingCartId == ShoppingCartId).Include(p => p.Product).ToList();
        }

        public decimal GetShoppingCartTotal()
        {
            var totalCost = dbContext.ShoppingCartItems
                .Where(s => s.ShoppingCartId == ShoppingCartId && s.Product != null)
                .Select(s => s.Product!.Price * s.Qty)
                .Sum();
            return totalCost;
        }

        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem = dbContext.ShoppingCartItems.FirstOrDefault(s =>
                s.Product != null && s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);

            var quantity = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Qty > 1)
                {
                    shoppingCartItem.Qty--;
                    quantity = shoppingCartItem.Qty;
                }
                else
                {
                    dbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            dbContext.SaveChanges();
            return quantity;
        }
    }
}