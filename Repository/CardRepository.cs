using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Repository
{
    public class CardRepository
    {
        DatabaseEntities2 db = new DatabaseEntities2();
        public void insertCard(Card card)
        {
            db.Cards.Add(card);
            db.SaveChanges();
        }
        public Card getCardById(int id)
        {
            return db.Cards.Find(id);
        }

        public List<Card> getAllCards()
        {
            return db.Cards.ToList();
        }

        public void editCard(int id, Card card)
        {
            Card dbCard = db.Cards.Find(id);
            dbCard.CardName = card.CardName;
            dbCard.CardPrice = card.CardPrice;
            dbCard.CardType = card.CardType;
            dbCard.CardDesc = card.CardDesc;
            dbCard.isFoil = card.isFoil;
            db.SaveChanges();
        }

        public void deleteCard(int id)
        {
            Card card = db.Cards.Find(id);
            db.Cards.Remove(card);
            db.SaveChanges();
        }
    }
}