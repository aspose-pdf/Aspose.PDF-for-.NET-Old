using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Attachments;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks;
using Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion;
using Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Forms;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Images;
using Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Operators;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Pages;
using Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures;
using Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Tables;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Text;
using Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Miscellaneous;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Graphs;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Headings;

using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Attachments;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Printing;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.StampsWatermarks;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Text;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.WorkingDocument;

using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Conversion;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Paragraphs;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Sections;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.WorkingDocuments;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.General;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Graphs;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Images;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Headings;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Tables;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Hyperlinks;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Attachments;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.SecurityFeatures;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.UtilityFeatures;
using Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.AdvanceFeatures;
namespace Aspose.Pdf.Examples.CSharp
{
    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");
            // Uncomment the one you want to try out

            // =====================================================
            // =====================================================
            // Aspose.Pdf 
            // =====================================================
            // =====================================================

            //// Text
            //// =====================================================            
            //Aspose.Pdf.Examples.CSharp.AsposePDF.Text.ExtractTextPage.Run();
            //ReplaceTextAll.Run();           
            //SearchAndGetTextAll.Run();
            //SearchAndGetTextPage.Run();
            //SearchRegularExpression.Run();
            //ReplaceTextonRegularExpression.Run();
            //ReplaceFirstOccurrence.Run();
            //SearchTextSegmentsPage.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.Text.AddText.Run();
            //ExtractTextUsingTextDevice.Run();
            //ReplaceFonts.Run();
            //HighlightCharacterInPDF.Run();
            //AddHTMLUsingDOM.Run();
            //RearrangeContentsUsingTextReplacement.Run();
            //FootAndEndNotes.Run();
            //SearchTextAndAddHyperlink.Run();
            //TextAndImageAsParagraph.Run();
            //ExtractColumnsText.Run();
            //SpecifyCharacterSpacing.Run();
            //CreateMultiColumnPdf.Run();
            //AsposePDF.Text.CustomTabStops.Run();
            //RenderingReplaceableSymbols.Run();
            //ReplaceableSymbolsInHeaderFooter.Run();
            //AddTransparentText.Run();
            //SearchTextAndDrawRectangle.Run();

            //// Images
            //// =====================================================   
            //Aspose.Pdf.Examples.CSharp.AsposePDF.Images.AddImage.Run();   
            //DeleteImages.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.Images.ExtractImages.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.Images.ReplaceImage.Run();
            //PagesToImages.Run();
            //ConvertAllPagesToPNG.Run();
            //PageToTIFF.Run();
            //AllPagesToTIFF.Run();
            //BradleyAlgorithm.Run();
            //ConvertAllPagesToEMF.Run();
            //PageToEMF.Run();
            //CGMImageToPDF.Run();
            //LargeCGMImageToPDF.Run();
            //ImageToPDF.Run();
            //ConvertToBMP.Run();
            //IdentifyImages.Run();
            //ConvertPageRegionToDOM.Run();

            //// Stamps-Watermarks
            //// =====================================================   
            //AddTextStamp.Run();
            //AddImageStamp.Run();
            //AddPDFPageStamp.Run();
            //PageNumberStamps.Run();
            //TextinHeader.Run();
            //TextinFooter.Run();
            //ImageinHeader.Run();
            //ImageInFooter.Run();    
            //AddingDifferentHeaders.Run();
            //DefineAlignment.Run();
            //AddDateTimeStamp.Run();

            //// Attachments
            //// =====================================================   
            //Aspose.Pdf.Examples.CSharp.AsposePDF.Attachments.AddAttachment.Run();
            //GetAlltheAttachments.Run();
            //GetIndividualAttachment.Run();
            //GetAttachmentInfo.Run();
            //DisableFilesCompression.Run();

            //// Pages
            //// =====================================================   
            //GetNumberofPages.Run();
            //GetPageCount.Run();
            //GetProperties.Run();
            //ConcatenatePdfFiles.Run();
            //InsertEmptyPage.Run();
            //InsertEmptyPageAtEnd.Run();
            //SplitToPages.Run();
            //GetParticularPage.Run();
            //DeleteParticularPage.Run();
            //UpdateDimensions.Run();
            //GetDimensions.Run();
            //ImageAsBackground.Run();
            //DeterminePageColor.Run(); 
            //ChangeOrientation.Run();
            //ZoomToPageContents.Run();

