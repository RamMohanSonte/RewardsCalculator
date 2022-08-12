using System;
using System.Collections.Generic;

namespace RewardsCalculator.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public int TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
