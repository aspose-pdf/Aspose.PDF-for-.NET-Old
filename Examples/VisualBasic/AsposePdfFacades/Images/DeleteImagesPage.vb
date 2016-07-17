Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Images
    Public Class DeleteImagesPage
        Public Shared Sub Run()
            ' ExStart:DeleteImagesPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            ' Open PDF file
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & Convert.ToString("DeleteImages-Page.pdf"))

            ' Array of images to be deleted
            Dim imageIndex As Integer() = New Integer() {1}

            ' Delete the images from the particular page
            contentEditor.DeleteImage(2, imageIndex)

            ' Save output PDF
            contentEditor.Save(dataDir & Convert.ToString("DeleteImages-Page_out_.pdf"))
            ' ExEnd:DeleteImagesPage           

        End Sub
    End Class
End Namespace
