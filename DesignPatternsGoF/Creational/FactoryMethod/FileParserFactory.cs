namespace DesignPatternsGoF.Creational.FactoryMethod
{
    public static class FileParserFactory
    {
        public static IFileParser CreateFileParser(string fileType)
        {
            switch (fileType)
            {
                case "json":
                    return new JsonParser();
                case "xml":
                    return new XmlParser();
                case "csv":
                    return new CsvParser();
                default:
                    throw new ArgumentException("File type not supported.");
            }
        }
    }
}
