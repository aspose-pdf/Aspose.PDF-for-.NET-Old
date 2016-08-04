Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class SplitCSSToPages
        Public Shared Sub Run()
            Try
                ' ExStart:SplitCSSToPages
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                ' 1) Clean-up target folders
                Dim htmlFile As String = Path.GetFullPath(dataDir & Convert.ToString("resultant.html"))
                Dim imagesDir As String = Path.GetDirectoryName(htmlFile) + "\35942_files"
                Dim cssDir As String = Path.GetDirectoryName(htmlFile) + "\35942_css_files"
                If Directory.Exists(imagesDir) Then
                    Directory.Delete(imagesDir, True)
                End If


                If Directory.Exists(cssDir) Then
                    Directory.Delete(cssDir, True)
                End If



                ' 2) Create document for conversion
                Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))

                ' 3) Tune conversion options
                Dim options As New HtmlSaveOptions()
                options.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsPngImagesEmbeddedIntoSvg
                '<- to get compatibility with previous behavior and therefore same result of tests
                ' Split HTML output into pages
                options.SplitIntoPages = True
                ' Split css into pages
                options.SplitCssIntoPages = True
                options.CustomCssSavingStrategy = New HtmlSaveOptions.CssSavingStrategy(AddressOf Strategy_4_CSS_MULTIPAGE_SAVING_RIGHT_WAY)
                options.CustomStrategyOfCssUrlCreation = New HtmlSaveOptions.CssUrlMakingStrategy(AddressOf Strategy_5_CSS_MAKING_CUSTOM_URL_FOR_MULTIPAGING)
                ' 3) Do conversion
                pdfDocument.Save(htmlFile, options)
                ' ExEnd:SplitCSSToPages
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        ' ExStart:SplitCSSToPagesHelpers
        Private Shared Sub Strategy_4_CSS_MULTIPAGE_SAVING_RIGHT_WAY(partSavingInfo As HtmlSaveOptions.CssSavingInfo)
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

            Dim outPath As String = (dataDir & Convert.ToString("style_xyz_page")) + partSavingInfo.CssNumber.ToString() + ".css"
            Dim reader As System.IO.BinaryReader = New BinaryReader(partSavingInfo.ContentStream)
            System.IO.File.WriteAllBytes(outPath, reader.ReadBytes(CInt(partSavingInfo.ContentStream.Length)))
        End Sub

        Private Shared Function Strategy_5_CSS_MAKING_CUSTOM_URL_FOR_MULTIPAGING(requestInfo As HtmlSaveOptions.CssUrlRequestInfo) As String
            Return "/document-viewer/GetCss?cssId=4544554445_page{0}"
        End Function
        ' ExEnd:SplitCSSToPagesHelpers
    End Class
End Namespace