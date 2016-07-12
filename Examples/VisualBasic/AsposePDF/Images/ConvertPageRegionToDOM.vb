Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Devices
Imports System.Drawing
Namespace AsposePDF.Images
    Public Class ConvertPageRegionToDOM
        Public Shared Sub Run()
            ' ExStart:ConvertPageRegionToDOM         
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Open document
            Dim document As New Document(dataDir & Convert.ToString("AddImage.pdf"))
            ' Get rectangle of particular page region
            Dim pageRect As New Rectangle(20, 671, 693, 1125)
            ' Set CropBox value as per rectangle of desired page region
            document.Pages(1).CropBox = pageRect
            ' Save cropped document into stream
            Dim ms As New MemoryStream()
            document.Save(ms)
            ' Open cropped PDF document and convert to image
            document = New Document(ms)
            ' Create Resolution object
            Dim resolution As New Resolution(300)
            ' Create PNG device with specified attributes
            Dim pngDevice As New PngDevice(resolution)
            dataDir = dataDir & Convert.ToString("ConvertPageRegionToDOM_out_.png")
            ' Convert a particular page and save the image to stream
            pngDevice.Process(document.Pages(1), dataDir)
            ms.Close()
            ' ExEnd:ConvertPageRegionToDOM   
            Console.WriteLine(Convert.ToString(vbLf & "Page region converted to DOM successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
