using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CinemaWebApp.Models
{
    public partial class Сотрудник
    {
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        [Display(Name = "Паспортные данные")]
        public string ПаспортныеДанные { get; set; }
        public string Пол { get; set; }
        [Display(Name = "Код сотрудника")]
        public long КодСотрудника { get; set; }
        public string Фио { get; set; }
        public long Возраст { get; set; }

        [Display(Name = "Код должности")]
        public long КодДолжности { get; set; }

        [Display(Name = "Код должности")]
        public virtual Должность КодДолжностиNavigation { get; set; }
    }
}
