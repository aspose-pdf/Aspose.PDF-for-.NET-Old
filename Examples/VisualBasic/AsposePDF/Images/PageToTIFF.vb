Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Devices

Namespace AsposePDF.Images
    Public Class PageToTIFF
        Public Shared Sub Run()
            ' ExStart:PageToTIFF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PageToTIFF.pdf"))

            ' Create Resolution object
            Dim resolution As New Resolution(300)

            ' Create TiffSettings object
            Dim tiffSettings As New TiffSettings()
            tiffSettings.Compression = CompressionType.None
            tiffSettings.Depth = ColorDepth.[Default]
            tiffSettings.Shape = ShapeType.Landscape
            tiffSettings.SkipBlankPages = False

            ' Create TIFF device
            Dim tiffDevice As New TiffDevice(resolution, tiffSettings)

            ' Convert a particular page and save the image to stream
            tiffDevice.Process(pdfDocument, 1, 1, dataDir & Convert.ToString("PageToTIFF_out_.tif"))
            ' ExEnd:PageToTIFF
            System.Console.WriteLine("PDF one page converted to tiff successfully!")
        End Sub
    End Class
End Namespace

