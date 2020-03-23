using System;
using System.Collections.Generic;
using System.Text;

namespace GunnarsAutoV2.Entities
{
    public class Sale
    {
        protected int id;
        protected decimal transactionPrice;
        protected string isNewOrSold;
        protected int salesPersonID;
        protected int carID;

        public Sale(int id, decimal transactionPrice, string isNewOrSold, int salesPersonID, int carID)
        {
            Id = id;
            TransactionPrice = transactionPrice;
            IsNewOrSold = isNewOrSold;
            SalesPersonID = salesPersonID;
            CarID = carID;
        }

        public virtual int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public virtual decimal TransactionPrice
        {
            get
            {
                return transactionPrice;
            }

            set
            {
                transactionPrice = value;
            }
        }

        public virtual string IsNewOrSold
        {
            get
            {
                return isNewOrSold;
            }

            set
            {
                isNewOrSold = value;
            }
        }

        public virtual int SalesPersonID
        {
            get
            {
                return salesPersonID;
            }

            set
            {
                salesPersonID = value;
            }
        }

        public virtual int CarID
        {
            get
            {
                return carID;
            }

            set
            {
                carID = value;
            }
        }
    }
}