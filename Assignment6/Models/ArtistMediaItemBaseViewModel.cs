using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class ArtistMediaItemBaseViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Date Added")]
        public DateTime Timestamp { get; set; }

        [Display(Name = "Unique Identifier")]
        [Required, StringLength(100)]
        public string StringId { get; set; }

        // AM92: include content type (p.15)
        [StringLength(200)]
        public string ContentType { get; set; }

        [Display(Name = "Description")]
        [Required, StringLength(100)]
        public string Caption { get; set; }
    }
}