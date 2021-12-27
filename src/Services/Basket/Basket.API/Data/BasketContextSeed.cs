using Basket.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Data
{
    public class BasketContextSeed
    {
        public static void SeedData(IMongoCollection<ShoppingCart> shoppingCartCollection)
        {
            bool existCart = shoppingCartCollection.Find(p => true).Any();
            if (!existCart)
            {
                shoppingCartCollection.InsertManyAsync(GetPreconfiguredShoppingCarts());
            }
        }

        private static IEnumerable<ShoppingCart> GetPreconfiguredShoppingCarts()
        {
            return new List<ShoppingCart>()
            {
                new ShoppingCart()
                {
                
                },
             
            };
        }
    }
}
