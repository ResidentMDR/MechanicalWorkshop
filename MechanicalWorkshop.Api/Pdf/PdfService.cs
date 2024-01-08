using Microsoft.Win32;
using QuestPDF.Fluent;
using System.Diagnostics;

namespace MechanicalWorkshop.Api.Pdf
{
    public class PdfService
    {
        public static void GetExamplePdf()
        {
            var filePath = @"C:\Users\marci\Downloads\SamplePdf.pdf";
            //var filePath = GetDownloadFolderPath();

            var model = InvoiceDocumentDataSource.GetInvoiceDetails();
            var document = new InvoiceDocument(model);
            document.GeneratePdf(filePath);

            Process.Start("explorer.exe", filePath);
        }

        private static string GetDownloadFolderPath()
        {
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
        }
    }
}
