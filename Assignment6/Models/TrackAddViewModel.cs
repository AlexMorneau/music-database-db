using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment6.Models
{
    public class TrackAddViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        [Required, StringLength(500)]
        public string Composers { get; set; }

        [Range(1, Int32.MaxValue)]
        public int TrackGenreId { get; set; }

        [Required]
        public HttpPostedFileBase AudioUpload { get; set; }
    }
}