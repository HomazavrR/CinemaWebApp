using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CinemaWebApp.Models
{
    public partial class Жанр
    {
        public Жанр()
        {
            Фильмs = new HashSet<Фильм>();
        }

        [Display(Name = "Код жанра")]
        public long КодЖанра { get; set; }
        [Display(Name = "Название")]
        public string Наименование { get; set; }
        public string Описание { get; set; }


        [Display(Name = "Фильмы")]
        public virtual ICollection<Фильм> Фильмs { get; set; }
    }
}
