using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
public class Movie
{

    public int Id { get; set; }

    [Required, DataType(DataType.Text), StringLength(30, MinimumLength = 3)]
    public string Title { get; set; }

    [Required, DataType(DataType.Date), Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; }

    [Required, DataType(DataType.Currency), Range(1, 1000), Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    [Required, DataType(DataType.Text), StringLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    public string Genre { get; set; }


    [Required, DataType(DataType.Text), StringLength(5), RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    public string Rating { get; set; }
}
}
