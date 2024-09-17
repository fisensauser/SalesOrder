using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesOrder.Models
{
    public class OrderStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrderStatusID")]
        public Int32 Id { get; set; }

        [Column("OrderStatusDescription")]
        public string? Description { get; set; }
    }
}
