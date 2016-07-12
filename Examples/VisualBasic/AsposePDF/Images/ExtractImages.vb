Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports System.Drawing.Imaging
Namespace AsposePDF.Images
    Public Class ExtractImages
        Public Shared Sub Run()
            ' ExStart:ExtractImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ExtractImages.pdf"))

            ' Extract a particular image
            Dim xImage As XImage = pdfDocument.Pages(1).Resources.Images(1)

            Dim outputImage As New FileStream(dataDir & Convert.ToString("output.jpg"), FileMode.Create)

            ' Save output image
            xImage.Save(outputImage, ImageFormat.Jpeg)
            outputImage.Close()

            dataDir = dataDir & Convert.ToString("ExtractImages_out_.pdf")

            ' Save updated PDF file
            pdfDocument.Save(dataDir)
            ' ExEnd:ExtractImages
            Console.WriteLine(Convert.ToString(vbLf & "Images extracted successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
