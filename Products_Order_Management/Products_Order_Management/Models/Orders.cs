using System.ComponentModel.DataAnnotations.Schema;

namespace Products_Order_Management.Models
{
    public class Orders
    {
        public Guid Id { get; set; }

        [ForeignKey("ProductId")]
        public Products prods { get; set; } = default!;

        public Guid ProductId { get; set; }

    }
}
