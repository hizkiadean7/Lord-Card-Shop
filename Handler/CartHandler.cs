using LOrdCardShop.Controller;
using LOrdCardShop.Factory;
using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Handler
{
    public class CartHandler
    {
        CartFactory cartFactory = new CartFactory();
        CartController cartController = new CartController();
        public void addToCart (int cardId, int userId, int quantity)
        {
            Cart cart = cartFactory.createCart(cardId, userId, quantity);
            cartController.addCart(cart);
        }

        public List<Cart> getCarts()
        {
            return cartController.retrieveCart();
        }

        public void removeCart(Cart cart)
        {
            cartController.removeCart(cart);
        }
    }
}