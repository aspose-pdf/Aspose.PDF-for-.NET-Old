Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePdfGenerator.General
    Public Class ImageFromMemory
        Public Shared Sub Run()
            Try
                ' ExStart:ImageFromMemory
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_General()

                ' Set the license for Aspose.Pdf
                Dim license As New Aspose.Pdf.License()
                license.SetLicense("Aspose.Custom.lic")

                ' Create a memory stream object
                Dim mstream As New System.IO.MemoryStream()

                ' Instantiate a Pdf object
                Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

                ' Create a new section in the Pdf document
                Dim sec1 As New Aspose.Pdf.Generator.Section(pdf1)

                ' Add the section in the sections collection of the Pdf document
                pdf1.Sections.Add(sec1)

                ' Create an image object
                Dim image1 As New Aspose.Pdf.Generator.Image(sec1)

                ' Add the image into paragraphs collection of the section
                sec1.Paragraphs.Add(image1)

                image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Bmp

                ' Set the ImageStream to a MemoryStream object
                image1.ImageInfo.ImageStream = mstream

                ' Set desired the image scale
                image1.ImageScale = 0.5F

                ' Save the Pdf
                ' ExEnd:ImageFromMemory
                pdf1.Save(dataDir & Convert.ToString("ImageFromMemory_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try

        End Sub
    End Class
End Namespace
