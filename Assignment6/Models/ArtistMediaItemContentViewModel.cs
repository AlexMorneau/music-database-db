using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class ArtistMediaItemContentViewModel
    {
        // for rendering a range of media alongside an artist
        // this gets stored as a collection in ArtistWithMediaInfoViewModel
        public int Id { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
    }
}