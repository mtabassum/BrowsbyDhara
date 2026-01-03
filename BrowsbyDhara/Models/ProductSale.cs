namespace BrowsbyDhara.Models
{
    public class ProductSale
    {
        public int ProductSaleId { get; set; } // PK
        public int ProductId { get; set; } // FK
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }

     
        public Product Product { get; set; }
    }
}
