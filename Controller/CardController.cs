using LOrdCardShop.Models;
using LOrdCardShop.Repository;
using System.Collections.Generic;

namespace LOrdCardShop.Controller
{
    public class CardController
    {
        CardRepository cardRepository = new CardRepository();

        public string validateCard(string name, decimal price, string desc, string type, bool isFoil)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 5 || name.Length > 30)
            {
                return "Card name must be between 5 and 30 characters";
            }

            if (price < 10000)
            {
                return "Card price must be greater or equal to 10000";
            }

            if (string.IsNullOrEmpty(desc))
            {
                return "Description cannot be empty";
            }

            if (type != "Spell" && type != "Monster")
            {
                return "Type must be Spell or Monster";
            }

            return "";
        }

        public void addCard(Card card)
        {
            cardRepository.insertCard(card);
        }

        public void updateCard(int id, Card card)
        {
            cardRepository.editCard(id, card);
        }

        public void deleteCard(int id)
        {
            cardRepository.deleteCard(id);
        }

        public List<Card> retrieveCard()
        {
            return cardRepository.getAllCards();
        }

        public Card getCardUsingId(int id)
        {
            return cardRepository.getCardById(id);
        }
    }
}
