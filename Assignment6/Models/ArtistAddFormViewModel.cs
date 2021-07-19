using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment6.Models
{
    public class ArtistAddFormViewModel
    {
        [Display(Name = "Artist Name or Stage Name")]
        [Required, StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "If applicable, Artist's Birth Name")]
        [StringLength(100)]
        public string BirthName { get; set; }

        [Display(Name = "Birth Date or Start Date")]
        public DateTime BirthOrStartDate { get; set; }

        [Display(Name = "Url to the Artist's Photo")]
        [Required, StringLength(200)]
        public string UrlArtist { get; set; }

        // rich text
        [DataType(DataType.MultilineText)]
        public string Biography { get; set; }

        [Display(Name = "Artist's Primary Genre")]
        public SelectList GenreList { get; set; }

        //public string Executive { get; set; }
    }
}