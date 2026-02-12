<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595263/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T494761)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# PDF Document API - Add a Link to a Page

This example shows the PDF Document Facade that adds a link to a destination that displays the third page with the Zoom to Page Level view.

> [!Important]  
> The Universal Subscription or an additional Office File API Subscription is required to use this example in production code. For pricing information, please refer to the [DevExpress Subscription](https://www.devexpress.com/Subscriptions/) page.  

## Implementation Details

The [PdfPageFacade](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfPageFacade) object allows you to perform various operations on a PDF page without access to its inner structure. Call the [CreateFitDestination](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfPageFacade.CreateFitDestination) to create a destination. This destination fits the entire page to the document window both horizontally and vertically (**Zoom to Page Level** view) when referencing to this page.

Use the link annotation to create a link to the destination at the required location. Call the [PdfPageFacade.AddLinkAnnotation](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfPageFacade.AddLinkAnnotation.overloads) method and pass the destination object and the page area as method parameters.

## Files to Review

| C# | Visual Basic |
|---|---|
| [Program.cs](./CS/AddLinkToPage/Program.cs) | [Program.vb](./VB/AddLinkToPage/Program.vb) |

## Documentation

* [Annotations in PDF Documents](https://docs.devexpress.com/OfficeFileAPI/119122/pdf-document-api/annotations)

## More Examples

* [PDF Document API - Add a Link to URI](https://github.com/DevExpress-Examples/pdf-document-api-add-link-to-uri)

<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-add-link-to-page&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-add-link-to-page&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
