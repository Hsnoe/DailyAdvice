﻿namespace DailyAdvice.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public DateTime Created { get; set; }
        
        public string ImageUrl { get; set; }

        public int BookRate { get; set; }

        public string BookComment { get; set; }
    }
}
