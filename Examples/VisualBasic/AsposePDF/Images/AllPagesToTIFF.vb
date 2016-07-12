Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Devices

Namespace AsposePDF.Images
    Public Class AllPagesToTIFF
        Public Shared Sub Run()
            ' ExStart:AllPagesToTIFF
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
            tiffDevice.Process(pdfDocument, dataDir & Convert.ToString("AllPagesToTIFF_out_.tif"))

            ' ExEnd:AllPagesToTIFF
            System.Console.WriteLine("PDF all pages converted to one tiff file successfully!")
        End Sub
    End Class
End Namespace
