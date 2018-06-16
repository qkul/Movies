using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies; // list movies
        public SelectList genres; // В этом списке пользователь может выбрать жанр фильма.
        public string movieGenre { get; set; }// соержит выбранный жанр
    }
}
