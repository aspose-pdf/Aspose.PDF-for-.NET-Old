Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class RemoveHyperlinksFromText
        Public Shared Sub Run()
            ' ExStart:RemoveHyperlinksFromText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Create an object of Pdf class
            Dim pdf As New Aspose.Pdf.Generator.Pdf()
            ' Bind the source HTML file with Pdf object
            pdf.BindHTML(File.ReadAllText(dataDir & Convert.ToString("Sample.htm")))

            ' Get traverse through each segment inside text paragraph
            For Each seg As Aspose.Pdf.Generator.Segment In TryCast(pdf.Sections(0).Paragraphs(0), Aspose.Pdf.Generator.Text).Segments
                ' Verify that the segment URL value is not null
                If seg.Hyperlink.Url IsNot Nothing Then
                    ' Specify the LinkType of Segment object as none
                    seg.Hyperlink.LinkType = Aspose.Pdf.Generator.HyperlinkType.None
                    ' Set the value of URL for segment object as blank
                    seg.Hyperlink.Url = ""
                    ' Remove the Underline from segment
                    seg.TextInfo.IsUnderline = False
                    ' Change font color to black instread of default Blue for Hyperlinks, you may also comment the following line to display in blue
                    seg.TextInfo.Color = New Aspose.Pdf.Generator.Color("Black")
                End If
            Next
            ' Save the resultant PDF
            pdf.Save(dataDir & Convert.ToString("RemoveHyperlinksFromText_out_.pdf"))
            ' ExEnd:RemoveHyperlinksFromText           
        End Sub
    End Class
End Namespace
