using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using CSharp.AsposePdf.Annotations;
using CSharp.AsposePdf.Attachments;
using CSharp.AsposePdf.Bookmarks;
using CSharp.AsposePdf.DocumentConversion;
using CSharp.AsposePdf.Forms;
using CSharp.AsposePdf.Images;
using CSharp.AsposePdf.LinksActions;
using CSharp.AsposePdf.Operators;
using CSharp.AsposePdf.Pages;
using CSharp.AsposePdf.SecuritySignatures;
using CSharp.AsposePdf.StampsWatermarks;
using CSharp.AsposePdf.Tables;
using CSharp.AsposePdf.Text;
using CSharp.AsposePdf.WorkingDocuments;

using CSharp.AsposePDFFacades.Annotations;
using CSharp.AsposePDFFacades.Attachments;
using CSharp.AsposePDFFacades.Bookmarks;
using CSharp.AsposePDFFacades.Forms;
using CSharp.AsposePDFFacades.Images;
using CSharp.AsposePDFFacades.Printing;
using CSharp.AsposePDFFacades.StampsWatermarks;
using CSharp.AsposePDFFacades.Text;
using CSharp.AsposePDFFacades.WorkingDocument;

using CSharp.AsposePdfGenerator.Conversion;
using CSharp.AsposePdfGenerator.Paragraphs;
using CSharp.AsposePdfGenerator.Sections;
using CSharp.AsposePdfGenerator.Text;
using CSharp.AsposePdfGenerator.WorkingDocuments;

namespace CSharp
{
    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. In Main() method, Un-comment the example that you want to run");
            Console.WriteLine("=====================================================");
            // Un-comment the one you want to try out

            // =====================================================
            // =====================================================
            // Aspose.Pdf Annotations
            // =====================================================
            // =====================================================

            AddAnnotation.Run();
            //AddSwfFileAsAnnotation.Run();
            //DeleteAllAnnotationsFromPage.Run();
            //DeleteAllAnnotationsFromPage.Run();
            //GetAllAnnotationsFromPage.Run();
            //GetParticularAnnotation.Run();
            //SetFreeTextAnnotationFormatting.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Attachments
            //// =====================================================
            //// =====================================================

            //AsposePdf.Attachments.AddAttachment.Run();
            //AsposePdf.Attachments.DeleteAllAttachments.Run();
            //DisableFilesCompression.Run();
            //GetAlltheAttachments.Run();
            //GetAttachmentInfo.Run();
            //GetIndividualAttachment.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Bookmarks
            //// =====================================================
            //// =====================================================

            //AsposePdf.Bookmarks.AddBookmark.Run();
            //AsposePdf.Bookmarks.AddChildBookmark.Run();
            //AsposePdf.Bookmarks.DeleteAllBookmarks.Run();
            //DeleteParticularBookmark.Run();
            //GetBookmarks.Run();
            //GetChildBookmarks.Run();
            //UpdateBookmarks.Run();
            //UpdateChildBookmarks.Run();


            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Document Conversion
            //// =====================================================
            //// =====================================================
            
            //CGMToPDF.Run();
            //EPUBToPDF.Run();
            //GetSVGDimensions.Run();
            //AsposePdf.DocumentConversion.HTMLToPDF.Run();
            //PCLToPDF.Run();
            //PDFToDOC.Run();
            //PDFToEPUB.Run();
            //PDFToHTML.Run();
            //PDFToPDFA.Run();
            //PDFToTeX.Run();
            //PDFToXML.Run();
            //SVGToPDF.Run();
            //XPSToPDF.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Fields
            //// =====================================================
            //// =====================================================
            
            //AddTooltipToField.Run();
            //ComboBox.Run();
            //DeleteFormField.Run();
            //DetermineRequiredField.Run();
            //DynamicXFAToAcroForm.Run();
            //FillFormField.Run();
            //FillXFAFields.Run();
            //FormFieldFont14.Run();
            //GetFieldsFromRegion.Run();
            //GetValueFromField.Run();
            //GetValuesFromAllFields.Run();
            //GetXFAProperties.Run();
            //ModifyFormField.Run();
            //MoveFormField.Run();
            //RadioButton.Run();
            //SetJavaScript.Run();
            //TextBox.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Images
            //// =====================================================
            //// =====================================================

