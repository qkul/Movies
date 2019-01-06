using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string ImageMimeType { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
