using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieDirectorApp.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        public string Type { get; set; }

        //Navagation Property
        public virtual ICollection<Movie> Movies { get; set; }
    }
}