            //// Working-Document
            //// =====================================================   
            //SetDocumentWindow.Run();
            //GetDocumentWindow.Run();
            //ValidatePDFAStandard.Run();
            //OptimizeDocument.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.SetFileInfo.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.GetFileInfo.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.SetXMPMetadata.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.GetXMPMetadata.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.SetZoomFactor.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.GetZoomFactor.Run();
            //AddTOC.Run();
            //OptimizeFileSize.Run();
            //TrimWhiteSpace.Run();
            //AddJavaScriptToPage.Run();
            //AddRemoveJavascriptToDoc.Run();
            //AddLayers.Run();
            //EmbedFont.Run();
            //EmbedFontWhileDocCreation.Run();
            //ConvertFromRGBToGrayscale.Run();
            //SetExpiryDate.Run();

            //// Bookmarks
            //// =====================================================   
            //Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.AddBookmark.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.AddChildBookmark.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.DeleteAllBookmarks.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.DeleteParticularBookmark.Run();
            //GetBookmarks.Run();
            //GetChildBookmarks.Run();
            //UpdateBookmarks.Run();
            //UpdateChildBookmarks.Run();
            //InheritZoom.Run();
            //ExpandBookmarks.Run();

            //// Annotations
            //// =====================================================   
            //AddAnnotation.Run();
            //InvisibleAnnotation.Run();
            //AddlnkAnnotation.Run();
            //lnkAnnotationLineWidth.Run();
            //GetParticularAnnotation.Run();
            //GetAllAnnotationsFromPage.Run();
            //DeleteParticularAnnotation.Run();
            //DeleteAllAnnotationsFromPage.Run();
            //AddSwfFileAsAnnotation.Run();
            //SetFreeTextAnnotationFormatting.Run();
            //StrikeOutWords.Run();

            //// Forms
            //// =====================================================   
            //TextBox.Run();
            //RadioButtonWithOptions.Run();
            //ComboBox.Run();
            //DeleteFormField.Run();  
            //ModifyFormField.Run();   
            //FillFormField.Run();
            //ArabicTextFilling.Run();
            //SelectRadioButton.Run();
            //GetValueFromField.Run();
            //GetValueFromField.Run(); 
            //SetFieldLimit.Run();
            //MoveFormField.Run();
            //AddTooltipToField.Run();
            //GetFieldsFromRegion.Run();
            //FormFieldFont14.Run();
            //DynamicXFAToAcroForm.Run();
            //FillXFAFields.Run();
            //GetXFAProperties.Run();
            //DetermineRequiredField.Run();
            //SetJavaScript.Run();
            //HorizontallyAndVerticallyRadioButtons.Run();
            //GroupedCheckBoxes.Run();

            //// Links-Actions
            //// =====================================================   
            //CreateApplicationLink.Run();
            //CreateDocumentLink.Run();
            //RemoveOpenAction.Run();
            //ExtractLinks.Run();
            //AddHyperlink.Run();
            //UpdateLinks.Run();
            //SetDestinationLink.Run();
            //UpdateLinkTextColor.Run();
            //SpecifyPageWhenViewing.Run();
            //GetHyperlinkDestinations.Run();
            //GetHyperlinkText.Run();
            //CreateLocalHyperlink.Run();

            //// Security-Signatures
            //// =====================================================   
            //Encrypt.Run();
            //Decrypt.Run();
            //ChangePassword.Run();
            //IsPasswordProtected.Run();
            //DetermineCorrectPassword.Run();
            //ExtractingImage.Run();
            //SetPrivileges.Run();

            //// Operators
            //// =====================================================   
            //DrawXFormOnPage.Run();
            //PDFOperators.Run();
            //RemoveGraphicsObjects.Run();

            //// Miscellaneous
            //// =====================================================   
            //GetBuildInformation.Run();
            //UseMeasureWithLineAnnotation.Run();
            //UseMeasureWithPolylineAnnotation.Run();

            //// Tables
            //// =====================================================   
            //AddTable.Run();
            //AutoFitToWindow.Run();  
            //MarginsOrPadding.Run();
            //SetBorder.Run();
            //IntegrateWithDatabase.Run();
            //RenderTable.Run();
            //AddSVGObject.Run();
            //ExtractBorder.Run();
            //InsertPageBreak.Run();
            //DetermineTableBreak.Run();

            //// Graphs
            //// =====================================================   
            //CreateFilledRectangle.Run();
            //AddLineObject.Run();
            //DashLength.Run();
            //DrawingLine.Run();
            //CreateRectangleWithAlphaColor.Run();
            //AddDrawing.Run();
            //ControlRectangleZOrder.Run();

