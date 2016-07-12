Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePdfGenerator.Images
    Public Class ImageFromLocalDisk
        Public Shared Sub Run()
            ' ExStart:ImageFromLocalDisk
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Images()

            ' Instantiate a Pdf object by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create an image object in the section
            Dim image1 As New Aspose.Pdf.Generator.Image(sec1)

            ' Add image object into the Paragraphs collection of the section
            sec1.Paragraphs.Add(image1)

            ' Set the path of image file
            image1.ImageInfo.File = dataDir & Convert.ToString("aspose-logo.jpg")

            ' Set the type of image using ImageFileType enumeration
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg

            ' Set image title
            image1.ImageInfo.Title = "JPEG image"

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("ImageFromLocalDisk_out_.pdf"))
            ' ExEnd:ImageFromLocalDisk         
        End Sub
    End Class
End Namespace