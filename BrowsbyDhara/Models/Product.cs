namespace BrowsbyDhara.Models
{
    public class Product
    {
        public int ProductId { get; set; } // PK
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal WholesaleCost { get; set; }
        public int QuantityInStock { get; set; }

        public ICollection<ProductSale> ProductSales { get; set; }
    }
}
