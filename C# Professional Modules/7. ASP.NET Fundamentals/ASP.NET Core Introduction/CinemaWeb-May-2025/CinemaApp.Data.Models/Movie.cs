

using System.ComponentModel.DataAnnotations;
using CinemaApp.Data.Common;

namespace CinemaApp.Data.Models
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(EntityConstants.Movie.TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(EntityConstants.Movie.GenreMaxLength)]
        public string Genre { get; set; } = null!;

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(EntityConstants.Movie.DirectorMaxLength)]
        public string Director { get; set; } = null!;

        public int Duration { get; set; }

        public string Description { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
