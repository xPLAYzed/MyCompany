using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните объявление")]
        [Display(Name = "Марка Авто")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание авто")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание авто")]
        public override string Text { get; set; }
    }
}
