using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {

        public int Id { get; set; }
        [Required, StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Title { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "yyyy-MM-dd")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Range(1, 1000), Required]
        public decimal Price { get; set; }
    }
}
