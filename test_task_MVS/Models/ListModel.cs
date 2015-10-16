using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_task_MVS.Models
{
    public class ListModel
    {
        [ScaffoldColumn(false)]
        [Key]
        public int applicationId { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Ф.И.О")]
        public virtual string full_name { get; set; }

        [Required(ErrorMessage = "Укажите свой email адрес")]
        [Display(Name = "Ваш mail:")]
        public string mail { get; set; }

        [Display(Name = "Введите свой номер телефона")]
        public string fone { get; set; }

        [Required(ErrorMessage = "Укажите на какую должность вы претиндуите!")]
        [Display(Name = "Желаемая должность")]
        public string vacancy { get; set; }
        
        [Display(Name = "Опыт работы")]
        public string experience { get; set; }

        [Required(ErrorMessage = "Укажите ваши профессиональные навыки")]
        [Display(Name = "Ваши профессиональные навыки")]
        public string professional_skills { get; set; }
        
        [Display(Name = "Ваши личные качества")]
        public string personal_qualities { get; set; }
    }
}