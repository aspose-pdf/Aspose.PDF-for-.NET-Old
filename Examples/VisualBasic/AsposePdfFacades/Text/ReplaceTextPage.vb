Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Text
    Public Class ReplaceTextPage
        Public Shared Sub Run()
            ' ExStart:ReplaceTextPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Text()
            ' Open input PDF
            Dim pdfContentEditor As New PdfContentEditor()
            pdfContentEditor.BindPdf(dataDir & Convert.ToString("ReplaceText-Page.pdf"))
            ' Replace text on all pages
            pdfContentEditor.ReplaceText("Hello", 1, "World")
            ' Save output PDF
            pdfContentEditor.Save(dataDir & Convert.ToString("ReplaceTextPage_out_.pdf"))
            ' ExEnd:ReplaceTextPage            
        End Sub
    End Class
End Namespace