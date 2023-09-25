namespace DesignPatternsGoF.Creational.FactoryMethod
{
    public class CsvParser : IFileParser
    {
        public void ParseFile(string filePath)
        {
            Console.WriteLine($"Parsing CSV file {filePath}");
        }
    }
}
