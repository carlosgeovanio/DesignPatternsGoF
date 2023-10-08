namespace DesignPatternsGoF.Creational.FactoryMethod
{
    public class MonthlyReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating Monthly Report...");
        }
    }
}
