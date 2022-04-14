Imports DevExpress.Pdf
Imports System.Drawing

Namespace AddLinkToPage

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                ' Create an empty document.
                processor.CreateEmptyDocument("..\..\Result.pdf")
                ' Create a PdfGraphics class instance.
                Using graphics As PdfGraphics = processor.CreateGraphics()
                    ' Draw link text.
                    Dim black As SolidBrush = CType(Brushes.Black, SolidBrush)
                    Using font As Font = New Font("Times New Roman", 32, FontStyle.Bold)
                        graphics.DrawString("PDF Document API", font, black, 180, 150)
                    End Using

                    ' Create a link to the second document page.
                    ' Specify the page destination to which the link should refer.
                    graphics.AddLinkToPage(New RectangleF(180, 160, 480, 30), 2, 168, 230)
                    ' Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graphics)
                    ' Create the second document page to which the link navigates.
                    processor.AddNewPage(PdfPaperSize.A4)
                End Using
            End Using
        End Sub
    End Class
End Namespace
