Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Images
    Public Class ExtractImagesPage
        Public Shared Sub Run()
            ' ExStart:ExtractImagesPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()

            ' Open input PDF
            Dim pdfExtractor As New PdfExtractor()
            pdfExtractor.BindPdf(dataDir & Convert.ToString("ExtractImages-Page.pdf"))

            ' Set StartPage and EndPage properties to the page number to
            ' You want to extract images from
            pdfExtractor.StartPage = 2
            pdfExtractor.EndPage = 2

            ' Extract images
            pdfExtractor.ExtractImage()
            ' Get extracted images
            While pdfExtractor.HasNextImage()
                ' Read image into memory stream
                Dim memoryStream As New MemoryStream()
                pdfExtractor.GetNextImage(memoryStream)

                ' Write to disk, if you like, or use it otherwise.
                Dim fileStream As New FileStream((dataDir & DateTime.Now.Ticks.ToString()) + "_out_.jpg", FileMode.Create)
                memoryStream.WriteTo(fileStream)
                fileStream.Close()
            End While
            ' ExEnd:ExtractImagesPage

        End Sub
    End Class
End Namespace
