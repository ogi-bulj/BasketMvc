﻿namespace BasketMvc.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Rating>? Ratings { get; set; }
    }
}
