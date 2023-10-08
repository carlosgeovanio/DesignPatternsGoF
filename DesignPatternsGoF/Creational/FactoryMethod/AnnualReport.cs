namespace DesignPatternsGoF.Creational.FactoryMethod
{
    public class AnnualReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating Annual Report...");
        }
    }
}
