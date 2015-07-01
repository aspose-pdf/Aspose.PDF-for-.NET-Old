Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text

Imports VisualBasic.AsposePdf.Annotations
Imports VisualBasic.AsposePdf.Attachments
Imports VisualBasic.AsposePdf.Bookmarks
Imports VisualBasic.AsposePdf.DocumentConversion
Imports VisualBasic.AsposePdf.Forms
Imports VisualBasic.AsposePdf.Images
Imports VisualBasic.AsposePdf.LinksActions
Imports VisualBasic.AsposePdf.Operators
Imports VisualBasic.AsposePdf.Pages
Imports VisualBasic.AsposePdf.SecuritySignatures
Imports VisualBasic.AsposePdf.StampsWatermarks
Imports VisualBasic.AsposePdf.Tables
Imports VisualBasic.AsposePdf.Text
Imports VisualBasic.AsposePdf.WorkingDocuments

Imports VisualBasic.AsposePDFFacades.Annotations
Imports VisualBasic.AsposePDFFacades.Attachments
Imports VisualBasic.AsposePDFFacades.Bookmarks
Imports VisualBasic.AsposePDFFacades.Forms
Imports VisualBasic.AsposePDFFacades.Images
Imports VisualBasic.AsposePDFFacades.Printing
Imports VisualBasic.AsposePDFFacades.StampsWatermarks
Imports VisualBasic.AsposePDFFacades.Text
Imports VisualBasic.AsposePDFFacades.WorkingDocument

Imports VisualBasic.AsposePdfGenerator.Conversion
Imports VisualBasic.AsposePdfGenerator.Paragraphs
Imports VisualBasic.AsposePdfGenerator.Sections
Imports VisualBasic.AsposePdfGenerator.Text
Imports VisualBasic.AsposePdfGenerator.WorkingDocuments