            //AsposePdf.Images.AddImage.Run();
            //CGMImageToPDF.Run();
            //ConvertAllPagesToEMF.Run();
            //ConvertAllPagesToPNG.Run();
            //DeleteImages.Run();
            //AsposePdf.Images.ExtractImages.Run();
            //ImageInformation.Run();
            //ImagePlacements.Run();
            //PagesToImages.Run();
            //PageToEMF.Run();
            //PageToPNG.Run();
            //PageToTIFF.Run();
            //AsposePdf.Images.ReplaceImage.Run();
            //SearchAndGetImages.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Links And Actions
            //// =====================================================
            //// =====================================================

            //AddHyperlink.Run();
            //CreateApplicationLink.Run();
            //CreateDocumentLink.Run();
            //ExtractLinks.Run();
            //RemoveOpenAction.Run();
            //SpecifyPageWhenViewing.Run();
            //UpdateLinks.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Operators
            //// =====================================================
            //// =====================================================
            
            //DrawXFormOnPage.Run();
            //PDFOperators.Run();
            //RemoveGraphicsObjects.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Pages
            //// =====================================================
            //// =====================================================

            //ConcatenatePdfFiles.Run();
            //DeleteParticularPage.Run();
            //GetNumberofPages.Run();
            //GetParticularPage.Run();
            //GetProperties.Run();
            //ImageAsBackground.Run();
            //InsertEmptyPage.Run();
            //InsertEmptyPageAtEnd.Run();
            //SplitToPages.Run();
            //UpdateDimensions.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Security and Signatures
            //// =====================================================
            //// =====================================================

            //ChangePassword.Run();
            //Decrypt.Run();
            //DigitallySign.Run();
            //Encrypt.Run();
            //ExtractingImage.Run();
            //ExtractSignatureInfo.Run();
            //IsPasswordProtected.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Images
            //// =====================================================
            //// =====================================================

            //AddImageStamp.Run();
            //AddingDifferentHeaders.Run();
            //AddTextStamp.Run();
            //DefineAlignment.Run();
            //ImageInFooter.Run();
            //ImageinHeader.Run();
            //PageNumberStamps.Run();
            //PDFPageStamp.Run();
            //TextinFooter.Run();
            //TextinHeader.Run();


            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Tables
            //// =====================================================
            //// =====================================================
            
            //AddTable.Run();
            //IntegrateWithDatabase.Run();
            //MarginsOrPadding.Run();
            //RenderTable.Run();
            //SetBorder.Run();


            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Text
            //// =====================================================
            //// =====================================================

            //ExtractTextAll.Run();
            //AsposePdf.Text.ExtractTextPage.Run();
            //ReplaceTextAll.Run();
            //AsposePdf.Text.ReplaceTextPage.Run();
            //SearchAndGetTextAll.Run();
            //SearchAndGetTextPage.Run();
            //SearchRegularExpression.Run();
            //SearchRegularExpressionPage.Run();
            //SearchTextRegex.Run();
            //SearchTextSegmentsAll.Run();
            //SearchTextSegmentsPage.Run();


            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf Working with Documents
            //// =====================================================
            //// =====================================================

            //AddLayers.Run();
            //AddTOC.Run();
            //GetDocumentWindow.Run();
            //AsposePdf.WorkingDocuments.GetFileInfo.Run();
            //GetXMPMetadata.Run();
            //GetZoomFactor.Run();
            //OptimizeDocument.Run();
            //SetDocumentWindow.Run();
            //AsposePdf.WorkingDocuments.SetFileInfo.Run();
            //AsposePdf.WorkingDocuments.SetXMPMetadata.Run();
            //AsposePdf.WorkingDocuments.SetZoomFactor.Run();
            //ValidatePDFAStandard.Run();


            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Facades Annotations
            //// =====================================================
            //// =====================================================
            
            //AddFreeTextAnnotation.Run();
            //CreateFileAnnotation.Run();
            //DeleteAllAnnotations.Run();
            //ExportAnnotations.Run();
            //ExtractAnnotations.Run();
            //ImportAnnotations.Run();
            //UpdateAnnotations.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Facades Attachments
            //// =====================================================
            //// =====================================================

            //AsposePDFFacades.Attachments.AddAttachment.Run();
            //AddAttachmentStream.Run();
            //AsposePDFFacades.Attachments.DeleteAllAttachments.Run();
            //ExtractAllAttachments.Run();
            //GetAttachmentNames.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Facades Bookmarks
            //// =====================================================
            //// =====================================================
            
