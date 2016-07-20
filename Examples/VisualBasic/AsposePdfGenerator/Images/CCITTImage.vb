Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Images
    Public Class CCITTImage
        Public Shared Sub Run()
            ' ExStart:CCITTImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Images()
            Dim faxImageFile As String = ""
            If faxImageFile <> "" Then
                ' Instantiate a Pdf object by calling its empty constructor
                Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

                ' Create a section in the Pdf object
                Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

                ' Instantiate an image object
                Dim img1 As New Aspose.Pdf.Generator.Image(sec1)

                ' Add image object into the Paragraphs collection of the section
                sec1.Paragraphs.Add(img1)

                ' Set the path of image file
                img1.ImageInfo.File = faxImageFile

                ' Set the file type of the image
                img1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Ccitt

                ' Set the image width
                img1.ImageInfo.CcittImageWidth = 2560

                ' Set the image height
                img1.ImageInfo.CcittImageHeight = 1779

                ' Set the sub-format of the ccitt image
                img1.ImageInfo.CcittSubFormat = Aspose.Pdf.Generator.CcittSubFormat.Group31D

                ' Set the desired scaling of the image
                img1.ImageScale = 0.1F

                ' ExEnd:CCITTImage   
                pdf1.Save(dataDir & Convert.ToString("CCITTImage_out_.pdf"))
            Else
                Console.WriteLine(vbLf & "Please set valid fax image file path.")
            End If
        End Sub
    End Class
End Namespace