using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Nu_iMero.Services
{
    public class ReportService
    {
        public byte[] GenerateSampleReport()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Create a PDF writer bound to the memory stream
                PdfWriter writer = new PdfWriter(memoryStream);

                // Create a PDF document bound to the writer
                PdfDocument pdfDocument = new PdfDocument(writer);

                // Create a document to add content to the PDF
                Document document = new Document(pdfDocument);

                // Add content to the PDF
                document.Add(new Paragraph("Sample Report").SetFontSize(20));
                document.Add(new Paragraph("This is a simple PDF report generated using iText7."));

                // Close the document
                document.Close();

                // Return the generated PDF as a byte array
                return memoryStream.ToArray();
            }
        }
    }
}
