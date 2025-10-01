using LOrdCardShop.Controller;
using LOrdCardShop.Models;
using System.Collections.Generic;

namespace LOrdCardShop.Handler
{
    public class TransactionHandler
    {
        TransactionController transactionController = new TransactionController();

        public List<TransactionHeader> getTransactionHeaders()
        {
            return transactionController.getTransactionHeaders();
        }

        public int createTransaction(int custId)
        {
            return transactionController.createTransaction(custId);
        }

        public void createDetails(int transactionId, int cardId, int quantity)
        {
            transactionController.createTransactionDetail(transactionId, cardId, quantity);
        }

        public List<TransactionHeader> getTransaction(int id)
        {
            return transactionController.getTransactionById(id);
        }

        public List<TransactionHeader> getTransactionByCustId(int id)
        {
            return transactionController.getTransactionByCustId(id);
        }

        public void handleTransaction(int id)
        {
            transactionController.handleTransaction(id);
        }

        public List<TransactionDetail> getTransactionDetail(int id)
        {
            return transactionController.getTransactionDetail(id);
        }
    }
}
