namespace Domain.ingredients
{
    public class Ingredient
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { set; get; }
        public double Quantity { set; get; }
        public string Measure { set; get; }
        public string Name { set; get; }
    }
}