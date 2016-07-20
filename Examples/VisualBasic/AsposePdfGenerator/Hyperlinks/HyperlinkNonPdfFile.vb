Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Hyperlinks
    Public Class HyperlinkNonPdfFile
        Public Shared Sub Run()
            ' ExStart:HyperlinkNonPdfFile
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Hyperlinks()

            ' Instantiate Pdf document object 
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create text paragraph with the reference of a section
            Dim text1 As New Aspose.Pdf.Generator.Text(sec1)

            ' Add the text paragraph in the paragraphs collection of the section
            sec1.Paragraphs.Add(text1)

            ' Add a text segment in the text paragraph
            Dim segment1 As Aspose.Pdf.Generator.Segment = text1.Segments.Add("this is a external file link")

            ' Assign a new instance of hyperlink to hyperlink property of segment
            segment1.Hyperlink = New Aspose.Pdf.Generator.Hyperlink()

            ' Set the link type of the text segment to File
            segment1.Hyperlink.LinkType = Aspose.Pdf.Generator.HyperlinkType.File

            ' Set the path of the external Non-Pdf file
            segment1.Hyperlink.LinkFile = dataDir & Convert.ToString("aspose-logo.jpg")

            dataDir = dataDir & Convert.ToString("HyperlinkNonPdfFile_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:HyperlinkNonPdfFile           
        End Sub
    End Class
End Namespace
