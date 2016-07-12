Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Devices

Namespace AsposePDF.Images
    Public Class PageToPNG
        Public Shared Sub Run()
            ' ExStart:PageToPNG         
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PageToPNG.pdf"))


            Using imageStream As New FileStream(dataDir & Convert.ToString("aspose-logo.png"), FileMode.Create)
                ' Create Resolution object
                Dim resolution As New Resolution(300)
                ' Create PNG device with specified attributes (Width, Height, Resolution)
                Dim pngDevice As New PngDevice(resolution)

                ' Convert a particular page and save the image to stream
                pngDevice.Process(pdfDocument.Pages(1), imageStream)

                ' Close stream
                imageStream.Close()
            End Using
            ' ExEnd:PageToPNG    
        End Sub
    End Class
End Namespace
