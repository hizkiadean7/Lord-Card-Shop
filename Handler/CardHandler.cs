using LOrdCardShop.Controller;
using LOrdCardShop.Factory;
using LOrdCardShop.Models;
using System.Collections.Generic;

namespace LOrdCardShop.Handler
{
    public class CardHandler
    {
        CardController cardController = new CardController();
        CardFactory cardFactory = new CardFactory();

        public string addCard(string name, decimal price, string desc, string type, bool isFoil)
        {
            string errorMsg = cardController.validateCard(name, price, desc, type, isFoil);
            if (!string.IsNullOrEmpty(errorMsg))
            {
                return errorMsg;
            }

            Card card = cardFactory.createCard(name, price, desc, type, isFoil);
            cardController.addCard(card);
            return "";
        }

        public List<Card> getCards()
        {
            return cardController.retrieveCard();
        }

        public Card getCardUsingId(int id)
        {
            return cardController.getCardUsingId(id);
        }
        public string updateCard(int id, string name, decimal price, string desc, string type, bool isFoil)
        {
            string errorMsg = cardController.validateCard(name, price, desc, type, isFoil);
            if (!string.IsNullOrEmpty(errorMsg))
            {
                return errorMsg;
            }

            Card card = cardFactory.createCard(name, price, desc, type, isFoil);
            cardController.updateCard(id, card);
            return "";
        }

        public void deleteCard(int id)
        {
            cardController.deleteCard(id);
        }
    }
}
