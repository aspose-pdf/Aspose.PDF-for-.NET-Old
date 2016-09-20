Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class ConvertMemoryStreamImageToPdf
        Public Shared Sub Run()
            ' ExStart:ConvertMemoryStreamImageToPdf
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Add a section into the pdf document
            Dim sec As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a FileStream object to read the imag file
            Dim fs As FileStream = File.OpenRead(dataDir & Convert.ToString("aspose-logo.jpg"))
            ' Read the image into Byte array
            Dim data As Byte() = New Byte(Convert.ToInt32(fs.Length - 1)) {}
            fs.Read(data, 0, data.Length)

            ' Create a MemoryStream object from image Byte array
            Dim ms As New MemoryStream(data)
            ' Create an image object in the section 
            Dim imageht As New Aspose.Pdf.Generator.Image(sec)
            ' Set the type of image using ImageFileType enumeration
            imageht.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg

            ' Specify the image source as MemoryStream
            imageht.ImageInfo.ImageStream = ms
            ' Add image object into the Paragraphs collection of the section
            sec.Paragraphs.Add(imageht)

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("ConvertMemoryStreamImageToPdf_out_.pdf"))
            ' Close the MemoryStream Object
            ms.Close()
            ' ExEnd:ConvertMemoryStreamImageToPdf           
        End Sub
    End Class
End Namespace
