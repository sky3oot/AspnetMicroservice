using Basket.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Data
{
   public interface IBasketContext
    {
        IMongoCollection<ShoppingCart> ShoppingCarts { get; }
    }
}
