using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookService.Models
{
    public class BookDetailDTO
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public String AuthorName { get; set; }
        public String Genre { get; set; }
    }
}