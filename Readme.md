<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595263/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T494761)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/AddLinkToPage/Program.cs) (VB: [Program.vb](./VB/AddLinkToPage/Program.vb))
<!-- default file list end -->
# PDF Document API - Add a Link to a Page


This example shows the PDF Document Creation API that is used to programmatically add a link to a page.<br><br>The Universal Subscription or an additional Office File API Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information.


<h3>Description</h3>

To add a link to a page using the PDF Creation API:<br>-&nbsp; Create an empty document with no pages by calling one of the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_CreateEmptyDocumenttopic(FQQ7tw)">PdfDocumentProcessor.CreateEmptyDocument</a> overload methods). <br>- Create PDF graphics represented by an instance of the PdfGraphics class calling the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_CreateGraphicstopic">PdfDocumentProcessor.CreateGraphics </a>method. To access <strong>PdfGraphics</strong> you need to reference the <strong>DevExpress.Pdf.Drawing</strong> assembly. <br>- Add a link to the PDF page using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfGraphics_AddLinkToPagetopic">PdfGraphics.AddLinkToPage </a>method.<br>- Render a page with created graphics by calling the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_RenderNewPagetopic">PdfDocumentProcessor.RenderNewPage</a> method.

<br/>


