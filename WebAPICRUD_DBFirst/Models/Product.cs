namespace WebAPICRUD_DBFirst.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string ProductName { get; set;}
        public decimal Price { get; set;}
        public int CatId { get; set;}
        public DateTime Mfd { get; set; }
    }
}