            //// Headings
            //// =====================================================   
            //ApplyNumberStyle.Run();

            //  DocumentConversion
            // =====================================================   
            //PDFToPDFA.Run();
            //PDFToPDFA3b.Run();
            //AddAttachmentToPDFA.Run();
            //PDFToDOC.Run();
            //PDFToTeX.Run();
            //SVGToPDF.Run();
            //GetSVGDimensions.Run();
            //EPUBToPDF.Run();
            //PDFToEPUB.Run();
            //PDFToXPS.Run();
            //PDFToXLS.Run();
            //PDFToSVG.Run();
            //PDFToXML.Run();
            //MHTToPDF.Run();
            //TextToPDF.Run();
            //CGMToPDF.Run();
            //PDFToPPT.Run();
            //PDFAToPDF.Run();
            //XMLToPDF.Run();

            // =====================================================
            // =====================================================
            // Aspose.Pdf.Generator
            // =====================================================
            // =====================================================

            //// General
            //// =====================================================            
            //HelloWorldUsingXML.Run();
            //HelloWorldUsingAPI.Run();
            //HelloWorldUsingXMLAndAPI.Run();
            //HelloWorldUsingXSLT.Run();
            //FloatingBoxLook.Run();
            //PositionFloatingBox.Run();

            //// Working-Document
            //// =====================================================            
            //SetDocumentInfo.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.WorkingDocuments.SetZoomFactor.Run();
            //SetAppearance.Run();
            //SetPageTransitionEffect.Run();
            //AddJavaScript.Run();
            //AddingXMPMetaData.Run();

            //// Sections
            //// =====================================================            
            //SetPageBackgroundImage.Run();
            //SetPageSize.Run();
            //SetPageMargin.Run();
            //SetHeaderAndFooter.Run();
            //AdvancedHeaderAndFooter.Run();

            //// Paragraphs
            //// =====================================================            
            //SetMargins.Run();
            //AssignID.Run();
            //Render.Run();

            //// Text
            //// =====================================================            
            //InlineParagraph.Run();
            //TextLayout.Run();
            //InheritTextFormat.Run();
            //SymbolFont.Run();
            //PFMFont.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text.EmbedFont.Run();
            //ReplaceableSymbols.Run();
            //RTLLanguages.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text.CustomTabStops.Run();            
            //HyperlinkTags.Run();
            //SuperSubscript.Run();
            //AddFootnotes.Run();
            //AddEndnote.Run();
            //InlineRadioButton.Run();

            //// Graphs
            //// =====================================================            
            //GraphCoordinate.Run();
            //GraphFormat.Run();
            //RotationAndScaling.Run();

            //// Images
            //// =====================================================            
            //ImageFromLocalDisk.Run();
            //ImageFromMemory.Run();
            //ImageFromWeb.Run();
            //CCITTImage.Run();

            //// Headings
            //// =====================================================            
            //ApplyingNumber.Run();
            //SpecifyHeadingLevel.Run();
            //SystemBullets.Run();
            //UserDefinedBullets.Run();

            //// Tables
            //// =====================================================            
            //SetBorderAndPadding.Run();
            //SetColumnWidthAndSpan.Run();
            //TableAndRowSplitting.Run();
            //CompleteClone.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Tables.IntegrateWithDatabase.Run();
            //CellInformation.Run();
            //RowAndColumnFormat.Run();
            //NestedTables.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Tables.RoundedCornerTable.Run();
            //NonEnglishText.Run();

            //// Hyperlinks
            //// =====================================================            
            //HyperlinkPages.Run();
            //HyperlinkOtherPdf.Run();
            //HyperlinkNonPdfFile.Run();
            //HyperlinkToWeb.Run();

            //// Attachments
            //// =====================================================            
            //AttachAnyFile.Run();
            //AttachNoteAnnotation.Run();
            //CustomizeNotePosition.Run();

            //// SecurityFeatures
            //// =====================================================            
            //SetPassword.Run();
            //SetEncryption.Run();
            //AllowDisallowPrivileges.Run();

            //// UtilityFeatures
            //// =====================================================            
            //AddingList.Run();
            //AddThreeList.Run();
            //SpecifyListItem.Run();
            //ManipulatingFormFields.Run();
            //ManipulatingColumns.Run();
            //CustomizingWatermark.Run();
            //CreatePdf.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.UtilityFeatures.AddBookmark.Run();
            //AddTableOfContents.Run();

