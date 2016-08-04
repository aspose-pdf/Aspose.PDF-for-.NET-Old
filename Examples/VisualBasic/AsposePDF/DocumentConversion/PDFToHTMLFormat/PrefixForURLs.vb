Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class PrefixForURLs
        Public Shared Sub Run()
            Try
                ' ExStart:PrefixForURLs
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                Dim testDoc As New Document(dataDir & Convert.ToString("input.pdf"))

                Dim options As New HtmlSaveOptions()
                ' This is main setting that allows work and testing of tested feature
                options.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsExternalPngFilesReferencedViaSvg
                '

                options.CustomResourceSavingStrategy = New HtmlSaveOptions.ResourceSavingStrategy(AddressOf Custom_processor_of_embedded_images)

                ' Do conversion
                testDoc.Save(dataDir & Convert.ToString("PrefixForURLs_out_.html"), options)
                ' ExEnd:PrefixForURLs
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        ' ExStart:PrefixForURLsHelper
        Private Shared Function Custom_processor_of_embedded_images(resourceSavingInfo As SaveOptions.ResourceSavingInfo) As String
            ' ____________________________________________________________________________
            '    This sample method saving strategy method saves image-files in some folder
            '    (including raster image files that are exctracted from that SVGs)
            '    Then it returns specific custom artificial  path
            '    to be used as value of 'src' or 'data' relevant attribute in generated host-SVG(or HTML)
            ' ____________________________________________________________________________

            '---------------------------------------------------------
            ' 1) All other files(f.e. fonts) will be processed with converter itself cause for them flag
            '   resourceSavingInfo.CustomProcessingCancelled is set to 'true'
            '---------------------------------------------------------
            If Not (TypeOf resourceSavingInfo Is HtmlSaveOptions.HtmlImageSavingInfo) Then
                resourceSavingInfo.CustomProcessingCancelled = True
                Return ""
            End If
            '---------------------------------------------------------
            ' 1) Create target folder if not created yet
            '---------------------------------------------------------
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()
            Dim outDir As String = dataDir & Convert.ToString("output\36297_files\")
            Dim outPath As String = outDir & Path.GetFileName(resourceSavingInfo.SupposedFileName)
            If Not Directory.Exists(outDir) Then
                Directory.CreateDirectory(outDir)
            End If
            '---------------------------------------------------------
            ' 3) Write supplied image to that folder
            '---------------------------------------------------------
            Dim reader As System.IO.BinaryReader = New BinaryReader(resourceSavingInfo.ContentStream)
            System.IO.File.WriteAllBytes(dataDir, reader.ReadBytes(CInt(resourceSavingInfo.ContentStream.Length)))
            '---------------------------------------------------------
            ' 4) Return customized specific URL to be used to refer
            '    just created image in parent SVG (or HTML)
            '---------------------------------------------------------
            Dim asHtmlImageSavingInfo As HtmlSaveOptions.HtmlImageSavingInfo = TryCast(resourceSavingInfo, HtmlSaveOptions.HtmlImageSavingInfo)
            If asHtmlImageSavingInfo.ParentType = HtmlSaveOptions.ImageParentTypes.SvgImage Then
                Return "http://localhost:255/" + resourceSavingInfo.SupposedFileName
            Else
                Return "http://localhost:GetImage/imageID=" + resourceSavingInfo.SupposedFileName
            End If
        End Function
        ' ExEnd:PrefixForURLsHelper

    End Class
End Namespace