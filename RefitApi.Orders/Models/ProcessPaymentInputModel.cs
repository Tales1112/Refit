namespace RefitApi.Orders.Models
{
    public class ProcessPaymentInputModel
    {
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public string CreditCardAmount { get; set; }
        public string CVV { get; set; }
    }
}
