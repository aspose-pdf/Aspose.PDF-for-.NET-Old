Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Annotations
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Attachments
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Bookmarks
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.DocumentConversion
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Forms
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Images
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.LinksActions
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Pages
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.SecuritySignatures
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.StampsWatermarks
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Tables
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Text
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.WorkingDocuments
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Operators
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Miscellaneous
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Graphs
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.Headings
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.DocumentConversion.PDFToHTMLFormat
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDF.TechnicalArticles

Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.General
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Text
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Sections
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Paragraphs
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.WorkingDocuments
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Tables
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Headings
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Graphs
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Images
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Hyperlinks
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Attachments
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.SecurityFeatures
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.UtilityFeatures
Imports Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.AdvanceFeatures

Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Text
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Annotations
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Attachments
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.WorkingDocument
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Images
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Bookmarks
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.LinksActions
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Forms
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Printing
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Pages.Append
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Pages.ConcatenateDocuments
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Pages.DeletePages
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Pages.ExtractPages
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Pages.InsertPages
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Pages.MakeBooklet
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Pages.MakeNUp
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Pages.SplitPages
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Pages.ManipulatePageProperties
Imports Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.TechnicalArticles

Module RunExamples
    Sub Main()
        Console.WriteLine("Open RunExamples.cs. " & vbLf & "In Main() method uncomment the example that you want to run.")
        Console.WriteLine("=====================================================")
        '' Uncomment the one you want to try out

        '' =====================================================
        '' =====================================================
        '' Aspose.Pdf 
        '' =====================================================
        '' =====================================================

        '''' Text
        '''' =====================================================            
        ' AsposePDF.Text.ExtractTextPage.Run()
        ' ReplaceTextAll.Run()
        ' SearchAndGetTextAll.Run()
        ' SearchAndGetTextPage.Run()
        ' SearchRegularExpression.Run()
        ' ReplaceTextonRegularExpression.Run()
        ' ReplaceFirstOccurrence.Run()
        ' SearchTextSegmentsPage.Run()
        ' AsposePDF.Text.AddText.Run()
        ' ExtractTextUsingTextDevice.Run()
        ' ReplaceFonts.Run()
        ' HighlightCharacterInPDF.Run()
        ' AddHTMLUsingDOM.Run()
        ' RearrangeContentsUsingTextReplacement.Run()
        ' FootAndEndNotes.Run()
        ' SearchTextAndAddHyperlink.Run()
        ' TextAndImageAsParagraph.Run()
        ' ExtractColumnsText.Run()
        ' SpecifyCharacterSpacing.Run()
        ' CreateMultiColumnPdf.Run()
        ' AsposePDF.Text.CustomTabStops.Run()
        ' RenderingReplaceableSymbols.Run()
        ' ReplaceableSymbolsInHeaderFooter.Run()
        ' AsposePDF.Text.AddTransparentText.Run()

        '''' Images
        '''' =====================================================   
        ' AsposePDF.Images.AddImage.Run()
        ' DeleteImages.Run()
        ' AsposePDF.Images.ExtractImages.Run()
        ' AsposePDF.Images.ReplaceImage.Run()
        ' PagesToImages.Run()
        ' ConvertAllPagesToPNG.Run()
        ' PageToTIFF.Run()
        ' AllPagesToTIFF.Run()
        ' BradleyAlgorithm.Run()
        ' ConvertAllPagesToEMF.Run()
        ' PageToEMF.Run()
        ' CGMImageToPDF.Run()
        ' LargeCGMImageToPDF.Run()
        ' ImageToPDF.Run()
        ' ConvertToBMP.Run()
        ' IdentifyImages.Run()
        ' ConvertPageRegionToDOM.Run()

        '''' Stamps-Watermarks
        '''' =====================================================   
        ' AddTextStamp.Run()
        ' AddImageStamp.Run()
        ' AddPDFPageStamp.Run()
        ' PageNumberStamps.Run()
        ' TextinHeader.Run()
        ' TextinFooter.Run()
        ' ImageinHeader.Run()
        ' ImageInFooter.Run()
        ' AddingDifferentHeaders.Run()
        ' DefineAlignment.Run()
        ' AddDateTimeStamp.Run()

        '''' Attachments
        '''' =====================================================   
        ' AsposePDF.Attachments.AddAttachment.Run()
        ' GetAlltheAttachments.Run()
        ' GetIndividualAttachment.Run()
        ' GetAttachmentInfo.Run()
        ' DisableFilesCompression.Run()

        '''' Pages
        '''' =====================================================   
        ' GetNumberofPages.Run()
        ' GetPageCount.Run()
        ' GetProperties.Run()
        ' ConcatenatePdfFiles.Run()
        ' InsertEmptyPage.Run()
        ' InsertEmptyPageAtEnd.Run()
        ' SplitToPages.Run()
        ' GetParticularPage.Run()
        ' DeleteParticularPage.Run()
        ' UpdateDimensions.Run()
        ' GetDimensions.Run()
        ' ImageAsBackground.Run()
        ' DeterminePageColor.Run()
        ' ChangeOrientation.Run()
        ' ZoomToPageContents.Run()

        '''' Working-Document
        '''' =====================================================   
        ' SetDocumentWindow.Run()
        ' GetDocumentWindow.Run()
        ' ValidatePDFAStandard.Run()
        'OptimizeDocument.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDF.WorkingDocuments.SetFileInfo.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDF.WorkingDocuments.GetFileInfo.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDF.WorkingDocuments.SetXMPMetadata.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDF.WorkingDocuments.GetXMPMetadata.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDF.WorkingDocuments.SetZoomFactor.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDF.WorkingDocuments.GetZoomFactor.Run()
        ' AddTOC.Run()
        'OptimizeFileSize.Run()
        ' TrimWhiteSpace.Run()
        ' AddJavaScriptToPage.Run()
        ' AddRemoveJavascriptToDoc.Run()
        ' AddLayers.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDF.WorkingDocuments.EmbedFont.Run()
        ' EmbedFontWhileDocCreation.Run()
        ' ConvertFromRGBToGrayscale.Run()
        ' SetExpiryDate.Run()

        '''' Bookmarks
        '''' =====================================================   
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDF.Bookmarks.AddBookmark.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDF.Bookmarks.AddChildBookmark.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDF.Bookmarks.DeleteAllBookmarks.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDF.Bookmarks.DeleteParticularBookmark.Run()
        ' GetBookmarks.Run()
        ' GetChildBookmarks.Run()
        ' UpdateBookmarks.Run()
        ' UpdateChildBookmarks.Run()
        ' InheritZoom.Run()
        ' ExpandBookmarks.Run()

        '''' Annotations
        '''' =====================================================   
        ' AddAnnotation.Run()
        ' InvisibleAnnotation.Run()
        ' AddlnkAnnotation.Run()
        ' LnkAnnotationLineWidth.Run()
        ' GetParticularAnnotation.Run()
        ' GetAllAnnotationsFromPage.Run()
        ' DeleteParticularAnnotation.Run()
        ' DeleteAllAnnotationsFromPage.Run()
        ' AddSwfFileAsAnnotation.Run()
        ' SetFreeTextAnnotationFormatting.Run()
        ' StrikeOutWords.Run()

        '''' Forms
        '''' =====================================================   
        ' TextBox.Run()
        ' RadioButtonWithOptions.Run()
        ' ComboBox.Run()
        ' DeleteFormField.Run()
        ' ModifyFormField.Run()
        ' FillFormField.Run()
        ' ArabicTextFilling.Run()
        ' SelectRadioButton.Run()
        ' GetValueFromField.Run()
        ' GetValueFromField.Run()
        ' SetFieldLimit.Run()
        ' MoveFormField.Run()
        ' AddTooltipToField.Run()
        ' GetFieldsFromRegion.Run()
        ' FormFieldFont14.Run()
        ' DynamicXFAToAcroForm.Run()
        ' FillXFAFields.Run()
        ' GetXFAProperties.Run()
        ' DetermineRequiredField.Run()
        ' SetJavaScript.Run()
        ' HorizontallyAndVerticallyRadioButtons.Run()
        ' GroupedCheckBoxes.Run()

        '''' Links-Actions
        '''' =====================================================   
        ' CreateApplicationLink.Run()
        ' CreateDocumentLink.Run()
        ' RemoveOpenAction.Run()
        ' ExtractLinks.Run()
        ' AddHyperlink.Run()
        ' UpdateLinks.Run()
        ' SetDestinationLink.Run()
        ' UpdateLinkTextColor.Run()
        ' SpecifyPageWhenViewing.Run()
        ' GetHyperlinkDestinations.Run()
        ' GetHyperlinkText.Run()
        ' CreateLocalHyperlink.Run()

        '''' TechnicalArticles
        '''' =====================================================            
        ' CreatePDFPortfolio.Run()
        ' ExtractFilesFromPortfolio.Run()
        ' RemoveFilesFromPortfolio.Run()

        '''' Security-Signatures
        '''' =====================================================   
        ' Encrypt.Run()
        ' Decrypt.Run()
        ' ChangePassword.Run()
        ' IsPasswordProtected.Run()
        ' DetermineCorrectPassword.Run()
        ' ExtractingImage.Run()
        ' SetPrivileges.Run()

        '''' Operators
        '''' =====================================================   
        ' DrawXFormOnPage.Run()
        ' PDFOperators.Run()
        ' RemoveGraphicsObjects.Run()

        '''' Miscellaneous
        '''' =====================================================   
        ' GetBuildInformation.Run()
        ' UseMeasureWithLineAnnotation.Run()
        ' UseMeasureWithPolylineAnnotation.Run()

        '''' Tables
        '''' =====================================================   
        ' AddTable.Run()
        ' AutoFitToWindow.Run()
        ' MarginsOrPadding.Run()
        ' SetBorder.Run()
        ' AsposePDF.Tables.IntegrateWithDatabase.Run()
        ' RenderTable.Run()
        ' AddSVGObject.Run()
        ' ExtractBorder.Run()
        ' InsertPageBreak.Run()
        ' DetermineTableBreak.Run()

        '''' Graphs
        '''' =====================================================   
        ' CreateFilledRectangle.Run()
        ' AddLineObject.Run()
        ' DashLength.Run()
        ' DrawingLine.Run()
        ' CreateRectangleWithAlphaColor.Run()
        ' AddDrawing.Run()
        ' ControlRectangleZOrder.Run()

        '''' Headings
        '''' =====================================================   
        ' ApplyNumberStyle.Run()

        '''' DocumentConversion
        '''' =====================================================   
        ' PDFToPDFA.Run()
        ' PDFToPDFA3b.Run()
        ' AddAttachmentToPDFA.Run()
        ' PDFToDOC.Run()
        ' PDFToTeX.Run()
        ' SVGToPDF.Run()
        ' GetSVGDimensions.Run()
        ' PDFToEPUB.Run()
        ' PDFToXPS.Run()
        ' PDFToXLS.Run()
        ' PDFToSVG.Run()
        ' PDFToXML.Run()
        ' MHTToPDF.Run()
        ' TextToPDF.Run()
        ' AsposePDF.CGMToPDF.Run()
        ' PDFToPPT.Run()
        ' PDFAToPDF.Run()
        ' XMLToPDF.Run()

        '' =====================================================
        '' =====================================================
        '' Aspose.Pdf.Generator
        '' =====================================================
        '' =====================================================

        '''' General
        '''' =====================================================            
        ' HelloWorldUsingXML.Run()
        ' HelloWorldUsingAPI.Run()
        ' HelloWorldUsingXMLAndAPI.Run()
        ' HelloWorldUsingXSLT.Run()
        ' FloatingBoxLook.Run()
        ' PositionFloatingBox.Run()

        '''' Working-Document
        '''' =====================================================            
        ' SetDocumentInfo.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.WorkingDocuments.SetZoomFactor.Run()
        ' SetAppearance.Run()
        ' SetPageTransitionEffect.Run()
        ' AddJavaScript.Run()
        ' AddingXMPMetaData.Run()

        '''' Sections
        '''' =====================================================            
        ' SetPageBackgroundImage.Run()
        ' SetPageSize.Run()
        ' SetPageMargin.Run()
        ' SetHeaderAndFooter.Run()
        ' AdvancedHeaderAndFooter.Run()

        '''' Paragraphs
        '''' =====================================================            
        ' SetMargins.Run()
        ' AssignID.Run()
        ' Render.Run()

        '''' Text
        '''' =====================================================            
        ' InlineParagraph.Run()
        ' TextLayout.Run()
        ' InheritTextFormat.Run()
        ' SymbolFont.Run()
        ' PFMFont.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Text.EmbedFont.Run()
        ' ReplaceableSymbols.Run()
        ' RTLLanguages.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Text.CustomTabStops.Run()
        ' HyperlinkTags.Run()
        ' SuperSubscript.Run()
        ' AddFootnotes.Run()
        ' AddEndnote.Run()
        ' InlineRadioButton.Run()

        '''' Graphs
        '''' =====================================================            
        ' GraphCoordinate.Run()
        ' GraphFormat.Run()
        ' RotationAndScaling.Run()

        '''' Images
        '''' =====================================================            
        ' ImageFromLocalDisk.Run()
        ' ImageFromMemory.Run()
        ' ImageFromWeb.Run()
        ' CCITTImage.Run()

        '''' Headings
        '''' =====================================================            
        ' ApplyingNumber.Run()
        ' SpecifyHeadingLevel.Run()
        ' SystemBullets.Run()
        ' UserDefinedBullets.Run()

        '''' Tables
        '''' =====================================================            
        ' SetBorderAndPadding.Run()
        ' SetColumnWidthAndSpan.Run()
        ' TableAndRowSplitting.Run()
        ' CompleteClone.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Tables.IntegrateWithDatabase.Run()
        ' CellInformation.Run()
        ' RowAndColumnFormat.Run()
        ' NestedTables.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Tables.RoundedCornerTable.Run()
        ' NonEnglishText.Run()

        '''' Hyperlinks
        '''' =====================================================            
        ' HyperlinkPages.Run()
        ' HyperlinkOtherPdf.Run()
        ' HyperlinkNonPdfFile.Run()
        ' HyperlinkToWeb.Run()

        '''' Attachments
        '''' =====================================================            
        ' AttachAnyFile.Run()
        ' AttachNoteAnnotation.Run()
        ' CustomizeNotePosition.Run()

        '''' SecurityFeatures
        '''' =====================================================            
        ' SetPassword.Run()
        ' SetEncryption.Run()
        ' AllowDisallowPrivileges.Run()

        '''' UtilityFeatures
        '''' =====================================================            
        ' AddingList.Run()
        ' AddThreeList.Run()
        ' SpecifyListItem.Run()
        ' ManipulatingFormFields.Run()
        ' ManipulatingColumns.Run()
        ' CustomizingWatermark.Run()
        ' CreatePdf.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.UtilityFeatures.AddBookmark.Run()
        ' AddTableOfContents.Run()

        '''' Conversion
        '''' =====================================================            
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Conversion.XSLFOToPDF.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Conversion.PCLToPDF.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Conversion.SVGToPDF.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Conversion.HTMLToPDF.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Conversion.WebToPDF.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePdfGenerator.Conversion.HTMLToPDFUsingStream.Run()

        '''' AdvanceFeatures
        '''' =====================================================            
        ' TableMinimumColumnWidth.Run()
        ' AddPageBorder.Run()
        ' MergeXMLFiles.Run()
        ' XSLToPdf.Run()
        ' XMLAsTemplate.Run()
        ' LoadDataInXMLTemplate.Run()

        '' =====================================================
        '' =====================================================
        '' Aspose.Pdf.Facades
        '' =====================================================
        '' =====================================================

        '''' Text
        '''' =====================================================            
        ' ReplaceText.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Text.ReplaceTextPage.Run()
        ' ExtractText.Run()
        ' ExtractTextPageRange.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Text.ExtractTextPage.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Text.AddText.Run()

        '''' Annotations
        '''' =====================================================            
        ' AddFreeTextAnnotation.Run()
        ' CreateFileAnnotation.Run()
        ' DeleteAllAnnotations.Run()
        ' UpdateAnnotations.Run()
        ' ImportAnnotations.Run()
        ' ExportAnnotations.Run()

        '''' Attachments
        '''' =====================================================            
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Attachments.AddAttachment.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Attachments.AddAttachmentStream.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Attachments.DeleteAllAttachments.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Attachments.ExtractAllAttachments.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Attachments.GetAttachmentNames.Run()

        '''' Working-Document
        '''' =====================================================   
        ' SetViewerPreference.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.WorkingDocument.SetFileInfo.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.WorkingDocument.GetFileInfo.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.WorkingDocument.SetXMPMetadata.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.WorkingDocument.GetXMPMetadata.Run()
        ' PageBreak.Run()

        '''' Images
        '''' =====================================================   
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Images.ReplaceImage.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Images.ExtractImages.Run()
        ' ExtractImagesStream.Run()
        ' ExtractImagesPage.Run()
        ' DeleteAllImages.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Images.AddImage.Run()
        ' ConvertPDFPages.Run()
        ' ConvertToTIFFSettings.Run()
        ' ConvertToTIFF.Run()
        ' ConvertPageRegion.Run()
        ' ExtractImageExtractionMode.Run()

        '''' Stamps-Watermarks
        '''' =====================================================   
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks.AddTextStampAll.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks.AddTextStampPage.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks.AddImageStampAll.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks.AddImageStampPage.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks.AddPageStampAll.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks.AddPageStampPage.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks.AddPageNumber.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks.AddHeader.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks.AddFooter.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks.AddImageFooter.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.StampsWatermarks.AddImageHeader.Run()

        '''' Bookmarks
        '''' =====================================================   
        ' CreateBookmarksAll.Run()
        ' CreateBookmarksPagesProperties.Run()
        ' CreateBookmarkPage.Run()
        ' CreateBookmarkPageRange.Run()
        ' UpdateBookmark.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Bookmarks.DeleteAllBookmarks.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Bookmarks.DeleteABookmark.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Bookmarks.AddBookmark.Run()
        ' Aspose.Pdf.Examples.VisualBasic.AsposePDFFacades.Bookmarks.AddChildBookmark.Run()
        ' ImportFromXML.Run()
        ' ExportToXML.Run()
        ' ExtractBookmarks.Run()
        ' GetFromPDF.Run()

        '''' Links-Actions
        '''' =====================================================   
        ' CreateAppLink.Run()
        ' CreateAppLinkWithColor.Run()
        ' CreateLocalLink.Run()
        ' CreateJSLink.Run()
        ' RemoveAction.Run()
        ' CreateDocAdditionalAction.Run()
        ' CreateDocLink.Run()

        '''' Forms
        '''' =====================================================   
        ' FillFormFieldF.Run()
        ' AddFormField.Run()
        ' GetFormFieldValue.Run()
        ' DeleteField.Run()
        ' MoveField.Run()
        ' GetFieldValue.Run()
        ' FlattenAllFields.Run()
        ' DecorateParticularField.Run()
        ' DecorateFields.Run()
        ' AddListItem.Run()
        ' DeleteListItem.Run()
        ' SetSubmitButtonURL.Run()
        ' SetJSPushButton.Run()
        ' CopyInnerField.Run()
        ' CopyOuterField.Run()
        ' ExportDataToXML.Run()
        ' ExportDataToPdf.Run()
        ' ImportDataFromPdf.Run()
        ' ExportDataToXFDF.Run()
        ' ImportDataFromXFDF.Run()

        '''' Printing
        '''' =====================================================   
        ' PrintToDefaultPrinter.Run()
        ' PrintoXPSPrinter.Run()
        ' PdfToPostScript.Run()
        ' CheckPrintJobStatus.Run()
        ' PrintPageRange.Run()

        '''' Pages
        '''' =====================================================

        '''''' Append
        '''''' =====================================================   
        ' AppendFiles.Run()
        ' AppendArrayOfFiles.Run()
        ' AppendFilesUsingStreams.Run()
        ' AppendArrayOfFilesUsingStream.Run()

        '''''' ConcatenateDocuments
        '''''' =====================================================   
        ' ConcatenateUsingPath.Run()
        ' ConcatenateWithBlankPdf.Run()
        ' ConcatenateArrayOfFilesWithPath.Run()
        ' ConcatenateUsingStreams.Run()
        ' ConcatenateBlankPdfUsingStreams.Run()
        ' ConcatenateArrayOfPdfUsingStreams.Run()

        '''''' DeletePages
        '''''' =====================================================   
        ' DeletePagesUsingFilePath.Run()
        ' DeletePagesUsingStream.Run()

        '''''' ExtractPages
        '''''' =====================================================   
        ' ExtractPagesBetweenNumbers.Run()
        ' ExtractArrayOfPages.Run()
        ' ExtractPagesBetweenTwoNumbersUsingStreams.Run()
        ' ExtractArrayOfPagesUsingStreams.Run()

        '''''' InsertPages
        '''''' =====================================================   
        ' InsertPagesBetweenNumbers.Run()
        ' InsertArrayOfPages.Run()
        ' InsertPagesUsingStreams.Run()

        '''''' MakeBooklet
        '''''' =====================================================   
        ' MakeBookletUsingPaths.Run()
        ' MakeBookletUsingPageSizeAndPaths.Run()
        ' MakeBookletUsingStreams.Run()
        ' MakeBookletUsingPageSizeAndStreams.Run()

        '''''' SplitPages
        '''''' =====================================================   
        ' SplitPagesUsingPaths.Run()
        ' SplitPagesUsingStreams.Run()
        ' SplitPagesToBulkUsingPaths.Run()
        ' SplitPagesToBulkUsingStreams.Run()
        ' SplitPagesToEndUsingPaths.Run()
        ' SplitToIndividualPagesUsingPaths.Run()

        '''''' ManipulatePageProperties
        '''''' =====================================================   
        ' GetPageProperties.Run()
        ' SetPageProperties.Run()
        ' ResizePageContents.Run()

        '''' TechnicalArticles
        '''' =====================================================            
        ' DifferenceBetweenFile.Run()
        ' PdfFileEditorFeatures.Run()
        ' ExtensibleMetadataPlatform.Run()
        ' EditPdfPages.Run()
        ' ConcatenatingAllPdfFiles.Run()
        ' ConcatenatePDFForms.Run()
        ' PdfContainsTextOrImages.Run()
        ' ChangePageSizes.Run()
        ' PageRotation.Run()
        ' AnnotationsImport.Run()
        ' AnnotationsExport.Run()
        ' RotatingStamp.Run()
        ' ConcatenateMultiplePDFUsingMemoryStream.Run()
        ' FormEditorFeatures.Run()

        ' Stop before exiting
        Console.WriteLine(vbLf & vbLf & "Program Finished. Press any key to exit....")
        Console.ReadKey()
    End Sub
    Public Function GetDataDir_AsposePdf_TechnicalArticles() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Technical-Articles/")
    End Function
    Public Function GetDataDir_AsposePdfFacades_TechnicalArticles() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Technical-Articles/")
    End Function

    Public Function GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/DocumentConversion/PDFToHTMLFormat/")
    End Function

    Public Function GetDataDir_AsposePdf_Headings() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Headings/"))
    End Function
    Public Function GetDataDir_AsposePdf_Graphs() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Graphs/"))
    End Function
    Public Function GetDataDir_AsposePdf_Annotations() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Annotations/"))
    End Function
    Public Function GetDataDir_AsposePdf_Miscellaneous() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Miscellaneous/"))
    End Function

    Public Function GetDataDir_AsposePdf_Attachments() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Attachments/"))
    End Function
    Public Function GetDataDir_AsposePdf_Bookmarks() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Bookmarks/"))
    End Function
    Public Function GetDataDir_AsposePdf_DocumentConversion() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/DocumentConversion/"))
    End Function
    Public Function GetDataDir_AsposePdf_Forms() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Forms/"))
    End Function
    Public Function GetDataDir_AsposePdf_Images() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Images/"))
    End Function
    Public Function GetDataDir_AsposePdfFacades_SecuritySignatures() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Security-Signatures/")
    End Function
    Public Function GetDataDir_AsposePdf_LinksActions() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Links-Actions/"))
    End Function
    Public Function GetDataDir_AsposePdf_Operators() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Operators/"))
    End Function
    Public Function GetDataDir_AsposePdf_Pages() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Pages/"))
    End Function
    Public Function GetDataDir_AsposePdf_SecuritySignatures() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Security-Signatures/"))
    End Function
    Public Function GetDataDir_AsposePdf_StampsWatermarks() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Stamps-Watermarks/"))
    End Function
    Public Function GetDataDir_AsposePdf_Tables() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Tables/"))
    End Function
    Public Function GetDataDir_AsposePdf_Text() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Text/"))
    End Function
    Public Function GetDataDir_AsposePdf_WorkingDocuments() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePDF/Working-Document/"))
    End Function
    Public Function GetDataDir_AsposePdfFacades_Annotations() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfFacades/Annotations/"))
    End Function

    Public Function GetDataDir_AsposePdfFacades_Attachments() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfFacades/Attachments/"))
    End Function
    Public Function GetDataDir_AsposePdfFacades_Bookmarks() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfFacades/Bookmarks/"))
    End Function
    Public Function GetDataDir_AsposePdfFacades_LinksActions() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Links-Actions/")
    End Function
    Public Function GetDataDir_AsposePdfFacades_Forms() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfFacades/Forms/"))
    End Function
    Public Function GetDataDir_AsposePdfFacades_Images() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfFacades/Images/"))
    End Function
    Public Function GetDataDir_AsposePdfFacades_Pages() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Pages/")
    End Function

    Public Function GetDataDir_AsposePdfFacades_StampsWatermarks() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfFacades/Stamps-Watermarks/"))
    End Function
    Public Function GetDataDir_AsposePdfFacades_Printing() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfFacades/Printing/"))
    End Function
    Public Function GetDataDir_AsposePdfFacades_Text() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfFacades/Text/"))
    End Function
    Public Function GetDataDir_AsposePdfFacades_WorkingDocuments() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfFacades/Working-Document/"))
    End Function
    Public Function GetDataDir_AsposePdfGenerator_Conversion() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfGenerator/Conversion/"))
    End Function
    Public Function GetDataDir_AsposePdfGenerator_TechnicalArticles() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Technical-Articles/")
    End Function
    Public Function GetDataDir_AsposePdfGenerator_Paragraphs() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfGenerator/Paragraphs/"))
    End Function
    Public Function GetDataDir_AsposePdfGenerator_Sections() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfGenerator/Sections/"))
    End Function
    Public Function GetDataDir_AsposePdfGenerator_Text() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfGenerator/Text/"))
    End Function
    Public Function GetDataDir_AsposePdfGenerator_General() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfGenerator/General/"))
    End Function
    Public Function GetDataDir_AsposePdfGenerator_WorkingDocuments() As [String]
        Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("AsposePdfGenerator/Working-Documents/"))
    End Function
    Public Function GetDataDir_AsposePdfGenerator_Graphs() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Graphs/")
    End Function
    Public Function GetDataDir_AsposePdfGenerator_Images() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Images/")
    End Function
    Public Function GetDataDir_AsposePdfGenerator_Headings() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Headings/")
    End Function
    Public Function GetDataDir_AsposePdfGenerator_Tables() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Tables/")
    End Function
    Public Function GetDataDir_AsposePdfGenerator_Hyperlinks() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Hyperlinks/")
    End Function
    Public Function GetDataDir_AsposePdfGenerator_SecurityFeatures() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/SecurityFeatures/")
    End Function
    Public Function GetDataDir_AsposePdfGenerator_Attachments() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/Attachments/")
    End Function
    Public Function GetDataDir_AsposePdfGenerator_UtilityFeatures() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/UtilityFeatures/")
    End Function
    Public Function GetDataDir_AsposePdfGenerator_AdvanceFeatures() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "AsposePdfGenerator/AdvanceFeatures/")
    End Function
    Public Function GetDataDir_Data() As String
        Dim parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent
        Dim startDirectory As String = Nothing
        If parent IsNot Nothing Then
            Dim directoryInfo = parent.Parent
            If directoryInfo IsNot Nothing Then
                startDirectory = directoryInfo.FullName
            End If
        Else
            startDirectory = parent.FullName
        End If
        Return Path.Combine(startDirectory, "Data\")
    End Function
End Module