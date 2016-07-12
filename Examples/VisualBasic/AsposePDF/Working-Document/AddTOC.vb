Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.WorkingDocuments
    Public Class AddTOC
        Public Shared Sub Run()
            ' ExStart:AddTOC
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Load an existing PDF files
            Dim doc As New Document(dataDir & Convert.ToString("AddTOC.pdf"))

            ' Get access to first page of PDF file
            Dim tocPage As Page = doc.Pages.Insert(1)

            ' Create object to represent TOC information
            Dim tocInfo As New TocInfo()
            Dim title As New TextFragment("Table Of Contents")
            title.TextState.FontSize = 20
            title.TextState.FontStyle = FontStyles.Bold

            ' Set the title for TOC
            tocInfo.Title = title
            tocPage.TocInfo = tocInfo

            ' Create string objects which will be used as TOC elements
            Dim titles As String() = New String(3) {}
            titles(0) = "First page"
            titles(1) = "Second page"
            titles(2) = "Third page"
            titles(3) = "Fourth page"
            For i As Integer = 0 To 1
                ' Create Heading object
                Dim heading2 As New Heading(1)
                Dim segment2 As New TextSegment()
                heading2.TocPage = tocPage
                heading2.Segments.Add(segment2)

                ' Specify the destination page for heading object
                heading2.DestinationPage = doc.Pages(i + 2)

                ' Destination page
                heading2.Top = doc.Pages(i + 2).Rect.Height

                ' Destination coordinate
                segment2.Text = titles(i)

                ' Add heading to page containing TOC
                tocPage.Paragraphs.Add(heading2)
            Next
            dataDir = dataDir & Convert.ToString("TOC_out_.pdf")
            ' Save the updated document
            doc.Save(dataDir)
            ' ExEnd:AddTOC
            Console.WriteLine(Convert.ToString(vbLf & "TOC added successfully to an existing PDF." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
