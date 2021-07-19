using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class AlbumAddViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        // Get from Apple iTunes Preview, Amazon, or Wikipedia
        [Required, StringLength(200)]
        public string UrlAlbum { get; set; }

        public string Genre { get; set; }

        // lengthy
        public string Summary { get; set; }

        public string Coordinator { get; set; }

        [Range(1, Int32.MaxValue)]
        public int AlbumGenreId { get; set; }
    }
}