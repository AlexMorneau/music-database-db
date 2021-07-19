using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class ArtistAddViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string BirthName { get; set; }

        public DateTime BirthOrStartDate { get; set; }

        [Required, StringLength(200)]
        public string UrlArtist { get; set; }

        public string Biography { get; set; }

        public string Genre { get; set; }

        public string Executive { get; set; }

        [Range(1, Int32.MaxValue)]
        public int ArtistGenreId { get; set; }
    }
}