Namespace VisualBasic
    Friend Class RunExamples
        <STAThread()> _
        Public Shared Sub Main()
            Console.WriteLine("Open RunExamples.cs. In Main() method, Un-comment the example that you want to run")
            Console.WriteLine("=====================================================")
            ' Un-comment the one you want to try out

            ' =====================================================
            ' =====================================================
            ' Aspose.Pdf Annotations
            ' =====================================================
            ' =====================================================

            AddAnnotation.Run()
            'AddSwfFileAsAnnotation.Run();
            'DeleteAllAnnotationsFromPage.Run();
            'DeleteAllAnnotationsFromPage.Run();
            'GetAllAnnotationsFromPage.Run();
            'GetParticularAnnotation.Run();
            'SetFreeTextAnnotationFormatting.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Attachments
            '// =====================================================
            '// =====================================================

            'AsposePdf.Attachments.AddAttachment.Run();
            'AsposePdf.Attachments.DeleteAllAttachments.Run();
            'DisableFilesCompression.Run();
            'GetAlltheAttachments.Run();
            'GetAttachmentInfo.Run();
            'GetIndividualAttachment.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Bookmarks
            '// =====================================================
            '// =====================================================

            'AsposePdf.Bookmarks.AddBookmark.Run();
            'AsposePdf.Bookmarks.AddChildBookmark.Run();
            'AsposePdf.Bookmarks.DeleteAllBookmarks.Run();
            'DeleteParticularBookmark.Run();
            'GetBookmarks.Run();
            'GetChildBookmarks.Run();
            'UpdateBookmarks.Run();
            'UpdateChildBookmarks.Run();


            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Document Conversion
            '// =====================================================
            '// =====================================================

            'CGMToPDF.Run();
            'EPUBToPDF.Run();
            'GetSVGDimensions.Run();
            'AsposePdf.DocumentConversion.HTMLToPDF.Run();
            'PCLToPDF.Run();
            'PDFToDOC.Run();
            'PDFToEPUB.Run();
            'PDFToHTML.Run();
            'PDFToPDFA.Run();
            'PDFToTeX.Run();
            'PDFToXML.Run();
            'SVGToPDF.Run();
            'XPSToPDF.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Fields
            '// =====================================================
            '// =====================================================

            'AddTooltipToField.Run();
            'ComboBox.Run();
            'DeleteFormField.Run();
            'DetermineRequiredField.Run();
            'DynamicXFAToAcroForm.Run();
            'FillFormField.Run();
            'FillXFAFields.Run();
            'FormFieldFont14.Run();
            'GetFieldsFromRegion.Run();
            'GetValueFromField.Run();
            'GetValuesFromAllFields.Run();
            'GetXFAProperties.Run();
            'ModifyFormField.Run();
            'MoveFormField.Run();
            'RadioButton.Run();
            'SetJavaScript.Run();
            'TextBox.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Images
            '// =====================================================
            '// =====================================================

            'AsposePdf.Images.AddImage.Run();
            'CGMImageToPDF.Run();
            'ConvertAllPagesToEMF.Run();
            'ConvertAllPagesToPNG.Run();
            'DeleteImages.Run();
            'AsposePdf.Images.ExtractImages.Run();
            'ImageInformation.Run();
            'ImagePlacements.Run();
            'PagesToImages.Run();
            'PageToEMF.Run();
            'PageToPNG.Run();
            'PageToTIFF.Run();
            'AsposePdf.Images.ReplaceImage.Run();
            'SearchAndGetImages.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Links And Actions
            '// =====================================================
            '// =====================================================

            'AddHyperlink.Run();
            'CreateApplicationLink.Run();
            'CreateDocumentLink.Run();
            'ExtractLinks.Run();
            'RemoveOpenAction.Run();
            'SpecifyPageWhenViewing.Run();
            'UpdateLinks.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Operators
            '// =====================================================
            '// =====================================================

            'DrawXFormOnPage.Run();
            'PDFOperators.Run();
            'RemoveGraphicsObjects.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Pages
            '// =====================================================
            '// =====================================================

            'ConcatenatePdfFiles.Run();
            'DeleteParticularPage.Run();
            'GetNumberofPages.Run();
            'GetParticularPage.Run();
            'GetProperties.Run();
            'ImageAsBackground.Run();
            'InsertEmptyPage.Run();
            'InsertEmptyPageAtEnd.Run();
            'SplitToPages.Run();
            'UpdateDimensions.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Security and Signatures
            '// =====================================================
            '// =====================================================

            'ChangePassword.Run();
            'Decrypt.Run();
            'DigitallySign.Run();
            'Encrypt.Run();
            'ExtractingImage.Run();
            'ExtractSignatureInfo.Run();
            'IsPasswordProtected.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Images
            '// =====================================================
            '// =====================================================

            'AddImageStamp.Run();
            'AddingDifferentHeaders.Run();
            'AddTextStamp.Run();
            'DefineAlignment.Run();
            'ImageInFooter.Run();
            'ImageinHeader.Run();
            'PageNumberStamps.Run();
            'PDFPageStamp.Run();
            'TextinFooter.Run();
            'TextinHeader.Run();


            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Tables
            '// =====================================================
            '// =====================================================

            'AddTable.Run();
            'IntegrateWithDatabase.Run();
            'MarginsOrPadding.Run();
            'RenderTable.Run();
            'SetBorder.Run();


            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Text
            '// =====================================================
            '// =====================================================

            'ExtractTextAll.Run();
            'AsposePdf.Text.ExtractTextPage.Run();
            'ReplaceTextAll.Run();
            'AsposePdf.Text.ReplaceTextPage.Run();
            'SearchAndGetTextAll.Run();
            'SearchAndGetTextPage.Run();
            'SearchRegularExpression.Run();
            'SearchRegularExpressionPage.Run();
            'SearchTextRegex.Run();
            'SearchTextSegmentsAll.Run();
            'SearchTextSegmentsPage.Run();


            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf Working with Documents
            '// =====================================================
            '// =====================================================

            'AddLayers.Run();
            'AddTOC.Run();
            'GetDocumentWindow.Run();
            'AsposePdf.WorkingDocuments.GetFileInfo.Run();
            'GetXMPMetadata.Run();
            'GetZoomFactor.Run();
            'OptimizeDocument.Run();
            'SetDocumentWindow.Run();
            'AsposePdf.WorkingDocuments.SetFileInfo.Run();
            'AsposePdf.WorkingDocuments.SetXMPMetadata.Run();
            'AsposePdf.WorkingDocuments.SetZoomFactor.Run();
            'ValidatePDFAStandard.Run();


            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Facades Annotations
            '// =====================================================
            '// =====================================================

            'AddFreeTextAnnotation.Run();
            'CreateFileAnnotation.Run();
            'DeleteAllAnnotations.Run();
            'ExportAnnotations.Run();
            'ExtractAnnotations.Run();
            'ImportAnnotations.Run();
            'UpdateAnnotations.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Facades Attachments
            '// =====================================================
            '// =====================================================

            'AsposePDFFacades.Attachments.AddAttachment.Run();
            'AddAttachmentStream.Run();
            'AsposePDFFacades.Attachments.DeleteAllAttachments.Run();
            'ExtractAllAttachments.Run();
            'GetAttachmentNames.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Facades Bookmarks
            '// =====================================================
            '// =====================================================

            'AsposePDFFacades.Bookmarks.AddBookmark.Run();
            'AsposePDFFacades.Bookmarks.AddChildBookmark.Run();
            'CreateBookmarkPage.Run();
            'CreateBookmarksAll.Run();
            'CreateBookmarksPagesProperties.Run();
            'DeleteABookmark.Run();
            'AsposePDFFacades.Bookmarks.DeleteAllBookmarks.Run();
            'ExportToXML.Run();
            'ExtractBookmarks.Run();
            'GetFromPDF.Run();
            'ImportFromXML.Run();
            'UpdateBookmark.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Facades Forms
            '// =====================================================
            '// =====================================================

            'AddFormField.Run();
            'CopyInnerField.Run();
            'CopyOuterField.Run();
            'DecorateFields.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Facades Images
            '// =====================================================
            '// =====================================================

            'AsposePDFFacades.Images.AddImage.Run();
            'ConvertPageRegion.Run();
            'ConvertPDFPages.Run();
            'ConvertToTIFFSettings.Run();
            'DeleteAllImages.Run();
            'DeleteImagesPage.Run();
            'ExtractImageExtractionMode.Run();
            'AsposePDFFacades.Images.ExtractImages.Run();
            'ExtractImagesPage.Run();
            'ExtractImagesStream.Run();
            'AsposePDFFacades.Images.ReplaceImage.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Facades Printing
            '// =====================================================
            '// =====================================================

            'PrintPageRange.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Facades Stamps and Watermarks
            '// =====================================================
            '// =====================================================

            'AddFooter.Run();
            'AddHeader.Run();
            'AddImageFooter.Run();
            'AddImageStampAll.Run();
            'AddImageStampPage.Run();
            'AddPageNumber.Run();
            'AddPageStampAll.Run();
            'AddPageStampPage.Run();
            'AddTextStampAll.Run();
            'AddTextStampPage.Run();
            'ChangeStampPosition.Run();
            'ExtractImageImageStamp.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Facades Text
            '// =====================================================
            '// =====================================================

            'AsposePDFFacades.Text.AddText.Run();
            'ExtractText.Run();
            'AsposePDFFacades.Text.ExtractTextPage.Run();
            'ExtractTextPageRange.Run();
            'ReplaceText.Run();
            'AsposePDFFacades.Text.ReplaceTextPage.Run();


            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Facades Working with Documents
            '// =====================================================
            '// =====================================================

            'AsposePDFFacades.WorkingDocument.GetFileInfo.Run();
            'AsposePDFFacades.WorkingDocument.SetFileInfo.Run();
            'SetViewerPreference.Run();
            'AsposePDFFacades.WorkingDocument.SetXMPMetadata.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Generator Conversion
            '// =====================================================
            '// =====================================================

            'AsposePdfGenerator.Conversion.HTMLToPDF.Run();
            'XSLFOToPDF.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Generator Paragraphs 
            '// =====================================================
            '// =====================================================

            'AssignID.Run();
            'Render.Run();
            'SetMargins.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Generator Sections
            '// =====================================================
            '// =====================================================

            'SetPageBackgroundImage.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Generator Text
            '// =====================================================
            '// =====================================================

            'ChangeTextFormat.Run();
            'CustomTabStops.Run();
            'InheritTextFormat.Run();
            'InlineHTMLFromXML.Run();
            'LeftHangingTextParagraph.Run();
            'RTLLanguages.Run();
            'SetRenderingMode.Run();
            'SetTextBackgroundColor.Run();
            'SetVerticalAlignment.Run();
            'TextFormattingTags.Run();
            'UnderlineOverlineStrikeOut.Run();

            '// =====================================================
            '// =====================================================
            '// Aspose.Pdf.Generator Working with Documents
            '// =====================================================
            '// =====================================================

            'AddingXMPMetaData.Run();
            'AddJavaScript.Run();
            'SetAppearance.Run();
            'SetDocumentInfo.Run();
            'SetPageTransitionEffect.Run();
            'AsposePdfGenerator.WorkingDocuments.SetZoomFactor.Run();      


            ' Stop before exiting
            Console.WriteLine(Constants.vbLf + Constants.vbLf & "Program Finished. Press any key to exit....")
            Console.ReadKey()
        End Sub

        Public Shared Function GetDataDir_AsposePdf_Annotations() As String
            Return Path.GetFullPath("../../AsposePDF/Annotations/Data/")
        End Function

        Public Shared Function GetDataDir_AsposePdf_Attachments() As String
            Return Path.GetFullPath("../../AsposePDF/Attachments/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_Bookmarks() As String
            Return Path.GetFullPath("../../AsposePDF/Bookmarks/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_DocumentConversion() As String
            Return Path.GetFullPath("../../AsposePDF/DocumentConversion/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_Forms() As String
            Return Path.GetFullPath("../../AsposePDF/Forms/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_Images() As String
            Return Path.GetFullPath("../../AsposePDF/Images/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_LinksActions() As String
            Return Path.GetFullPath("../../AsposePDF/Links-Actions/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_Operators() As String
            Return Path.GetFullPath("../../AsposePDF/Operators/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_Pages() As String
            Return Path.GetFullPath("../../AsposePDF/Pages/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_SecuritySignatures() As String
            Return Path.GetFullPath("../../AsposePDF/Security-Signatures/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_StampsWatermarks() As String
            Return Path.GetFullPath("../../AsposePDF/Stamps-Watermarks/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_Tables() As String
            Return Path.GetFullPath("../../AsposePDF/Tables/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_Text() As String
            Return Path.GetFullPath("../../AsposePDF/Text/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdf_WorkingDocuments() As String
            Return Path.GetFullPath("../../AsposePDF/Working-Documents/Data//")
        End Function



        Public Shared Function GetDataDir_AsposePdfFacades_Annotations() As String
            Return Path.GetFullPath("../../AsposePdfFacades/Annotations/Data/")
        End Function

        Public Shared Function GetDataDir_AsposePdfFacades_Attachments() As String
            Return Path.GetFullPath("../../AsposePdfFacades/Attachments/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdfFacades_Bookmarks() As String
            Return Path.GetFullPath("../../AsposePdfFacades/Bookmarks/Data/")
        End Function

        Public Shared Function GetDataDir_AsposePdfFacades_Forms() As String
            Return Path.GetFullPath("../../AsposePdfFacades/Forms/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdfFacades_Images() As String
            Return Path.GetFullPath("../../AsposePdfFacades/Images/Data/")
        End Function

        Public Shared Function GetDataDir_AsposePdfFacades_StampsWatermarks() As String
            Return Path.GetFullPath("../../AsposePdfFacades/Stamps-Watermarks/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdfFacades_Printing() As String
            Return Path.GetFullPath("../../AsposePdfFacades/Printing/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdfFacades_Text() As String
            Return Path.GetFullPath("../../AsposePdfFacades/Text/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdfFacades_WorkingDocuments() As String
            Return Path.GetFullPath("../../AsposePdfFacades/Working-Documents/Data/")
        End Function




        Public Shared Function GetDataDir_AsposePdfGenerator_Conversion() As String
            Return Path.GetFullPath("../../AsposePdfGenerator/Conversion/Data/")
        End Function

        Public Shared Function GetDataDir_AsposePdfGenerator_Paragraphs() As String
            Return Path.GetFullPath("../../AsposePdfGenerator/Paragraphs/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdfGenerator_Sections() As String
            Return Path.GetFullPath("../../AsposePdfGenerator/Sections/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdfGenerator_Text() As String
            Return Path.GetFullPath("../../AsposePdfGenerator/Text/Data/")
        End Function
        Public Shared Function GetDataDir_AsposePdfGenerator_WorkingDocuments() As String
            Return Path.GetFullPath("../../AsposePdfGenerator/Working-Documents/Data/")
        End Function
    End Class
End Namespace