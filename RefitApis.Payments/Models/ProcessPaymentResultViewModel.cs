using System.Collections.Generic;

namespace RefitApis.Payments.Models
{
    public class ProcessPaymentResultViewModel
    {
        public ProcessPaymentResultViewModel(int idPayment, bool success, List<string> errors)
        {
            IdPayment = idPayment;
            Success = success;
            Errors = errors;
        }
        public int IdPayment { get; private set; }
        public bool Success { get; private set; }
        public List<string> Errors { get; private set; }
    }
}
