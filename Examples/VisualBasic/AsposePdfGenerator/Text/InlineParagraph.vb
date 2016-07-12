Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.Text
    Public Class InlineParagraph
        Public Shared Sub Run()
            ' ExStart:InlineParagraph
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New AP.Generator.Pdf()
            ' Create section object and add it to sections collection of PDF
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()

            ' Create a text object
            Dim text1 As New AP.Generator.Text()
            ' Add text object to paragraphs collection of section
            sec1.Paragraphs.Add(text1)
            ' Add sample text to segments collection of text object
            text1.Segments.Add("This is a test for inline")
            ' Create segment 2 and add it to segements collection of text object
            Dim seg2 As AP.Generator.Segment = text1.Segments.Add()

            ' Create a Image object to contain logo gif.
            Dim img1 As New AP.Generator.Image()
            ' Specify the image file path
            img1.ImageInfo.File = dataDir & Convert.ToString("aspose-logo.jpg")
            ' Indicate seg2's InlineParagraph is a image.
            seg2.InlineParagraph = img1
            dataDir = dataDir & Convert.ToString("InlineImage_out_.pdf")
            ' Create the result PDF Document
            pdf1.Save(dataDir)
            ' ExEnd:InlineParagraph
        End Sub
    End Class
End Namespace