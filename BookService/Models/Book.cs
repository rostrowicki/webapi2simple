using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookService.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

        // FK
        public int AuthorId { get; set; }
        // Navigation property
        // You can use the navigation property to access the related Author in code
        // public virtual Author Author { get; set; } // virtual = lazy loading - not for API guys; or DTO
        public Author Author { get; set; } // virtual = lazy loading
    }
}