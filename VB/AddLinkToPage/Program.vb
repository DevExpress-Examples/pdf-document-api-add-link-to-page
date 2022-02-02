Imports DevExpress.Pdf
Imports System.Drawing

Namespace AddLinkToPage

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                ' Create an empty document.
                processor.CreateEmptyDocument("..\..\Result.pdf")
                ' Create and draw graphics.
                Using graphics As PdfGraphics = processor.CreateGraphics()
                    DrawGraphics(graphics)
                    ' Create a link to a page specifying link area, the page number and X, Y destinations.
                    graphics.AddLinkToPage(New RectangleF(180, 160, 480, 30), 1, 168, 230)
                    ' Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graphics)
                End Using
            End Using
        End Sub

        Private Shared Sub DrawGraphics(ByVal graphics As PdfGraphics)
            ' Draw a text line on the page. 
            Dim black As SolidBrush = CType(Brushes.Black, SolidBrush)
            Using font As Font = New Font("Times New Roman", 32, FontStyle.Bold)
                graphics.DrawString("PDF Document Processor", font, black, 180, 150)
            End Using
        End Sub
    End Class
End Namespace
