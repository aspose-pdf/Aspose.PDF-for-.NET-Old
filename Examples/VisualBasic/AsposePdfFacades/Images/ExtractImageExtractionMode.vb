Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Drawing
Imports System.Drawing.Imaging

Namespace AsposePDFFacades.Images
    Public Class ExtractImageExtractionMode
        Public Shared Sub Run()
            ' ExStart:ExtractImageExtractionMode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            ' Open input PDF
            Dim extractor As New PdfExtractor()
            extractor.BindPdf(dataDir & Convert.ToString("ExtractImageExtractionMode.pdf"))

            ' Specify Image Extraction Mode
            extractor.ExtractImageMode = ExtractImageMode.DefinedInResources

            ' Extract Images based on Image Extraction Mode
            extractor.ExtractImage()

            ' Get all the extracted images
            While extractor.HasNextImage()
                extractor.GetNextImage((dataDir & DateTime.Now.Ticks.ToString()) + "_out_.png", System.Drawing.Imaging.ImageFormat.Png)
            End While
            ' ExEnd:ExtractImageExtractionMode
        End Sub
    End Class
End Namespace