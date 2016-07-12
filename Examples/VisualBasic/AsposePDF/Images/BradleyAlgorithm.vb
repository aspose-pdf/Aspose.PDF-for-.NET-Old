Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Devices

Namespace AsposePDF.Images
    Public Class BradleyAlgorithm
        Public Shared Sub Run()
            ' ExStart:BradleyAlgorithm
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PageToTIFF.pdf"))

            Dim outputImageFile As String = dataDir & Convert.ToString("resultant_out_.tif")
            Dim outputBinImageFile As String = dataDir & Convert.ToString("37116-bin_out_.tif")

            ' Create Resolution object
            Dim resolution As New Resolution(300)
            ' Create TiffSettings object
            Dim tiffSettings As New TiffSettings()
            tiffSettings.Compression = CompressionType.LZW
            tiffSettings.Depth = ColorDepth.Format1bpp
            ' Create TIFF device
            Dim tiffDevice As New TiffDevice(resolution, tiffSettings)
            ' Convert a particular page and save the image to stream
            tiffDevice.Process(pdfDocument, outputImageFile)

            Using inStream As New FileStream(outputImageFile, FileMode.Open)
                Using outStream As New FileStream(outputBinImageFile, FileMode.Create)
                    tiffDevice.BinarizeBradley(inStream, outStream, 0.1)
                End Using
            End Using
            ' ExEnd:BradleyAlgorithm
            System.Console.WriteLine("Conversion using bradley algorithm performed successfully!")
        End Sub
    End Class
End Namespace
