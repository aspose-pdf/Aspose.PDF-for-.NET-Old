Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Images
    Public Class DeleteAllImages
        Public Shared Sub Run()
            ' ExStart:DeleteAllImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            ' Open PDF file
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & Convert.ToString("DeleteAllImages.pdf"))

            ' Delete the images from the particular page
            contentEditor.DeleteImage()

            ' Save output PDF
            contentEditor.Save(dataDir & Convert.ToString("DeleteAllImages_out_.pdf"))
            ' ExEnd:DeleteAllImages

        End Sub
    End Class
End Namespace