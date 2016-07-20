Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Images
    Public Class AddImage
        Public Shared Sub Run()
            ' ExStart:AddImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()

            ' Open document
            Dim mender As New PdfFileMend()

            ' Create PdfFileMend object to add text
            mender.BindPdf(dataDir & Convert.ToString("AddImage.pdf"))

            ' Add image in the PDF file
            mender.AddImage(dataDir & Convert.ToString("aspose-logo.jpg"), 1, 100, 600, 200, 700)

            ' Save changes
            mender.Save(dataDir & Convert.ToString("AddImage_out_.pdf"))

            ' Close PdfFileMend object
            mender.Close()
            ' ExEnd:AddImage
        End Sub
    End Class
End Namespace
