Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Devices
Imports System.Drawing

Namespace AsposePDF.Images
    Public Class ConvertToBMP
        Public Shared Sub Run()
            ' ExStart:ConvertToBMP         
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("AddImage.pdf"))

            For pageCount As Integer = 1 To pdfDocument.Pages.Count
                Using imageStream As New FileStream("image" & pageCount & "_out_" & ".bmp", FileMode.Create)
                    'Create BMP device with specified attributes
                    'Width, Height, Resolution, PageSize
                    'Create Resolution object
                    Dim resolution As New Resolution(300)
                    Dim bmpDevice As New BmpDevice(resolution)

                    'Convert a particular page and save the image to stream
                    bmpDevice.Process(pdfDocument.Pages(pageCount), imageStream)

                    'Close stream
                    imageStream.Close()

                End Using
            Next pageCount
            ' ExEnd:ConvertToBMP   
            Console.WriteLine(vbLf & "PDF file converted to bmp successfully!")
        End Sub
    End Class
End Namespace
