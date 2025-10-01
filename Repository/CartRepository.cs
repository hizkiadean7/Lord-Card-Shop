using LOrdCardShop.Handler;
using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Repository
{
    public class CartRepository
    {
        DatabaseEntities2 db = new DatabaseEntities2();
        CardHandler cardHandler = new CardHandler();
        public void insertCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public void deleteCart(Cart cart)
        {

            if (cart != null)
            {
                db.Carts.Remove(cart);
                db.SaveChanges();
            }
        }

        public Cart getCartId(int id)
        {
            return db.Carts.Find(id);
        }
        public List<Cart> getAllCarts()
        {
            return db.Carts.ToList();
        }


    }
}