            //AsposePDFFacades.Bookmarks.AddBookmark.Run();
            //AsposePDFFacades.Bookmarks.AddChildBookmark.Run();
            //CreateBookmarkPage.Run();
            //CreateBookmarksAll.Run();
            //CreateBookmarksPagesProperties.Run();
            //DeleteABookmark.Run();
            //AsposePDFFacades.Bookmarks.DeleteAllBookmarks.Run();
            //ExportToXML.Run();
            //ExtractBookmarks.Run();
            //GetFromPDF.Run();
            //ImportFromXML.Run();
            //UpdateBookmark.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Facades Forms
            //// =====================================================
            //// =====================================================
            
            //AddFormField.Run();
            //CopyInnerField.Run();
            //CopyOuterField.Run();
            //DecorateFields.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Facades Images
            //// =====================================================
            //// =====================================================

            //AsposePDFFacades.Images.AddImage.Run();
            //ConvertPageRegion.Run();
            //ConvertPDFPages.Run();
            //ConvertToTIFFSettings.Run();
            //DeleteAllImages.Run();
            //DeleteImagesPage.Run();
            //ExtractImageExtractionMode.Run();
            //AsposePDFFacades.Images.ExtractImages.Run();
            //ExtractImagesPage.Run();
            //ExtractImagesStream.Run();
            //AsposePDFFacades.Images.ReplaceImage.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Facades Printing
            //// =====================================================
            //// =====================================================
            
            //PrintPageRange.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Facades Stamps and Watermarks
            //// =====================================================
            //// =====================================================

            //AddFooter.Run();
            //AddHeader.Run();
            //AddImageFooter.Run();
            //AddImageStampAll.Run();
            //AddImageStampPage.Run();
            //AddPageNumber.Run();
            //AddPageStampAll.Run();
            //AddPageStampPage.Run();
            //AddTextStampAll.Run();
            //AddTextStampPage.Run();
            //ChangeStampPosition.Run();
            //ExtractImageImageStamp.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Facades Text
            //// =====================================================
            //// =====================================================

            //AsposePDFFacades.Text.AddText.Run();
            //ExtractText.Run();
            //AsposePDFFacades.Text.ExtractTextPage.Run();
            //ExtractTextPageRange.Run();
            //ReplaceText.Run();
            //AsposePDFFacades.Text.ReplaceTextPage.Run();


            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Facades Working with Documents
            //// =====================================================
            //// =====================================================
            
            //AsposePDFFacades.WorkingDocument.GetFileInfo.Run();
            //AsposePDFFacades.WorkingDocument.SetFileInfo.Run();
            //SetViewerPreference.Run();
            //AsposePDFFacades.WorkingDocument.SetXMPMetadata.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Generator Conversion
            //// =====================================================
            //// =====================================================
            
            //AsposePdfGenerator.Conversion.HTMLToPDF.Run();
            //XSLFOToPDF.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Generator Paragraphs 
            //// =====================================================
            //// =====================================================
            
            //AssignID.Run();
            //Render.Run();
            //SetMargins.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Generator Sections
            //// =====================================================
            //// =====================================================
            
            //SetPageBackgroundImage.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Generator Text
            //// =====================================================
            //// =====================================================
            
            //ChangeTextFormat.Run();
            //CustomTabStops.Run();
            //InheritTextFormat.Run();
            //InlineHTMLFromXML.Run();
            //LeftHangingTextParagraph.Run();
            //RTLLanguages.Run();
            //SetRenderingMode.Run();
            //SetTextBackgroundColor.Run();
            //SetVerticalAlignment.Run();
            //TextFormattingTags.Run();
            //UnderlineOverlineStrikeOut.Run();

            //// =====================================================
            //// =====================================================
            //// Aspose.Pdf.Generator Working with Documents
            //// =====================================================
            //// =====================================================

