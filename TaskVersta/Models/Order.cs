namespace TaskVersta.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string SenderCity { get; set; }

        public string SenderAddress { get; set; }

        public string RecipientCity { get; set; }

        public string RecipientAddress { get; set; }

        public double CargoWeight { get; set; }

        public DateOnly DateCargoPickup { get; set; }
    }
}
