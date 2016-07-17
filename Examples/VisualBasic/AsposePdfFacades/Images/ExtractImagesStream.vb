Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDFFacades.Images
    Public Class ExtractImagesStream
        Public Shared Sub Run()
            ' ExStart:ExtractImagesStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            ' Open input PDF
            Dim pdfExtractor As New PdfExtractor()
            pdfExtractor.BindPdf(dataDir & Convert.ToString("ExtractImages-Stream.pdf"))

            ' Extract images
            pdfExtractor.ExtractImage()
            ' Get all the extracted images
            While pdfExtractor.HasNextImage()
                ' Read image into memory stream
                Dim memoryStream As New MemoryStream()
                pdfExtractor.GetNextImage(memoryStream)

                ' Write to disk, if you like, or use it otherwise.
                Dim fileStream As New FileStream((dataDir & DateTime.Now.Ticks.ToString()) + "_out_.jpg", FileMode.Create)
                memoryStream.WriteTo(fileStream)
                fileStream.Close()
            End While
            ' ExEnd:ExtractImagesStream
        End Sub
    End Class
End Namespace