            //AddingXMPMetaData.Run();
            //AddJavaScript.Run();
            //SetAppearance.Run();
            //SetDocumentInfo.Run();
            //SetPageTransitionEffect.Run();
            //AsposePdfGenerator.WorkingDocuments.SetZoomFactor.Run();      
                        

            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }

        public static String GetDataDir_AsposePdf_Annotations()
        {
            return Path.GetFullPath("../../AsposePDF/Annotations/Data/");
        }

        public static String GetDataDir_AsposePdf_Attachments()
        {
            return Path.GetFullPath("../../AsposePDF/Attachments/Data/");
        }
        public static String GetDataDir_AsposePdf_Bookmarks()
        {
            return Path.GetFullPath("../../AsposePDF/Bookmarks/Data/");
        }
        public static String GetDataDir_AsposePdf_DocumentConversion()
        {
            return Path.GetFullPath("../../AsposePDF/DocumentConversion/Data/");
        }
        public static String GetDataDir_AsposePdf_Forms()
        {
            return Path.GetFullPath("../../AsposePDF/Forms/Data/");
        }
        public static String GetDataDir_AsposePdf_Images()
        {
            return Path.GetFullPath("../../AsposePDF/Images/Data/");
        }
        public static String GetDataDir_AsposePdf_LinksActions()
        {
            return Path.GetFullPath("../../AsposePDF/Links-Actions/Data/");
        }
        public static String GetDataDir_AsposePdf_Operators()
        {
            return Path.GetFullPath("../../AsposePDF/Operators/Data/");
        }
        public static String GetDataDir_AsposePdf_Pages()
        {
            return Path.GetFullPath("../../AsposePDF/Pages/Data/");
        }
        public static String GetDataDir_AsposePdf_SecuritySignatures()
        {
            return Path.GetFullPath("../../AsposePDF/Security-Signatures/Data/");
        }
        public static String GetDataDir_AsposePdf_StampsWatermarks()
        {
            return Path.GetFullPath("../../AsposePDF/Stamps-Watermarks/Data/");
        }
        public static String GetDataDir_AsposePdf_Tables()
        {
            return Path.GetFullPath("../../AsposePDF/Tables/Data/");
        }
        public static String GetDataDir_AsposePdf_Text()
        {
            return Path.GetFullPath("../../AsposePDF/Text/Data/");
        }
        public static String GetDataDir_AsposePdf_WorkingDocuments()
        {
            return Path.GetFullPath("../../AsposePDF/Working-Documents/Data//");
        }



        public static String GetDataDir_AsposePdfFacades_Annotations()
        {
            return Path.GetFullPath("../../AsposePdfFacades/Annotations/Data/");
        }

        public static String GetDataDir_AsposePdfFacades_Attachments()
        {
            return Path.GetFullPath("../../AsposePdfFacades/Attachments/Data/");
        }
        public static String GetDataDir_AsposePdfFacades_Bookmarks()
        {
            return Path.GetFullPath("../../AsposePdfFacades/Bookmarks/Data/");
        }
        
        public static String GetDataDir_AsposePdfFacades_Forms()
        {
            return Path.GetFullPath("../../AsposePdfFacades/Forms/Data/");
        }
        public static String GetDataDir_AsposePdfFacades_Images()
        {
            return Path.GetFullPath("../../AsposePdfFacades/Images/Data/");
        }
        
        public static String GetDataDir_AsposePdfFacades_StampsWatermarks()
        {
            return Path.GetFullPath("../../AsposePdfFacades/Stamps-Watermarks/Data/");
        }
        public static String GetDataDir_AsposePdfFacades_Printing()
        {
            return Path.GetFullPath("../../AsposePdfFacades/Printing/Data/");
        }
        public static String GetDataDir_AsposePdfFacades_Text()
        {
            return Path.GetFullPath("../../AsposePdfFacades/Text/Data/");
        }
        public static String GetDataDir_AsposePdfFacades_WorkingDocuments()
        {
            return Path.GetFullPath("../../AsposePdfFacades/Working-Documents/Data/");
        }




        public static String GetDataDir_AsposePdfGenerator_Conversion()
        {
            return Path.GetFullPath("../../AsposePdfGenerator/Conversion/Data/");
        }

        public static String GetDataDir_AsposePdfGenerator_Paragraphs()
        {
            return Path.GetFullPath("../../AsposePdfGenerator/Paragraphs/Data/");
        }
        public static String GetDataDir_AsposePdfGenerator_Sections()
        {
            return Path.GetFullPath("../../AsposePdfGenerator/Sections/Data/");
        }
        public static String GetDataDir_AsposePdfGenerator_Text()
        {
            return Path.GetFullPath("../../AsposePdfGenerator/Text/Data/");
        }
        public static String GetDataDir_AsposePdfGenerator_WorkingDocuments()
        {
            return Path.GetFullPath("../../AsposePdfGenerator/Working-Documents/Data/");
        }
    }
}