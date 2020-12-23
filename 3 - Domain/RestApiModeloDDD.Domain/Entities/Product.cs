namespace RestApiModeloDDD.Domain.Entities
{
    public class Product : Base
    {
        public string Title { get; set; }        
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal AmountStock { get; set; }
        public bool HasStock { get; set; }
    }
}