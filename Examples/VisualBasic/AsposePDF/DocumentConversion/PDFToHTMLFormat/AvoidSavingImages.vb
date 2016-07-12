Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class AvoidSavingImages
        Public Shared Sub Run()
            Try
                ' ExStart:AvoidSavingImages
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))

                ' Create HtmlSaveOption with tested feature
                Dim saveOptions As New HtmlSaveOptions()
                saveOptions.FixedLayout = True
                saveOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground

                ' ExEnd:AvoidSavingImages
                pdfDocument.Save(dataDir & Convert.ToString("AvoidSavingImages_out_.html"), saveOptions)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
