Imports System.IO
Imports System
Imports Aspose.Pdf
Namespace AsposePdfGenerator.UtilityFeatures
    Public Class AddBookmark
        Public Shared Sub Run()
            ' ExStart:AddBookmark
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()

            ' Instantiate the Pdf instance 
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Set the value that PDF document will be Bookmarked
            pdf1.IsBookmarked = True
            
            ' Create Section object and add it to PDF 
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()
            Dim heading1 As New Aspose.Pdf.Generator.Heading(pdf1, sec1, 1)
            Dim segment1 As New Aspose.Pdf.Generator.Segment(heading1)
            heading1.Segments.Add(segment1)
            heading1.IsAutoSequence = True
            segment1.Content = "this is heading of level 1"
            sec1.Paragraphs.Add(heading1)
            Dim heading2 As New Aspose.Pdf.Generator.Heading(pdf1, sec1, 2)
            Dim segment2 As New Aspose.Pdf.Generator.Segment(heading2)
            heading2.Segments.Add(segment2)
            heading2.IsAutoSequence = True
            segment2.Content = "this is heading of level 2"
            sec1.Paragraphs.Add(heading2)
            Dim heading3 As New Aspose.Pdf.Generator.Heading(pdf1, sec1, 1)
            Dim segment3 As New Aspose.Pdf.Generator.Segment(heading3)
            heading3.Segments.Add(segment3)
            heading3.IsAutoSequence = False
            heading3.LabelWidth = 60
            heading3.UserLabel = "bullet1"
            segment3.Content = "this is bullet style 1"
            sec1.Paragraphs.Add(heading3)
            dataDir = dataDir & Convert.ToString("AddBookmark_out_.pdf")
            pdf1.Save(dataDir)
            ' ExEnd:AddBookmark           
        End Sub
    End Class
End Namespace