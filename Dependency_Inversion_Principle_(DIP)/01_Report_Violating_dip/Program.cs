namespace _01_Report_Violating_dip
{
    public class PdfReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("PDF report generated");
        }
    }
    public class ReportGenerator
    {
        PdfReportGenerator _pdfReportGenerator;

        public ReportGenerator()
        {
            _pdfReportGenerator = new PdfReportGenerator();
        }
        public void Generate()
        {
            _pdfReportGenerator.Generate();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator reportGenerator= new ();
            reportGenerator.Generate();

        }
    }
}
