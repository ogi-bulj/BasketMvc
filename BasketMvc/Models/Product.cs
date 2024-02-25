namespace BasketMvc.Models
{
    public class Product
    {
        public int ID { get; set; }
        public required string Naziv { get; set; }
        public decimal Cijena { get; set; }
    }
}
