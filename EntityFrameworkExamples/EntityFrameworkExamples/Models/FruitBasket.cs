namespace EntityFrameworkExamples.Models
{
    using System.Collections.Generic;

    public class FruitBasket
    {
        public string Banana { get; set; } = string.Empty;

        public List<BasketMaker> BasketMakers { get; set; } = new();

        public int ID { get; set; }

        public string Pear { get; set; } = string.Empty;
    }
}
