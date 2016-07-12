Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class SaveImages
        Public Shared Sub Run()
            Try
                ' ExStart:SaveImages
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                ' Source PDF file
                Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

                ' Create HtmlSaveOption with tested feature
                Dim saveOptions As New HtmlSaveOptions()
                saveOptions.FixedLayout = True
                saveOptions.SplitIntoPages = False
                saveOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsExternalPngFilesReferencedViaSvg

                ' Save the output in HTML format
                ' ExEnd:SaveImages
                doc.Save(dataDir & Convert.ToString("SaveImages_out_.html"), saveOptions)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace