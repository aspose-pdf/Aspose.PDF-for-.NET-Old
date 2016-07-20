Imports System.IO
Imports Aspose.Pdf
Imports System
Imports Microsoft.VisualBasic

Namespace AsposePDF.Pages
    Public Class GetProperties
        Public Shared Sub Run()
            ' ExStart:GetProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetProperties.pdf"))
            ' Get page collection
            Dim pageCollection As PageCollection = pdfDocument.Pages
            ' Get particular page
            Dim pdfPage As Page = pageCollection(1)
            ' Get page properties
            System.Console.WriteLine("ArtBox : Height={0},Width={1},LLX={2},LLY={3},URX={4},URY={5}", pdfPage.ArtBox.Height, pdfPage.ArtBox.Width, pdfPage.ArtBox.LLX, pdfPage.ArtBox.LLY, pdfPage.ArtBox.URX, _
                pdfPage.ArtBox.URY)
            System.Console.WriteLine("BleedBox : Height={0},Width={1},LLX={2},LLY={3},URX={4},URY={5}", pdfPage.BleedBox.Height, pdfPage.BleedBox.Width, pdfPage.BleedBox.LLX, pdfPage.BleedBox.LLY, pdfPage.BleedBox.URX, _
                pdfPage.BleedBox.URY)
            System.Console.WriteLine("CropBox : Height={0},Width={1},LLX={2},LLY={3},URX={4},URY={5}", pdfPage.CropBox.Height, pdfPage.CropBox.Width, pdfPage.CropBox.LLX, pdfPage.CropBox.LLY, pdfPage.CropBox.URX, _
                pdfPage.CropBox.URY)
            System.Console.WriteLine("MediaBox : Height={0},Width={1},LLX={2},LLY={3},URX={4},URY={5}", pdfPage.MediaBox.Height, pdfPage.MediaBox.Width, pdfPage.MediaBox.LLX, pdfPage.MediaBox.LLY, pdfPage.MediaBox.URX, _
                pdfPage.MediaBox.URY)
            System.Console.WriteLine("TrimBox : Height={0},Width={1},LLX={2},LLY={3},URX={4},URY={5}", pdfPage.TrimBox.Height, pdfPage.TrimBox.Width, pdfPage.TrimBox.LLX, pdfPage.TrimBox.LLY, pdfPage.TrimBox.URX, _
                pdfPage.TrimBox.URY)
            System.Console.WriteLine("Rect : Height={0},Width={1},LLX={2},LLY={3},URX={4},URY={5}", pdfPage.Rect.Height, pdfPage.Rect.Width, pdfPage.Rect.LLX, pdfPage.Rect.LLY, pdfPage.Rect.URX, _
                pdfPage.Rect.URY)
            System.Console.WriteLine("Page Number : {0}", pdfPage.Number)
            System.Console.WriteLine("Rotate : {0}", pdfPage.Rotate)
            ' ExEnd:GetProperties
        End Sub
    End Class
End Namespace
