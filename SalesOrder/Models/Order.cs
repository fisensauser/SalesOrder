using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesOrder.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrderID")]
        public Int64 OrderId { get; set; }

        [Column("OrderNumber")]
        public string? OrderNumber { get; set; }

        [Column("OrderTypeID")]
        public Int64? OrderTypeID { get; set; }
        [Column("OrderStatusID")]
        public Int32? OrderStatusID { get; set; }
        [Column("CustomerName")]
        public string? CustomerName { get; set; }
        [Column("OrderDate")]
        public DateTime? OrderDate { get; set; }
    }

}
