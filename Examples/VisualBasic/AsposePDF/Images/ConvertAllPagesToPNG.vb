Imports System
Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Devices

Namespace AsposePDF.Images
    Public Class ConvertAllPagesToPNG
        Public Shared Sub Run()
            ' ExStart:ConvertAllPagesToPNG
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()
            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ConvertAllPagesToPNG.pdf"))
            For pageCount As Integer = 1 To pdfDocument.Pages.Count
                Using imageStream As New FileStream("image" & pageCount & "_out" & ".png", FileMode.Create)
                    ' Create PNG device with specified attributes
                    ' Width, Height, Resolution, Quality
                    ' Quality [0-100], 100 is Maximum
                    ' Create Resolution object
                    Dim resolution As New Resolution(300)
                    Dim pngDevice As New PngDevice(resolution)

                    ' Convert a particular page and save the image to stream
                    pngDevice.Process(pdfDocument.Pages(pageCount), imageStream)

                    ' Close stream
                    imageStream.Close()

                End Using
            Next pageCount
            ' ExEnd:ConvertAllPagesToPNG
            System.Console.WriteLine("PDF pages are converted to PNG successfully!")
        End Sub

    End Class
End Namespace