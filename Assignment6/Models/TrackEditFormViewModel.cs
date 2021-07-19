using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class TrackEditFormViewModel
    {
        // for editing just the audio clip of the track

        [Display(Name = "Track Name")]
        [Required, StringLength(200)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Sample Audio Clip")]
        [DataType(DataType.Upload)]
        public string AudioUpload { get; set; }
    }
}