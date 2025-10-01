using LOrdCardShop.Models;
using LOrdCardShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Controller
{
    public class CartController
    {
        CartRepository cartRepository = new CartRepository();
        public void addCart(Cart cart)
        {
            cartRepository.insertCart(cart);
        }

        public List<Cart> retrieveCart()
        {
            return cartRepository.getAllCarts();
        }

        public void removeCart(Cart cart)
        {
            cartRepository.deleteCart(cart);
        }
    }
}