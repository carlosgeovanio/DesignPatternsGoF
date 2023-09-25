namespace DesignPatternsGoF.Creational.FactoryMethod
{
    public class JsonParser : IFileParser
    {
        public void ParseFile(string filePath)
        {
            Console.WriteLine($"Parsing JSON file {filePath}");
        }
    }
}
