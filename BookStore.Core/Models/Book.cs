using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models
{
    public class Book
    {
        public const int TITLE_MAX_LENGTH = 250;
        public const int DESCRIPTION_MAX_LENGTH = 500;

        //Здесь реализуется бизнес логика, поэтому у нас нет сеттеров
        public Guid Id { get; }
        public string Title { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public decimal Price { get; }

        private Book(Guid id, string title, string description, decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }   

        public static (Book Book, string error) Create(Guid id, string title, string desc, decimal price)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrEmpty(title) || title.Length > TITLE_MAX_LENGTH)
            {
                error.Append("Title shouldn't be empty or more than 250 symbols\n");
            }

            if (string.IsNullOrEmpty(desc) || desc.Length > DESCRIPTION_MAX_LENGTH)
            {
                error.Append("Description shouldn't be empty or more than 500 symbols\n");
            }

            if (price < 0)
            {
                error.Append("Price sholdn't be less than zero");
            }
            
            var book = new Book(id, title, desc, price);

            return (book, error.ToString());
        }
    }
}
