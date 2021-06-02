using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CinemaWebApp.Models
{
    public partial class Репертуар
    {
        public Репертуар()
        {
            Местоs = new HashSet<Место>();
        }

        [Display(Name = "Код сеанса")]
        public long КодСеанса { get; set; }
        public DateTime Дата { get; set; }

        [Display(Name = "Начало")]
        public DateTime ВремяНачала { get; set; }

        [Display(Name = "Конец")]
        public DateTime ВремяОкончания { get; set; }
        [Display(Name = "Цена билета")]
        public double ЦенаБилета { get; set; }

        [Display(Name = "Места")]
        public virtual ICollection<Место> Местоs { get; set; }
    }
}
