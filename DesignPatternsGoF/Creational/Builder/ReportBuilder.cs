namespace DesignPatternsGoF.Creational.Builder
{
    public class ReportBuilder
    {
        private string title;
        private string author;
        private string conclusion;
        public List<ReportSection> sections;

        public ReportBuilder SetTitle(string title)
        {
            this.title = title;
            return this;
        }

        public ReportBuilder SetAuthor(string author)
        {
            this.author = author;
            return this;
        }

        public ReportBuilder SetConclusion(string conclusion)
        {
            this.conclusion = conclusion;
            return this;
        }

        public ReportBuilder SetSections(List<ReportSection> sections)
        {
            this.sections = sections;
            return this;
        }

        public Report BuildReport()
        { 
            return new Report(title, author, conclusion, sections);
        }
    }
}
