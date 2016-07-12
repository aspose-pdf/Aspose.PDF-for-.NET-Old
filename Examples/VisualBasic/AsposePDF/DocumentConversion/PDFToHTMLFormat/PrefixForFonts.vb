Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class PrefixForFonts
        Private Shared _fontNumberForUniqueFontFileNames As Integer
        Private Shared _desiredFontDir As String
        Public Shared Sub Run()
            Try
                ' ExStart:PrefixForFonts
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
                Dim outHtmlFile As String = dataDir & Convert.ToString("PrefixForFonts_out_.html")
                _desiredFontDir = Path.GetDirectoryName(outHtmlFile) + "\36296_files\"
                If Not Directory.Exists(_desiredFontDir) Then
                    Directory.CreateDirectory(_desiredFontDir)
                End If
                ' Reset counter for font names - this counter will be used in our custom code
                ' to generate unigue font file names

                _fontNumberForUniqueFontFileNames = 0

                ' Create HtmlSaveOption with custom saving strategy that will do all the job
                Dim saveOptions As New HtmlSaveOptions()
                saveOptions.CustomResourceSavingStrategy = New HtmlSaveOptions.ResourceSavingStrategy(AddressOf CustomResourcesProcessing)
                ' ExEnd:PrefixForFonts
                doc.Save(outHtmlFile, saveOptions)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        ' ExStart:PrefixForFontsHelper
        Private Shared Function CustomResourcesProcessing(resourceSavingInfo As SaveOptions.ResourceSavingInfo) As String
            '-----------------------------------------------------------------------------
            ' It's just example of possible realization of cusstom processing of resources
            ' referenced in result HTML
            '-----------------------------------------------------------------------------

            ' 1) In this case we need only do something special
            '    with fonts, so let's leave processing of all other resources
            '    to converter itself
            If resourceSavingInfo.ResourceType <> SaveOptions.NodeLevelResourceType.Font Then
                resourceSavingInfo.CustomProcessingCancelled = True
                Return ""
            End If

            ' If supplied font resource, process it ourselves
            ' 1) Write supplied font with short name  to desired folder
            '    You can easily do anythings  - it's just one of realizations

            _fontNumberForUniqueFontFileNames += 1
            Dim shortFontFileName As String = (_fontNumberForUniqueFontFileNames.ToString() + Path.GetExtension(resourceSavingInfo.SupposedFileName))
            Dim outFontPath As String = Convert.ToString(_desiredFontDir & Convert.ToString("\")) & shortFontFileName

            Dim fontBinaryReader As System.IO.BinaryReader = New BinaryReader(resourceSavingInfo.ContentStream)
            System.IO.File.WriteAllBytes(outFontPath, fontBinaryReader.ReadBytes(CInt(resourceSavingInfo.ContentStream.Length)))


            ' 2) Return the desired URI with which font will be referenced in CSSes
            Dim fontUrl As String = Convert.ToString("http://localhost:255/document-viewer/GetFont/") & shortFontFileName
            Return fontUrl
        End Function
        ' ExEnd:PrefixForFontsHelper

    End Class
End Namespace