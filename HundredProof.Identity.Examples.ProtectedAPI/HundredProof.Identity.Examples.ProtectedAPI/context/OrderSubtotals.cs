using System;
using System.Collections.Generic;

namespace HundredProof.Identity.Examples.ProtectedAPI.context
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
