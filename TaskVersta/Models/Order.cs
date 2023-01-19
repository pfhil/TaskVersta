using System.ComponentModel.DataAnnotations;

namespace TaskVersta.Models
{
    public class Order
    {
        [Display(Name = "Номер заказа")]
        public int Id { get; set; }

        [Display(Name = "Город отправителя")]
        public string SenderCity { get; set; }

        [Display(Name = "Адрес отправителя")]
        public string SenderAddress { get; set; }

        [Display(Name = "Город получателя")]
        public string RecipientCity { get; set; }

        [Display(Name = "Адрес получателя")]
        public string RecipientAddress { get; set; }

        [Display(Name = "Вес груза")]
        public double CargoWeight { get; set; }

        [Display(Name = "Дата забора груза")]
        [DataType(DataType.Date)]
        public DateOnly DateCargoPickup { get; set; }
    }
}
