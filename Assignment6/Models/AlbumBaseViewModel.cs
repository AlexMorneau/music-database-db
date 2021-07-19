using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class AlbumBaseViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Album Name")]
        [Required, StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Album Cover Art")]
        [Required, StringLength(200)]
        public string UrlAlbum { get; set; }

        [Display(Name = "Album's Primary Genre")]
        [Required]
        public string Genre { get; set; }

        // lengthy - not used in get all use case
        public string Summary { get; set; }

        [Required, StringLength(200)]
        public string Coordinator { get; set; }
    }
}