Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Namespace AsposePDF.LinksActions
    Public Class CreateLocalHyperlink
        Public Shared Sub Run()
            ' ExStart:CreateLocalHyperlink
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()

            ' Create Document instance
            Dim doc As New Document()
            ' Add page to pages collection of PDF file
            Dim page As Page = doc.Pages.Add()
            ' Create Text Fragment instance
            Dim text As New TextFragment("link page number test to page 7")
            ' Create local hyperlink instance
            Dim link As New LocalHyperlink()
            ' Set target page for link instance
            link.TargetPageNumber = 7
            ' Set TextFragment hyperlink
            text.Hyperlink = link
            ' Add text to paragraphs collection of Page
            page.Paragraphs.Add(text)
            ' Create new TextFragment instance
            text = New TextFragment("link page number test to page 1")
            ' TextFragment should be added over new page
            text.IsInNewPage = True
            ' Create another local hyperlink instance
            link = New LocalHyperlink()
            ' Set Target page for second hyperlink
            link.TargetPageNumber = 1
            ' Set link for second TextFragment
            text.Hyperlink = link
            ' Add text to paragraphs collection of page object
            page.Paragraphs.Add(text)

            dataDir = dataDir & Convert.ToString("CreateLocalHyperlink_out_.pdf")
            ' Save updated document
            doc.Save(dataDir)
            ' ExEnd:CreateLocalHyperlink
            Console.WriteLine(Convert.ToString(vbLf & "Local hyperlink created successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
