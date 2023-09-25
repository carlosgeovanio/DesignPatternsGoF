namespace DesignPatternsGoF.Creational.Builder
{
    public class Report
    {
        public string ReportTitle { get; private set; }
        public string Author { get; private set; }
        public DateTime CreationDate { get; private set; }
        public string Conclusion { get; private set; }
        public List<ReportSection> Sections { get; private set; }

        public Report(string title, string author, string conclusion, List<ReportSection> sections)
        {
            ReportTitle = title;
            Author = author;
            CreationDate = DateTime.Now;
            Conclusion  = conclusion;
            Sections = sections;
        }

        public void DisplayReport()
        {
            Console.WriteLine("Report Title: " + ReportTitle);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Creation Date: " + CreationDate);
            Console.WriteLine("Conclusion: " + Conclusion);

            Console.WriteLine("Report Sections:");
            foreach (var section in Sections)
            {
                Console.WriteLine($"--- Section: {section.SectionTitle} ---");
                Console.WriteLine(section.SectionContent);
            }
        }
    }
}
