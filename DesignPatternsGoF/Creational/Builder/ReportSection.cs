namespace DesignPatternsGoF.Creational.Builder
{
    // Represents a section in the report
    public class ReportSection
    {
        public string SectionTitle { get; private set; }
        public string SectionContent { get; private set; }

        public ReportSection(string title, string content)
        {
            SectionTitle = title;
            SectionContent = content;
        }
    }
}
