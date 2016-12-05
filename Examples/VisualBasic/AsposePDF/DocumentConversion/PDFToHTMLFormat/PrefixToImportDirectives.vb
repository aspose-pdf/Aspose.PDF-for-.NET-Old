Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class PrefixToImportDirectives
        Private Shared _folderForReferencedResources_36435 As String
        Public Shared Sub Run()
            Try
                ' ExStart:PrefixToImportDirectives
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()
                Dim linceseFile As String = ""
                ' E.g @"F:\_Sources\Aspose.Total.lic"
                Dim license As New License()
                license.SetLicense(linceseFile)
                Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))
                Dim outHtmlFile As String = dataDir & Convert.ToString("PrefixToImportDirectives_out_.html")
                _folderForReferencedResources_36435 = dataDir
                ' Create HtmlSaveOption with tested feature
                Dim saveOptions As New HtmlSaveOptions()
                saveOptions.CustomStrategyOfCssUrlCreation = New HtmlSaveOptions.CssUrlMakingStrategy(AddressOf Strategy_10_CSS_ReturnResultPathInPredefinedTestFolder)
                saveOptions.CustomCssSavingStrategy = New HtmlSaveOptions.CssSavingStrategy(AddressOf Strategy_10_CSS_WriteCssToResourceFolder)
                '----------------------------------------------------------------------------
                ' Run converter
                '----------------------------------------------------------------------------
                pdfDocument.Save(outHtmlFile, saveOptions)
                ' ExEnd:PrefixToImportDirectives
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        ' ExStart:PrefixToImportDirectivesHelper
        Private Shared Sub Strategy_10_CSS_WriteCssToResourceFolder(resourceInfo As HtmlSaveOptions.CssSavingInfo)
            ' -------------------------------------------------------
            ' This is only one of possible implementation of saving
            ' You can write and use Your own implementation if You will
            ' -------------------------------------------------------

            ' Get CSS file name from requested file.
            ' Some trick required cause we get in parameters of this method
            ' Not pure file name but full URL that
            ' Created with usage of our template returned in Strategy_9_CSS_ReturnResultPathInPredefinedTestFolder()
            ' So, knowing of that template we must extract from it CSS file name itself
            Dim guid As String = System.Guid.NewGuid().ToString()
            Dim fullPathWithGuid As String = Strategy_10_CSS_ReturnResultPathInPredefinedTestFolder(New HtmlSaveOptions.CssUrlRequestInfo())
            fullPathWithGuid = String.Format(fullPathWithGuid, guid)
            Dim prefixLength As Integer = fullPathWithGuid.IndexOf(guid)
            Dim suffixLength As Integer = fullPathWithGuid.Length - (fullPathWithGuid.IndexOf(guid) + guid.Length)
            Dim fullPath As String = resourceInfo.SupposedURL
            fullPath = fullPath.Substring(prefixLength)
            Dim cssFileNameCore As String = fullPath.Substring(0, fullPath.Length - suffixLength)

            ' Get final file name for saving
            Dim cssFileName As String = (Convert.ToString("style") & cssFileNameCore) + ".css"
            Dim path As String = _folderForReferencedResources_36435 & cssFileName

            ' Saving itself
            Dim reader As System.IO.BinaryReader = New BinaryReader(resourceInfo.ContentStream)
            System.IO.File.WriteAllBytes(path, reader.ReadBytes(CInt(resourceInfo.ContentStream.Length)))
        End Sub
        Private Shared Function Strategy_10_CSS_ReturnResultPathInPredefinedTestFolder(requestInfo As HtmlSaveOptions.CssUrlRequestInfo) As String
            Dim template As String = "http://localhost:24661/document-viewer/GetResourceForHtmlHandler?documentPath=Deutschland201207Arbeit.pdf&resourcePath=style{0}.css&fileNameOnly=false"
            Return template
        End Function
        ' ExEnd:PrefixToImportDirectivesHelper
    End Class
End Namespace