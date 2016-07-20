Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Text.TextOptions

Namespace AsposePDF.Text
    Public Class FootAndEndNotes
        Public Shared Sub Run()
            AddFootNote()
            CustomLineStyleForFootNote()
            CustomizeFootNoteLabel()
            AddImageAndTable()
            CreateEndNotes()
        End Sub
        Public Shared Sub AddFootNote()
            ' ExStart:AddFootNote
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Create Document instance
            Dim doc As New Document()
            ' Add page to pages collection of PDF
            Dim page As Page = doc.Pages.Add()
            ' Create GraphInfo object
            Dim graph As New GraphInfo()
            ' Set line width as 2
            graph.LineWidth = 2
            ' Set the color for graph object
            graph.Color = Color.Red
            ' Set dash array value as 3
            graph.DashArray = New Integer() {3}
            ' Set dash phase value as 1
            graph.DashPhase = 1
            ' Set footnote line style for page as graph
            page.NoteLineStyle = graph
            ' Create TextFragment instance
            Dim text As New TextFragment("Hello World")
            ' Set FootNote value for TextFragment
            text.FootNote = New Note("foot note for test text 1")
            ' Add TextFragment to paragraphs collection of first page of document
            page.Paragraphs.Add(text)
            ' Create second TextFragment
            text = New TextFragment("Aspose.Pdf for .NET")
            ' Set FootNote for second text fragment
            text.FootNote = New Note("foot note for test text 2")
            ' Add second text fragment to paragraphs collection of PDF file
            page.Paragraphs.Add(text)

            dataDir = dataDir & Convert.ToString("AddFootNote_out_.pdf")

            ' Save resulting PDF document.
            doc.Save(dataDir)
            ' ExEnd:AddFootNote
            Console.WriteLine(Convert.ToString(vbLf & "FootNote added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub CustomLineStyleForFootNote()
            ' ExStart:CustomLineStyleForFootNote
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Create Document instance
            Dim doc As New Document()
            ' Add page to pages collection of PDF
            Dim page As Page = doc.Pages.Add()
            ' Create GraphInfo object
            Dim graph As New GraphInfo()
            ' Set line width as 2
            graph.LineWidth = 2
            ' Set the color for graph object
            graph.Color = Color.Red
            ' Set dash array value as 3
            graph.DashArray = New Integer() {3}
            ' Set dash phase value as 1
            graph.DashPhase = 1
            ' Set footnote line style for page as graph
            page.NoteLineStyle = graph
            ' Create TextFragment instance
            Dim text As New TextFragment("Hello World")
            ' Set FootNote value for TextFragment
            text.FootNote = New Note("foot note for test text 1")
            ' Add TextFragment to paragraphs collection of first page of document
            page.Paragraphs.Add(text)
            ' Create second TextFragment
            text = New TextFragment("Aspose.Pdf for .NET")
            ' Set FootNote for second text fragment
            text.FootNote = New Note("foot note for test text 2")
            ' Add second text fragment to paragraphs collection of PDF file
            page.Paragraphs.Add(text)

            dataDir = dataDir & Convert.ToString("CustomLineStyleForFootNote_out_.pdf")

            ' Save resulting PDF document.
            doc.Save(dataDir)
            ' ExEnd:CustomLineStyleForFootNote
            Console.WriteLine(Convert.ToString(vbLf & "Custom line style defined successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub CustomizeFootNoteLabel()
            ' ExStart:CustomizeFootNoteLabel
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()
            ' Create Document instance
            Dim doc As New Document()
            ' Add page to pages collection of PDF
            Dim page As Page = doc.Pages.Add()
            ' Create GraphInfo object
            Dim graph As New GraphInfo()
            ' Set line width as 2
            graph.LineWidth = 2
            ' Set the color for graph object
            graph.Color = Color.Red
            ' Set dash array value as 3
            graph.DashArray = New Integer() {3}
            ' Set dash phase value as 1
            graph.DashPhase = 1
            ' Set footnote line style for page as graph
            page.NoteLineStyle = graph
            ' Create TextFragment instance
            Dim text As New TextFragment("Hello World")
            ' Set FootNote value for TextFragment
            text.FootNote = New Note("foot note for test text 1")
            ' Specify custom label for FootNote
            text.FootNote.Text = " Aspose(2015)"
            ' Add TextFragment to paragraphs collection of first page of document
            page.Paragraphs.Add(text)

            dataDir = dataDir & Convert.ToString("CustomizeFootNoteLabel_out_.pdf")
            ' ExEnd:CustomizeFootNoteLabel
            Console.WriteLine(Convert.ToString(vbLf & "FootNote label customized successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub AddImageAndTable()
            ' ExStart:AddImageAndTable
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            Dim doc As New Document()
            Dim page As Page = doc.Pages.Add()
            Dim text As New TextFragment("some text")
            page.Paragraphs.Add(text)

            text.FootNote = New Note()
            Dim image As New Image()
            image.File = dataDir & Convert.ToString("aspose-logo.jpg")
            image.FixHeight = 20
            text.FootNote.Paragraphs.Add(image)
            Dim footNote As New TextFragment("footnote text")
            footNote.TextState.FontSize = 20
            footNote.IsInLineParagraph = True
            text.FootNote.Paragraphs.Add(footNote)
            Dim table As New Table()
            table.Rows.Add().Cells.Add().Paragraphs.Add(New TextFragment("Row 1 Cell 1"))
            text.FootNote.Paragraphs.Add(table)

            dataDir = dataDir & Convert.ToString("AddImageAndTable_out_.pdf")

            ' Save resulting PDF document.
            doc.Save(dataDir)
            ' ExEnd:AddImageAndTable
            Console.WriteLine(Convert.ToString(vbLf & "Table and image added successfully to FootNote." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub CreateEndNotes()
            ' ExStart:CreateEndNotes
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()
            ' Create Document instance
            Dim doc As New Document()
            ' Add page to pages collection of PDF
            Dim page As Page = doc.Pages.Add()
            ' Create TextFragment instance
            Dim text As New TextFragment("Hello World")
            ' Set FootNote value for TextFragment
            text.EndNote = New Note("sample End note")
            ' Specify custom label for FootNote
            text.EndNote.Text = " Aspose(2015)"
            ' Add TextFragment to paragraphs collection of first page of document
            page.Paragraphs.Add(text)

            dataDir = dataDir & Convert.ToString("CreateEndNotes_out_.pdf")
            ' Save resulting PDF document.
            doc.Save(dataDir)
            ' ExEnd:CreateEndNotes
            Console.WriteLine(Convert.ToString(vbLf & "EndNotes created successfully." & vbLf & "File saved at ") & dataDir)
        End Sub

    End Class
End Namespace