namespace _02_Report_DIP;

public interface IGenerateReporte
{
    public void Generate();
}
public class WordReportGenerator : IGenerateReporte
{
    public void Generate()
    {
        Console.WriteLine("Word report generated");
    }
}
public class ExcelReportGenerator : IGenerateReporte
{
    public void Generate()
    {
        Console.WriteLine("Excel report generated");
    }
}
public class CrystalReportGenerator : IGenerateReporte
{
    public void Generate()
    {
        Console.WriteLine("Crystal report generated");
    }
}
public class PdfReportGenerator : IGenerateReporte
{
    public void Generate()
    {
        Console.WriteLine("PDF report generated");
    }
}
public class ReportGenerator
{
    IGenerateReporte _pdfReportGenerator;
    public ReportGenerator(IGenerateReporte Generator)
    {
        _pdfReportGenerator = Generator;
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
        ReportGenerator reportGenerator= new (new PdfReportGenerator());
        reportGenerator.Generate();

        reportGenerator= new (new WordReportGenerator());
        reportGenerator.Generate();

        reportGenerator= new (new ExcelReportGenerator());
        reportGenerator.Generate();

        reportGenerator= new (new CrystalReportGenerator());
        reportGenerator.Generate();
    }
}
