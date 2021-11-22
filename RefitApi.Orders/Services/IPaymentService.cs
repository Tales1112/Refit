using Refit;
using RefitApi.Orders.Models;
using System.Threading.Tasks;

namespace RefitApi.Orders.Services
{
    public interface IPaymentService
    {
        [Post("api/payments")]
        Task<ProcessPaymentResultViewModel> Process(ProcessPaymentInputModel processPaymentInputModel);
        [Get("/api/payments/{id}")]
        Task<PaymentDataViewModel> GetData([AliasAs("id")] int paymentId);
    }
}
