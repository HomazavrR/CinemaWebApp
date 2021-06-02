using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CinemaWebApp.Models
{
    public partial class Должность
    {
        public Должность()
        {
            Сотрудникs = new HashSet<Сотрудник>();
        }

        [Display(Name = "Код должности")]
        public long КодДолжности { get; set; }
        [Display(Name = "Название")]
        public string НаименованиеДолжности { get; set; }
        
        public double Оклад { get; set; }
        public string Обязанности { get; set; }
        public string Требования { get; set; }

        public virtual ICollection<Сотрудник> Сотрудникs { get; set; }
    }
}
