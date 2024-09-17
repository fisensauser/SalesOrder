using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesOrder.Models
{
    public class OrderType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrderTypeID")]
        public Int64 Id { get; set; }

        [Column("OrderTypeName")]
        public string? OrderTypeName { get; set; }




    }
}
