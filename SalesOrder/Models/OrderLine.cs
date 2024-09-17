using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesOrder.Models
{
    public class OrderLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrderLineID")]
        public Int64 OrderLineId { get; set; }

        [Column("OrderID")]
        public Int64 OrderId { get; set; }
        
        [Column("LineNumber")]
        public int LineNumber { get; set; }

        [Column("ProductCode")]
        public string? ProductCode { get; set; }
        [Column("ProductTypeID")]
        public int ProductTypeId { get; set; }

        [Column("ProductCostP")]
        public Int64 ProductCostP { get; set; }
        [Column("ProductSalesP")]
        public Int64 ProductSalesP { get; set; }
        [Column("Quantity")]
        public string? Quantity { get; set; }
    }
}
