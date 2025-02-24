Imports System.Drawing
Imports DevExpress.Pdf

Namespace AddLinkToPage

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                ' Load a document
                processor.LoadDocument("Demo.pdf")

                ' Access third page properties
                Dim pageFacade As PdfPageFacade = processor.DocumentFacade.Pages(2)

                ' Create a Fit destination that refers to the third page
                Dim destination As PdfFitDestination = pageFacade.CreateFitDestination()

                ' Find a specific phrase
                Dim linkText As String = "JBIG2 images"
                Dim linkSearchResults As PdfTextSearchResults = processor.FindText(linkText)

                ' If the phrase is found, obtain its bounding rectangle
                If linkSearchResults.Status = PdfTextSearchStatus.Found Then
                    Dim linkRectangle As PdfRectangle = linkSearchResults.Rectangles(0).BoundingRectangle

                    ' Access first page properties
                    Dim linkPageFacade As PdfPageFacade = processor.DocumentFacade.Pages(linkSearchResults.PageNumber - 1)

                    'Create a link annotation associated with the bounding rectangle
                    ' and destination
                    Dim linkAnnotation As PdfLinkAnnotationFacade = linkPageFacade.AddLinkAnnotation(linkRectangle, destination)
                    linkAnnotation.HighlightMode = PdfAnnotationHighlightingMode.Push
                End If
                ' Save the result
                processor.SaveDocument("out.pdf")
            End Using
            Process.Start(New ProcessStartInfo("out.pdf") With {.UseShellExecute = True})
        End Sub

    End Class
End Namespace
