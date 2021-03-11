using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Book
    {
        //Declare attributes
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        public string AuthorMiddle { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [RegularExpression(@"^[0-9]{3}-[0-9]{10}", ErrorMessage = "Your ISBN is incorrect")]
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Page { get; set; }
       
    }
}
