using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Util;

namespace LOrdCardShop.Repository
{
    public class TransactionRepository
    {
        DatabaseEntities2 db = new DatabaseEntities2();
        public int insertTransaction(TransactionHeader transactionHeader)
        {
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();
            TransactionHeader transaciton = db.TransactionHeaders.Find(transactionHeader.TransactionID);
            return transaciton.TransactionID;
        }

        public void insertDetails(TransactionDetail transactionDetail)
        {
            db.TransactionDetails.Add(transactionDetail);
            db.SaveChanges();
        }

        public List<TransactionHeader> GetTransactionHeaders()
        {
            return db.TransactionHeaders.Include(th => th.TransactionDetails.Select(td => td.Card)).ToList();
        }

        public List<TransactionHeader> getTransactionById(int id)
        {
            List<TransactionHeader> transaction = new List<TransactionHeader>();
            transaction.Add(db.TransactionHeaders.Find(id));
            return transaction;
        }

        public List<TransactionHeader> getTransactionByCustId(int id)
        {
            return db.TransactionHeaders.Where(th => th.CustomerID == id).ToList();
        }

        public void handleTransaction(int id)
        {
            TransactionHeader transaction = db.TransactionHeaders.Find(id);
            transaction.Status = "Handled";
            db.SaveChanges();
        }

        public List<TransactionDetail> getTransactionDetail(int id)
        {
            return db.TransactionDetails
             .Where(td => td.TransactionID == id)
             .ToList();
        }
    }


}