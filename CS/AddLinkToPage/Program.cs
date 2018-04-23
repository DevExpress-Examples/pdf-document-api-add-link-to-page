using DevExpress.Pdf;
using System.Drawing;


namespace AddLinkToPage {
    class Program {
        static void Main(string[] args) {
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {

                // Create an empty document.
                processor.CreateEmptyDocument("..\\..\\Result.pdf");

                // Create and draw graphics.
                using (PdfGraphics graphics = processor.CreateGraphics()) {
                    DrawGraphics(graphics);

                    // Create a link to a page specifying link area, the page number and X, Y destinations.
                    graphics.AddLinkToPage(new RectangleF(180, 160, 480, 30), 1, 168, 230);

                    // Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graphics);
                }
            }
        }

        static void DrawGraphics(PdfGraphics graphics) {

            // Draw a text line on the page. 
            SolidBrush black = (SolidBrush)Brushes.Black;
            using (Font font = new Font("Times New Roman", 32, FontStyle.Bold)) {
                graphics.DrawString("PDF Document Processor", font, black, 180, 150);
            }
        }
    }
}
