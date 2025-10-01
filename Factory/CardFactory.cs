using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace LOrdCardShop.Factory
{
    public class CardFactory
    {
        public Card createCard(string name, decimal price, string desc, string type, bool foil)
        {
            Card card = new Card();

            card.CardName = name;
            card.CardPrice = price;
            card.CardDesc = desc;
            card.CardType = type;
            card.isFoil = foil;

            return card;
        }
    }
}