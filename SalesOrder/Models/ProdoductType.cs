using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesOrder.Models
{
    public class ProductType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductTypeID")]
        public Int32 Id { get; set; }

        [Column("ProductTypeName")]
        public string? ProductTypeName { get; set; }
    }
}
