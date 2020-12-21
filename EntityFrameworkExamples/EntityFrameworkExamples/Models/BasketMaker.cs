namespace EntityFrameworkExamples.Models
{
    using System.Collections.Generic;

    public class BasketMaker
    {
        public List<FruitBasket> FruitBaskets { get; set; } = new();
        public int ID { get; set; }
    }
}
