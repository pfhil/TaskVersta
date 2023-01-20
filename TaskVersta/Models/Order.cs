using System.ComponentModel.DataAnnotations;

namespace TaskVersta.Models
{
    public class Order
    {
        [Display(Name = "Номер заказа")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public int Id { get; set; }

        [Display(Name = "Город отправителя")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string SenderCity { get; set; }

        [Display(Name = "Адрес отправителя")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string SenderAddress { get; set; }

        [Display(Name = "Город получателя")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string RecipientCity { get; set; }

        [Display(Name = "Адрес получателя")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string RecipientAddress { get; set; }

        [Display(Name = "Вес груза")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Range(0, int.MaxValue, ErrorMessage = "{0} должен быть не меньше {1} и не больше {2}")]
        public double CargoWeight { get; set; }

        [Display(Name = "Дата забора груза")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [DataType(DataType.Date)]
        public DateOnly DateCargoPickup { get; set; }
    }
}
