namespace EntityFrameworkExamples.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class FruitBasket
    {
        public string Banana { get; set; } = string.Empty;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Pear { get; set; } = string.Empty;
        public string? Zucchini { get; set; } = string.Empty;
    }
}
