using System;
using System.ComponentModel.DataAnnotations;

namespace Movies.ViewModel
{
    public class MovieViewModel
    {
        public int Id{ get; set; }
        [Required, MaxLength(200, ErrorMessage = "The length is very long")]
        public string Title { get; set; }

        [Required, MaxLength(350, ErrorMessage = "The length is very long")]
        public string Description { get; set; }

        [Required, MaxLength(100, ErrorMessage = "The length is very long")]
        public string Genre { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        [Required]
        public byte[]? Poster { get; set; }


        public int? Like { get; set; }
        public int? Dislike { get; set; }
    }
}
