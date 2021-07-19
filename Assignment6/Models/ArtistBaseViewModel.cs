using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class ArtistBaseViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Artist Name or Stage Name")]
        [Required, StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "If applicable, Artist's Birth Name")]
        [StringLength(100)]
        public string BirthName { get; set; }

        [Display(Name = "Birth Date or Start Date")]
        public DateTime BirthOrStartDate { get; set; }

        [Display(Name = "Artist Photo")]
        [Required, StringLength(200)]
        public string UrlArtist { get; set; }

        // AM92: not used in get all use case
        public string Biography { get; set; }

        [Display(Name = "Artist's Primary Genre")]
        [Required]
        public string Genre { get; set; }

        [Required, StringLength(200)]
        public string Executive { get; set; }
    }
}