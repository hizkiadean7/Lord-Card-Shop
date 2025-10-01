using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Factory
{
    public class TransactionFactory
    {
        public TransactionHeader createTransaction(int custId)
        {
            TransactionHeader transaction = new TransactionHeader();
            transaction.TransactionDate = DateTime.Now;
            transaction.Status = "Unhandled";
            transaction.CustomerID = custId;

            return transaction;
        }

        public TransactionDetail createDetail(int id, int cardId, int quantity)
        {
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.TransactionID = id;
            transactionDetail.CardID = cardId;
            transactionDetail.Quantity = quantity;
            return transactionDetail;
        }
    }
}