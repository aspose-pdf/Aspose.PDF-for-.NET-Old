Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDFFacades.Images
    Public Class ReplaceImage
        Public Shared Sub Run()
            ' ExStart:ReplaceImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            ' Open input PDF
            Dim pdfContentEditor As New PdfContentEditor()
            pdfContentEditor.BindPdf(dataDir & Convert.ToString("ReplaceImage.pdf"))
            ' Replace image on a particular page
            pdfContentEditor.ReplaceImage(1, 1, dataDir & Convert.ToString("aspose-logo.jpg"))
            ' Save output PDF
            pdfContentEditor.Save(dataDir & Convert.ToString("ReplaceImage_out_.pdf"))
            ' ExEnd:ReplaceImage            
        End Sub
    End Class
End Namespace