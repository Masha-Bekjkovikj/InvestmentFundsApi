using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InvestmentFundsApi.Models;

namespace InvestmentFundsApi.Controllers
{
    public class FundsController : ApiController
    {
        // GET: api/Funds
        public List<Fund> Get()
        {
            return new List<Fund>();
        }

        // GET: api/Funds/5
        public Fund Get(int id)
        {
            return new Fund();
        }

        
    }
}
