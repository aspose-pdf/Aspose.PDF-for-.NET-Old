Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Hyperlinks
    Public Class HyperlinkToWeb
        Public Shared Sub Run()
            ' ExStart:HyperlinkToWeb
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Hyperlinks()
            ' Instantiate Pdf document object 
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()
            ' Create text paragraph with the reference of a section
            Dim text2 As New Aspose.Pdf.Generator.Text(sec1)

            ' Add the text paragraph in the paragraphs collection of the section
            sec1.Paragraphs.Add(text2)

            ' Add a text segment in the text paragraph
            Dim segment2 As Aspose.Pdf.Generator.Segment = text2.Segments.Add("this is a web link")

            ' Assign a new instance of hyperlink to hyperlink property of segment
            segment2.Hyperlink = New Aspose.Pdf.Generator.Hyperlink()

            ' Set the link type of the text segment to Web
            segment2.Hyperlink.LinkType = Aspose.Pdf.Generator.HyperlinkType.Web

            ' Set the URL of the web location to create a web link for the segment
            segment2.Hyperlink.Url = "http://localhost/popup.htm"

            dataDir = dataDir & Convert.ToString("HyperlinkToWeb_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:HyperlinkToWeb           
        End Sub
    End Class
End Namespace