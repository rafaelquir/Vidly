using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
       
        public Genre Genre { get; set; }
        [Required]
        [Display (Name = "Genero")]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }
        [Display(Name = "Día de Entrega")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Numero de existencia")]
        public byte NumberInStock { get; set; }
    }
}