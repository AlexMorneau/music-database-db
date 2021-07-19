using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class TrackBaseViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Track Name")]
        [Required, StringLength(200)]
        public string Name { get; set; }

        // Simple comma-separated string of all the track's composers
        [Display(Name = "Composer Names")]
        [Required, StringLength(500)]
        public string Composers { get; set; }


        [Display(Name = "Sample Clip")]
        public string AudioUrl
        {
            get
            {
                return $"/audio/{Id}";
            }
        }


        // User name who added/edited the track
        public string Clerk { get; set; }
    }
}