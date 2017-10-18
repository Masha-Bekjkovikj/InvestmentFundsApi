using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InvestmentFundsApi.Models;

namespace InvestmentFundsApi.Controllers
{
    public class TransactionsController: ApiController
    {
        // GET: api/Funds
        public List<Transaction> Get()
        {
            return new List<Transaction>();
        }

        

        
    }
}
