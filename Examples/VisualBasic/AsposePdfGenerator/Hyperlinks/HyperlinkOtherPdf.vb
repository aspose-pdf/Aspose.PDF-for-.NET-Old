Imports System.IO
Imports System
Imports Aspose.Pdf
Namespace AsposePdfGenerator.Hyperlinks
    Public Class HyperlinkOtherPdf
        Public Shared Sub Run()
            ' ExStart:HyperlinkOtherPdf
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

            ' Create a text segment
            Dim segment1 As New Aspose.Pdf.Generator.Segment()

            ' Add a text segment in the text paragraph
            segment1 = text1.Segments.Add("this is a pdf link")

            ' Set the text in the segment to be underlined
            segment1.TextInfo.IsUnderline = True

            ' Set the link type of the text segment to Pdf
            segment1.Hyperlink.LinkType = Aspose.Pdf.Generator.HyperlinkType.Pdf

            ' Set the path of the external document
            segment1.Hyperlink.LinkFile = dataDir & Convert.ToString("input.pdf")

            ' Set the page number of the document to which the link is to be created
            segment1.Hyperlink.LinkPageNumber = 2

            dataDir = dataDir & Convert.ToString("HyperlinkOtherPdf_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:HyperlinkOtherPdf           
        End Sub
    End Class
End Namespace