Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDFFacades.Text
    Public Class ReplaceText
        Public Shared Sub Run()
            ' ExStart:ReplaceText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Text()
            ' Open input PDF
            Dim pdfContentEditor As New PdfContentEditor()
            pdfContentEditor.BindPdf(dataDir & Convert.ToString("ReplaceText.pdf"))
            ' Replace text on all pages
            pdfContentEditor.ReplaceText("Hello", "World")
            ' Save output PDF
            pdfContentEditor.Save(dataDir & Convert.ToString("ReplaceText_out_.pdf"))
            ' ExEnd:ReplaceText
        End Sub
    End Class
End Namespace