using System.Collections.Generic;

namespace RefitApi.Orders.Models
{
    public class ProcessPaymentResultViewModel
    {
        public int IdPayment { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
