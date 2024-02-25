namespace BasketMvc.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public required Product Product { get; set; }
    }
}
