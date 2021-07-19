using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment6.EntityModels
{
    public class ArtistMediaItem
    {
        public ArtistMediaItem()
        {
            Timestamp = DateTime.Now;

            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            StringId = string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        public int Id { get; set; }

        public DateTime Timestamp { get; set; }

        [Required, StringLength(100)]
        public string StringId { get; set; }

        public byte[] Content { get; set; }
        [StringLength(200)]
        public string ContentType { get; set; }

        [Required, StringLength(100)]
        public string Caption { get; set; }

        // associated to one Artist, artist has-many media items
        [Required]
        public Artist Artist { get; set; }
    }
}