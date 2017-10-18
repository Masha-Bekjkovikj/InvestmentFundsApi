using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvestmentFundsApi.Models
{
    public class Transaction
    {
        public int transactionId { get; set; }

        public String transactionDescription { get; set; }

        public Decimal transactionShareNumber { get; set; }

        public Decimal transactionSharePrice { get; set; }

        public Decimal transactionAmountWithoutTax { get; set; }

        public Decimal transactionAmountWithTax { get; set; }

        public DateTime transactionDateCalculated { get; set; }


    }
}