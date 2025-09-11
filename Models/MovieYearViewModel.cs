using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class MovieYearViewModel
    {
        [Range(1900, 2100, ErrorMessage = "Please enter a valid year between 1900 and 2100.")]
        public int? Year { get; set; }
    }
}