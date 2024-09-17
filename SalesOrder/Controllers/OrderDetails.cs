using Microsoft.AspNetCore.Mvc;
using SalesOrder.Data;


namespace SalesOrder.Controllers
{
    [ApiController]
    [Route("api/orderdetails")]
    public class OrderDetails : ControllerBase
    {

        [HttpGet("{orderNumber}")]
        public IActionResult Orderdetails(string orderNumber) {
           
            return Ok("sdalfkjsdh"); 
        }
    }
}
