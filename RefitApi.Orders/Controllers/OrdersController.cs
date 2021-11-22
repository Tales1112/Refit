using Microsoft.AspNetCore.Mvc;
using RefitApi.Orders.Models;
using RefitApi.Orders.Services;
using System.Threading.Tasks;

namespace RefitApi.Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public OrdersController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [HttpGet("{orderId}/payments/{id}")]
        public async Task<IActionResult> GetPayment(int orderId, int id)
        {
            var result = await _paymentService.GetData(id);

            return Ok(result);
        }

        [HttpPost("{orderId}/payments")]
        public async Task<IActionResult> Create(int orderId, [FromBody] ProcessPaymentInputModel processPaymentInputModel)
        {
            var result = await _paymentService.Process(processPaymentInputModel);

            if (!result.Success)
            {
                return BadRequest(result.Errors);
            }

            return CreatedAtAction(nameof(GetPayment), new { orderId, id = result.IdPayment }, result);
        }

    }
}
