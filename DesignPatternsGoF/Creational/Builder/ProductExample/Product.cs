namespace DesignPatternsGoF.Creational.Builder.ProductExample
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool IsDiscounted { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Category}) - Price: {Price:C} {(IsDiscounted ? "(Discounted)" : "")}";
        }
    }
}