            //// Conversion
            //// =====================================================            
            //XSLFOToPDF.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Conversion.PCLToPDF.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Conversion.SVGToPDF.Run();
            //Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Conversion.HTMLToPDF.Run();
            //WebToPDF.Run();
            //HTMLToPDFUsingStream.Run();

            //// AdvanceFeatures
            //// =====================================================            
            //TableMinimumColumnWidth.Run();
            //AddPageBorder.Run();
            //MergeXMLFiles.Run();
            //XSLToPdf.Run();
            //XMLAsTemplate.Run();
            //LoadDataInXMLTemplate.Run();
                                 
            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }
        public static String GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/DocumentConversion/PDFToHTMLFormat/");
        }
        public static String GetDataDir_AsposePdf_Annotations()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Annotations/");
        }
        public static String GetDataDir_AsposePdf_Graphs()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Graphs/");
        }
        public static String GetDataDir_AsposePdf_Headings()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Headings/");
        }
        public static String GetDataDir_AsposePdf_Miscellaneous()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Miscellaneous/");
        }
        public static String GetDataDir_AsposePdf_Attachments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Attachments/");
        }
        public static String GetDataDir_AsposePdf_Bookmarks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Bookmarks/");
        }
        public static String GetDataDir_AsposePdf_DocumentConversion()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/DocumentConversion/");
        }
        public static String GetDataDir_AsposePdf_Forms()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Forms/");
        }
        public static String GetDataDir_AsposePdf_Images()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Images/");
        }
        public static String GetDataDir_AsposePdf_LinksActions()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Links-Actions/");
        }
        public static String GetDataDir_AsposePdf_Operators()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Operators/");
        }
        public static String GetDataDir_AsposePdf_Pages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Pages/");
        }
        public static String GetDataDir_AsposePdf_SecuritySignatures()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Security-Signatures/");
        }
        public static String GetDataDir_AsposePdf_StampsWatermarks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Stamps-Watermarks/");
        }
        public static String GetDataDir_AsposePdf_Tables()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Tables/");
        }
        public static String GetDataDir_AsposePdf_Text()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Text/");
        }
        public static String GetDataDir_AsposePdf_WorkingDocuments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Working-Document/");
        }
        public static String GetDataDir_AsposePdfFacades_Annotations()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Annotations/");
        }
        public static String GetDataDir_AsposePdfFacades_Attachments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Attachments/");
        }
        public static String GetDataDir_AsposePdfFacades_Bookmarks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Bookmarks/");
        }        
        public static String GetDataDir_AsposePdfFacades_Forms()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Forms/");
        }
        public static String GetDataDir_AsposePdfFacades_Images()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Images/");
        }        
        public static String GetDataDir_AsposePdfFacades_StampsWatermarks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Stamps-Watermarks/");
        }
        public static String GetDataDir_AsposePdfFacades_Printing()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Printing/");
        }
        public static String GetDataDir_AsposePdfFacades_Text()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Text/");
        }
        public static String GetDataDir_AsposePdfFacades_WorkingDocuments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Working-Documents/");
        }
        public static String GetDataDir_AsposePdfGenerator_Conversion()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Conversion/");
        }
        public static String GetDataDir_AsposePdfGenerator_Paragraphs()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Paragraphs/");
        }
        public static String GetDataDir_AsposePdfGenerator_Sections()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Sections/");
        }
        public static String GetDataDir_AsposePdfGenerator_Text()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Text/");
        }
        public static String GetDataDir_AsposePdfGenerator_WorkingDocuments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Working-Documents/");
        }
        public static String GetDataDir_AsposePdfGenerator_General()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/General/");
        }
        public static String GetDataDir_AsposePdfGenerator_Graphs()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Graphs/");
        }
        public static String GetDataDir_AsposePdfGenerator_Images()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Images/");
        }
        public static String GetDataDir_AsposePdfGenerator_Headings()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Headings/");
        }
        public static String GetDataDir_AsposePdfGenerator_Tables()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Tables/");
        }
        public static String GetDataDir_AsposePdfGenerator_Hyperlinks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Hyperlinks/");
        }
        public static String GetDataDir_AsposePdfGenerator_SecurityFeatures()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/SecurityFeatures/");
        }
        public static String GetDataDir_AsposePdfGenerator_Attachments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Attachments/");
        }
        public static String GetDataDir_AsposePdfGenerator_UtilityFeatures()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/UtilityFeatures/");
        }
        public static String GetDataDir_AsposePdfGenerator_AdvanceFeatures()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/AdvanceFeatures/");
        }
        public static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return Path.Combine(startDirectory, "Data\\");
        }   
    }
}