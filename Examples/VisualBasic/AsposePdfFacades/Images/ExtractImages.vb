Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Images
    Public Class ExtractImages
        Public Shared Sub Run()
            ' ExStart:ExtractImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()

            ' Open input PDF
            Dim pdfExtractor As New PdfExtractor()
            pdfExtractor.BindPdf(dataDir & Convert.ToString("ExtractImages.pdf"))

            ' Extract all the images
            pdfExtractor.ExtractImage()

            ' Get all the extracted images
            While pdfExtractor.HasNextImage()
                pdfExtractor.GetNextImage((dataDir & DateTime.Now.Ticks.ToString()) + "_out_.jpg")
            End While
            ' ExEnd:ExtractImages            

        End Sub
    End Class
End Namespace
