using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvestmentFundsApi.Models
{
    public abstract class Request
    {
        public int requestId { get; set; }
        public decimal amount { get; set; }
        public string status { get; set; }
    }
    public class BuyRequest : Request
    {
        public int fondId { get; set; }
        public string paymentType { get; set; }
        public bool fundAcceptance { get; set; }
    }

    public class SellRequest : Request
    {
        public int fondId { get; set; }
        public string sellType { get; set; }
        public string bank { get; set; }
        public string accountNumber { get; set; }
    }
    public class TransferRequest : Request
    {
        public int sourceFundId { get; set; }
        public int destinationFundId { get; set; }
        public string sellType { get; set; }
        public bool fundAcceptance { get; set; }
        public bool riskAcceptance { get; set; }
    }
}