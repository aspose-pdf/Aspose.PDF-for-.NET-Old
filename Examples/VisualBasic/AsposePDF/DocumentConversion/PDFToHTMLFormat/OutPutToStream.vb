Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class OutPutToStream
        Public Shared Sub Run()
            Try
                ' ExStart:OutPutToStream
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

                ' Tune conversion params
                Dim newOptions As New HtmlSaveOptions()
                newOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground
                newOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats
                newOptions.PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedAllIntoHtml
                newOptions.LettersPositioningMethod = HtmlSaveOptions.LettersPositioningMethods.UseEmUnitsAndCompensationOfRoundingErrorsInCss
                newOptions.SplitIntoPages = False
                ' Force write HTMLs of all pages into one output document
                newOptions.CustomHtmlSavingStrategy = New HtmlSaveOptions.HtmlPageMarkupSavingStrategy(AddressOf SavingToStream)
                ' We can use some non-existing puth as result file name - all real saving will be done
                ' In our custom method SavingToStream() (it' S follows this one)          

                doc.Save(dataDir & Convert.ToString("OutPutToStream_out_.html"), newOptions)
                ' ExEnd:OutPutToStream
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        ' ExStart:SavingToStream
        Private Shared Sub SavingToStream(htmlSavingInfo As HtmlSaveOptions.HtmlPageMarkupSavingInfo)
            Dim resultHtmlAsBytes As Byte() = New Byte(Convert.ToInt32(htmlSavingInfo.ContentStream.Length - 1)) {}
            htmlSavingInfo.ContentStream.Read(resultHtmlAsBytes, 0, resultHtmlAsBytes.Length)
            ' Here You can use any writable stream, file stream is taken just as example
            Dim fileName As String = "stream_out_.html"
            Dim outStream As Stream = File.OpenWrite(fileName)
            outStream.Write(resultHtmlAsBytes, 0, resultHtmlAsBytes.Length)
        End Sub
        ' ExEnd:SavingToStream

        ' ExStart:OutPutToStreamHelper
        Shared _folderForReferencedResources_34748 As String
        Public Shared Sub PDFNEWNET_34748()
            '-----------------------------------------------------
            ' 1) Tune paths and set license
            '-----------------------------------------------------
            Dim license As New License()
            license.SetLicense("F:\_Sources\Aspose_5\trunk\testdata\License\Aspose.Total.lic")
            Dim pdfDocument As New Document("F:\ExternalTestsData\34748_36189.pdf")
            Dim outHtmlFile As String = "F:\ExternalTestsData\34748.html"
            _folderForReferencedResources_34748 = "F:\ExternalTestsData\out_34748\"
            '-----------------------------------------------------
            ' 2) Clean results if they already present
            '-----------------------------------------------------
            If Directory.Exists(_folderForReferencedResources_34748) Then
                Directory.Delete(_folderForReferencedResources_34748, True)
            End If
            File.Delete(outHtmlFile)
            '-----------------------------------------------------
            ' Create HtmlSaveOption with tested feature
            '-----------------------------------------------------
            Dim saveOptions As New HtmlSaveOptions()
            saveOptions.CustomResourceSavingStrategy = New HtmlSaveOptions.ResourceSavingStrategy(AddressOf Strategy_11_CUSTOM_SAVE_OF_FONTS_AND_IMAGES)
            saveOptions.CustomCssSavingStrategy = New HtmlSaveOptions.CssSavingStrategy(AddressOf Strategy_11_CSS_WriteCssToPredefinedFolder)
            saveOptions.CustomStrategyOfCssUrlCreation = New HtmlSaveOptions.CssUrlMakingStrategy(AddressOf Strategy_11_CSS_ReturnResultPathInPredefinedTestFolder)

            Using outStream As Stream = File.OpenWrite(outHtmlFile)
                pdfDocument.Save(outStream, saveOptions)
            End Using
        End Sub

        Private Shared Sub Strategy_11_CSS_WriteCssToPredefinedFolder(resourceInfo As HtmlSaveOptions.CssSavingInfo)
            If Not Directory.Exists(_folderForReferencedResources_34748) Then
                Directory.CreateDirectory(_folderForReferencedResources_34748)
            End If
            Dim path__1 As String = _folderForReferencedResources_34748 & Path.GetFileName(resourceInfo.SupposedURL)
            Dim reader As System.IO.BinaryReader = New BinaryReader(resourceInfo.ContentStream)
            System.IO.File.WriteAllBytes(path__1, reader.ReadBytes(CInt(resourceInfo.ContentStream.Length)))
        End Sub
        Private Shared Function Strategy_11_CSS_ReturnResultPathInPredefinedTestFolder(requestInfo As HtmlSaveOptions.CssUrlRequestInfo) As String
            Return "file:///" + _folderForReferencedResources_34748.Replace("\", "/") + "css_style{0}.css"
        End Function
        Private Shared Function Strategy_11_CUSTOM_SAVE_OF_FONTS_AND_IMAGES(resourceSavingInfo As SaveOptions.ResourceSavingInfo) As String
            If Not Directory.Exists(_folderForReferencedResources_34748) Then
                Directory.CreateDirectory(_folderForReferencedResources_34748)
            End If
            Dim path__1 As String = _folderForReferencedResources_34748 & Path.GetFileName(resourceSavingInfo.SupposedFileName)
            ' The first path of this method is for saving fonts
            Dim contentReader As System.IO.BinaryReader = New BinaryReader(resourceSavingInfo.ContentStream)
            System.IO.File.WriteAllBytes(path__1, contentReader.ReadBytes(CInt(resourceSavingInfo.ContentStream.Length)))
            Dim urlThatWillBeUsedInHtml As String = "file:///" + _folderForReferencedResources_34748.Replace("\", "/") + Path.GetFileName(resourceSavingInfo.SupposedFileName)
            Return urlThatWillBeUsedInHtml
        End Function
        ' ExEnd:OutPutToStreamHelper
    End Class
End Namespace