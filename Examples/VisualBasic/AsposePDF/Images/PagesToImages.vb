Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Devices

Namespace AsposePDF.Images
    Public Class PagesToImages
        Public Shared Sub Run()
            ' ExStart:PagesToImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PagesToImages.pdf"))

            For pageCount As Integer = 1 To pdfDocument.Pages.Count

                Using imageStream As New FileStream("image" & pageCount & "_out_" & ".jpg", FileMode.Create)
                    ' Create Resolution object
                    Dim resolution As New Resolution(300)
                    ' Create JPEG device with specified attributes (Width, Height, Resolution, Quality)
                    ' Quality [0-100], 100 is Maximum
                    Dim jpegDevice As New JpegDevice(resolution, 100)

                    ' Convert a particular page and save the image to stream
                    jpegDevice.Process(pdfDocument.Pages(pageCount), imageStream)
                    ' Close stream
                    imageStream.Close()

                End Using
            Next pageCount

            ' ExEnd:PagesToImages
            System.Console.WriteLine("PDF pages are converted to individual images successfully!")
        End Sub
        Public Shared Sub SinglePageToImage()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PagesToImages.pdf"))

            Using imageStream As New FileStream("image" & 1 & "_out_" & ".jpg", FileMode.Create)
                'Create Resolution object
                Dim resolution As New Resolution(300)
                'Create JPEG device with specified attributes (Width, Height, Resolution, Quality)
                'Quality [0-100], 100 is Maximum
                Dim jpegDevice As New JpegDevice(resolution, 100)

                'Convert a particular page and save the image to stream
                jpegDevice.Process(pdfDocument.Pages(1), imageStream)
                'Close stream
                imageStream.Close()

            End Using


        End Sub
    End Class
End Namespace
