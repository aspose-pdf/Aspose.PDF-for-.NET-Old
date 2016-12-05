Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class SpecifyPrefixForImages
        Public Shared Sub Run()
            Try
                ' ExStart:SpecifyPrefixForImages
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                Dim outFile As String = dataDir & Convert.ToString("SpecifyImages_out_.html")

                Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
                ' Create HtmlSaveOption with tested feature
                Dim saveOptions As New HtmlSaveOptions()
                saveOptions.SplitIntoPages = False
                saveOptions.CustomResourceSavingStrategy = New HtmlSaveOptions.ResourceSavingStrategy(AddressOf SavingTestStrategy_1)
                doc.Save(outFile, saveOptions)
                ' ExEnd:SpecifyPrefixForImages
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        ' ExStart:SpecifyPrefixForImagesHelper
        Private Shared Function SavingTestStrategy_1(resourceSavingInfo As SaveOptions.ResourceSavingInfo) As String
            ' This sample method saving strategy method saves only svg-files in some folder and returns specific path
            ' To be used as value of ' Src' or ' Data' Relevant attribute in generated HTML
            ' All other files will be processed with converter itself cause for them flag
            ' ResourceSavingInfo.CustomProcessingCancelled is set to ' True'
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()
            If Not (TypeOf resourceSavingInfo Is HtmlSaveOptions.HtmlImageSavingInfo) Then
                resourceSavingInfo.CustomProcessingCancelled = True
                Return ""
            End If

            Dim asHtmlImageSavingInfo As HtmlSaveOptions.HtmlImageSavingInfo = DirectCast(resourceSavingInfo, HtmlSaveOptions.HtmlImageSavingInfo)

            If (asHtmlImageSavingInfo.ImageType <> HtmlSaveOptions.HtmlImageType.Svg) AndAlso (asHtmlImageSavingInfo.ImageType <> HtmlSaveOptions.HtmlImageType.ZippedSvg) Then
                resourceSavingInfo.CustomProcessingCancelled = True
                Return ""
            End If

            Dim outFile As String = dataDir & Convert.ToString("SpecifyImages_out_.html")
            Dim imageOutFolder As String = Path.GetFullPath(Path.GetDirectoryName(outFile) + "\35956_svg_files\")
            ' ImageOutFolder="C:\AsposeImagesTests\";
            If Not Directory.Exists(imageOutFolder) Then
                Directory.CreateDirectory(imageOutFolder)
            End If

            Dim outPath As String = imageOutFolder & Path.GetFileName(resourceSavingInfo.SupposedFileName)
            Dim reader As System.IO.BinaryReader = New BinaryReader(resourceSavingInfo.ContentStream)
            System.IO.File.WriteAllBytes(outPath, reader.ReadBytes(CInt(resourceSavingInfo.ContentStream.Length)))

            Return "/document-viewer/GetImage?path=CRWU-NDWAC-Final-Report-12-09-10-2.pdf&name=" + resourceSavingInfo.SupposedFileName
        End Function
        ' ExEnd:SpecifyPrefixForImagesHelper
    End Class
End Namespace