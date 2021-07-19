using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment6.Models
{
    public class AlbumAddFormViewModel
    {
        [Display(Name = "Album Name")]
        [Required, StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Url to Album Cover Art")]
        [Required, StringLength(200)]
        public string UrlAlbum { get; set; }

        [Display(Name = "Album's Primary Genre")]
        [Required]
        public SelectList GenreList { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Album Summary")]
        public string Summary { get; set; }

        // data relation - artist info

        public int ArtistId { get; set; }

        public string ArtistName { get; set; }

        //public string Coordinator { get; set; }
    }
}