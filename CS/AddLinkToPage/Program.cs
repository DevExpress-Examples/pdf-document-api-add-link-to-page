using DevExpress.Pdf;
using System.Diagnostics;
using System.Drawing;


namespace AddLinkToPage {
    class Program {
        static void Main(string[] args) {
            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor()) {
                // Load a document
                pdfDocumentProcessor.LoadDocument("..\\..\\..\\Document.pdf");

                // Access third page properties
                PdfPageFacade pageFacade = pdfDocumentProcessor.DocumentFacade.Pages[2];

                // Create a Fit destination that refers to the third page
                PdfFitDestination destination = pageFacade.CreateFitDestination();

                // Find a specific phrase
                string linkText = "JBIG2 images";
                PdfTextSearchResults linkSearchResults = pdfDocumentProcessor.FindText(linkText);

                // If the phrase is found, obtain its bounding rectangle
                if (linkSearchResults.Status == PdfTextSearchStatus.Found)
                {
                    PdfRectangle linkRectangle = linkSearchResults.Rectangles[0].BoundingRectangle;

                    // Access first page properties
                    PdfPageFacade linkPageFacade =
                       pdfDocumentProcessor.DocumentFacade.Pages[linkSearchResults.PageNumber - 1];

                    // Create a link annotation associated with the bounding rectangle
                    // and destination
                    PdfLinkAnnotationFacade linkAnnotation =
                        linkPageFacade.AddLinkAnnotation(linkRectangle, destination);
                    linkAnnotation.HighlightMode = PdfAnnotationHighlightingMode.Push;
                }
                // Save the result
                pdfDocumentProcessor.SaveDocument("out.pdf");
            }
            Process.Start(new ProcessStartInfo("out.pdf") { UseShellExecute = true });
        }

    }
}
