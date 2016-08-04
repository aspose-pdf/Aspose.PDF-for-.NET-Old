Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion.PDFToHTMLFormat
    Public Class SingleHTML
        Public Shared Sub Run()
            Try
                ' ExStart:SingleHTML
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()

                ' Load source PDF file
                Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
                ' Instantiate HTML Save options object
                Dim newOptions As New HtmlSaveOptions()

                ' Enable option to embed all resources inside the HTML
                newOptions.PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedAllIntoHtml

                ' This is just optimization for IE and can be omitted 
                newOptions.LettersPositioningMethod = HtmlSaveOptions.LettersPositioningMethods.UseEmUnitsAndCompensationOfRoundingErrorsInCss
                newOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground
                newOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats
                ' Output file path 
                Dim outHtmlFile As String = "SingleHTML_out_.html"
                doc.Save(outHtmlFile, newOptions)
                ' ExEnd:SingleHTML
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace