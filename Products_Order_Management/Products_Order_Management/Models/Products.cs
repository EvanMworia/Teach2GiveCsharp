namespace Products_Order_Management.Models
{
    public class Products
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }

        //To check if stock of product is available, if not no orders should be accepted
        public int StockCount { get; set; }

        public List<Orders> OrderList { get; set; }= new List<Orders>();

    }
}
