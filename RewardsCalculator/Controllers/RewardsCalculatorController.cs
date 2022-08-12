using Microsoft.AspNetCore.Mvc;
using RewardsCalculator.Models;

namespace RewardsCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RewardsCalculatorController : ControllerBase
    {
        [HttpGet(Name = "RewardsCalculator")]
        public int? Get(int customerid)
        {
            using (var context = new TestContext())
            {
                var transactions = context.Transactions.Where(x => x.CustomerId == customerid && x.TransactionDate >= DateTime.Today.AddDays(-90)).ToList();
                return CalulateRewards(transactions);
            }
        }

        private int? CalulateRewards(List<Transaction> transaction)
        {
            int? rewards=0;
            foreach (var singletransaction in transaction)
            {
                if (singletransaction.TransactionAmount>=50 && singletransaction.TransactionAmount<100)
                {
                     rewards += ((singletransaction.TransactionAmount - 50) * 1);
                }
                else if (singletransaction.TransactionAmount > 100)
                {
                     rewards += ((singletransaction.TransactionAmount - 50) * 1) + ((singletransaction.TransactionAmount - 100) * 1);

                }
                else
                {
                    rewards += 0;
                }
            }
            return rewards;
        }
    }
}