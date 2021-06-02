using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CinemaWebApp.Models
{
    public partial class Фильм
    {
        [Display(Name = "Код фильма")]
        public long КодФильма { get; set; }
        public string Наименование { get; set; }
        public double Длительность { get; set; }
        [Display(Name = "Кинокомпания")]
        public string ФирмаПроизводитель { get; set; }
        [Display(Name = "Страна")]
        public string СтранаПроизводитель { get; set; }
        public string Актёры { get; set; }
        [Display(Name = "Ограничения")]
        public string ВозрастныеОграничения { get; set; }
        public string Описание { get; set; }

        [Display(Name = "Код жанра")]
        public long КодЖанра { get; set; }

        [Display(Name = "Код жанра")]
        public virtual Жанр КодЖанраNavigation { get; set; }
    }
}
