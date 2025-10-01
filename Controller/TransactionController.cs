using LOrdCardShop.Factory;
using LOrdCardShop.Models;
using LOrdCardShop.Repository;
using System;
using System.Collections.Generic;

namespace LOrdCardShop.Controller
{
    public class TransactionController
    {
        TransactionRepository transactionRepository = new TransactionRepository();
        TransactionFactory transactionFactory = new TransactionFactory();

        public List<TransactionHeader> getTransactionHeaders()
        {
            return transactionRepository.GetTransactionHeaders();
        }

        public int createTransaction(int custId)
        {
            TransactionHeader transaction = transactionFactory.createTransaction(custId);
            return transactionRepository.insertTransaction(transaction);
        }

        public void createTransactionDetail(int transactionId, int cardId, int quantity)
        {
            TransactionDetail detail = transactionFactory.createDetail(transactionId, cardId, quantity);
            transactionRepository.insertDetails(detail);
        }

        public List<TransactionHeader> getTransactionById(int id)
        {
            return transactionRepository.getTransactionById(id);
        }

        public List<TransactionHeader> getTransactionByCustId(int id)
        {
            return transactionRepository.getTransactionByCustId(id);
        }

        public void handleTransaction(int id)
        {
            transactionRepository.handleTransaction(id);
        }

        public List<TransactionDetail> getTransactionDetail(int id)
        {
            return transactionRepository.getTransactionDetail(id);
        }
    }
}
