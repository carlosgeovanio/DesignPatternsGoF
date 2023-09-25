namespace DesignPatternsGoF.Creational.FactoryMethod
{
    public class XmlParser : IFileParser
    {
        public void ParseFile(string filePath)
        {
            Console.WriteLine($"Parsing XML file {filePath}");
        }
    }
}
