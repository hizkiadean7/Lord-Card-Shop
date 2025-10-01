using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Factory
{
    public class CartFactory
    {
        public Cart createCart(int cardId, int userId, int quantity)
        {
            Cart cart = new Cart();

            cart.CardID = cardId;
            cart.UserID = userId;
            cart.Quantity = quantity;
            return cart;
        }
    }
}