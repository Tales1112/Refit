namespace RefitApis.Payments.Models
{
    public class ProcessPaymentInputModel
    {
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public string CreditCardNumber { get; set; }
        public string CVV { get; set; }
    }
}
