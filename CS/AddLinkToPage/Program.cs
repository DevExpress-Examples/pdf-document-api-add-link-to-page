using DevExpress.Pdf;
using System.Drawing;


namespace AddLinkToPage
{
    class Program
    {
        static void Main(string[] args)
        {            

            using (PdfDocumentProcessor processor = new PdfDocumentProcessor())
            {
                // Create an empty document.
                processor.CreateEmptyDocument("..\\..\\Result.pdf");

                // Create a PdfGraphics class instance.
                using (PdfGraphics graphics = processor.CreateGraphics())
                {
                    // Draw link text.
                    SolidBrush black = (SolidBrush)Brushes.Black;
                    using (Font font = new Font("Times New Roman", 32, FontStyle.Bold))
                    {
                        graphics.DrawString("PDF Document API", font, black, 180, 150);
                    }

                    // Create a link to the second document page.
                    // Specify the page destination to which the link should refer.
                    graphics.AddLinkToPage(new RectangleF(180, 160, 480, 30), 2, 168, 230);

                    // Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graphics);

                    // Create the second document page to which the link navigates.
                    processor.AddNewPage(PdfPaperSize.A4);
                }
            }
        }
    }
}
