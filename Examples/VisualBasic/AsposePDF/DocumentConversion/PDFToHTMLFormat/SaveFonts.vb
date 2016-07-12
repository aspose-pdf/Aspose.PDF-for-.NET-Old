Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class SaveFonts
        Public Shared Sub Run()
            Try
                ' ExStart:SaveFonts
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                ' Output HTML file path information
                Dim outFile As String = Path.GetFullPath(dataDir & Convert.ToString("36192_out_.html"))

                ' Source PDF document
                Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

                ' Create HtmlSaveOption with tested feature
                Dim saveOptions As New HtmlSaveOptions()
                saveOptions.FixedLayout = True
                saveOptions.SplitIntoPages = False

                ' Save the fonts as TTF format
                saveOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.AlwaysSaveAsTTF
                Dim htmlFile As String = Path.GetFullPath(outFile)
                Dim linkedFilesFolder As String = Path.GetDirectoryName(htmlFile) + "\36192_files"

                If Directory.Exists(linkedFilesFolder) Then
                    Directory.Delete(linkedFilesFolder, True)
                End If

                ' Save the output
                ' ExEnd:SaveFonts
                doc.Save(outFile, saveOptions)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        Private Shared Sub WOFFFormat()
            ' Create HtmlSaveOption with tested feature
            Dim saveOptions As New HtmlSaveOptions()
            ' ExStart:WOFFFormat
            saveOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.AlwaysSaveAsWOFF
            ' ExEnd:WOFFFormat
        End Sub
        Public Shared Sub ThreeSetFonts()
            ' ExStart:ThreeSetFonts
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
            Dim htmlOptions As New HtmlSaveOptions()
            htmlOptions.FixedLayout = True
            htmlOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsExternalPngFilesReferencedViaSvg
            htmlOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats

            doc.Save(dataDir & Convert.ToString("ThreeSetFonts_out_.html"), htmlOptions)
            ' ExEnd:ThreeSetFonts

        End Sub
    End Class
End Namespace