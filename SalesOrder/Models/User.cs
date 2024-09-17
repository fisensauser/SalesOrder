using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesOrder.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("userID")]
        public Int64 Id { get; set; }

        [Column("username")]
        public string? UserName { get; set; }

        [Column("password")]
        public string? Password { get; set; }

        [Column("role")]
        public string? Role {  get; set; }
    }
    //

}
