using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment6.Models
{
    public class TrackAddFormViewModel
    {
        [Display(Name = "Track Name")]
        [Required, StringLength(200)]
        public string Name { get; set; }

        [Display(Name = "Composer Names (comma-separated)")]
        [Required, StringLength(500)]
        public string Composers { get; set; }

        [Display(Name = "Track Genre")]
        public SelectList GenreList { get; set; }


        // associated album details
        public int AlbumId { get; set; }

        public string AlbumName { get; set; }


        [Required]
        [Display(Name = "Sample Audio Clip")]
        [DataType(DataType.Upload)]
        public string AudioUpload { get; set; }
    }
}