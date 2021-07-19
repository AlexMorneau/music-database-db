using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class ArtistMediaItemAddFormViewModel
    {
        public int Id { get; set; }

        // user fills caption in form

        [Display(Name = "Descriptive Caption")]
        [Required, StringLength(100)]
        public string Caption { get; set; }


        public int ArtistId { get; set; }

        public string ArtistName { get; set; }

        // user uploads media item

        [Required]
        [Display(Name = "Media Item")]
        [DataType(DataType.Upload)]
        public string MediaUpload { get; set; }
    }
}