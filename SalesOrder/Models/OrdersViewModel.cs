namespace SalesOrder.Models
{
    public class OrdersViewModel
    {

        public Order? Order { get; set; }
        public List<OrderLine>? OrderLines { get; set; }

    }
}
