using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CinemaWebApp.Models
{
    public partial class Место
    {
        [Display(Name = "Номер места")]
        public long НомерМеста { get; set; }
        public string Занятость { get; set; }
        [Display(Name = "Код сотрудника")]
        public long КодСотрудника { get; set; }

        [Display(Name = "Код сеанса")]
        public long КодСеанса { get; set; }

        [Display(Name = "Код сеанса")]
        public virtual Репертуар КодСеансаNavigation { get; set; }
    }
}
