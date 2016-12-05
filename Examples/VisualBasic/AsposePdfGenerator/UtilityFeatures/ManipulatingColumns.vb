Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.UtilityFeatures
    Public Class ManipulatingColumns
        Public Shared Sub Run()
            ' ExStart:ManipulatingColumns
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()

            ' Instantiate a Pdf object
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Add a section to the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Set the number of columns in the section to 3
            sec1.ColumnInfo.ColumnCount = 3

            dataDir = dataDir & Convert.ToString("ManipulatingColumns_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:ManipulatingColumns           
        End Sub
        Public Shared Sub MultipleColumnsWithDefaultSpacing()
            ' ExStart:MultipleColumnsWithDefaultSpacing
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()

            ' Instantiate a Pdf object
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Add a section to the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Add two columns in the section
            sec1.ColumnInfo.ColumnCount = 2

            ' Set the spacing between the columns
            sec1.ColumnInfo.ColumnSpacing = "15"

            ' Set the widths of the columns
            sec1.ColumnInfo.ColumnWidths = "250 150"

            dataDir = dataDir & Convert.ToString("MultipleColumnsWithDefaultSpacing_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:MultipleColumnsWithDefaultSpacing           
        End Sub
        Public Shared Sub ParagraphsCustomPositioning()
            ' ExStart:ParagraphsCustomPositioning
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()

            ' Instantiate the Pdf object
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Add a section to the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a text paragraph
            Dim text1 As New Aspose.Pdf.Generator.Text("This is a text paragraph.")

            ' Set the id of the paragraph to "text1" so that it can referenced uniquely
            text1.ID = "text1"

            ' Add the paragraph to the section
            sec1.Paragraphs.Add(text1)

            ' Create a graph with specified left and top position settings. Set its
            ' Poition relative to the page. Add a rectangle to its shapes collection and
            ' Then add the graph to the paragraph collection of the section
            Dim graph1 As New Aspose.Pdf.Generator.Graph(200, 50)
            graph1.Left = 200
            graph1.Top = 10
            graph1.PositioningType = Aspose.Pdf.Generator.PositioningType.PageRelative
            graph1.Shapes.Add(New Aspose.Pdf.Generator.Rectangle(0, 0, 200, 50))
            sec1.Paragraphs.Add(graph1)

            ' Create an attachment as note annotation and add it to the section as a
            ' Pragraph. Set the content and heading for the note. Set its position relative
            ' To the paragraph. Assign a unique id to this note annotation for the
            ' Reference purposes and then customize its left and top position
            Dim noteAttachment As New Aspose.Pdf.Generator.Attachment()
            sec1.Paragraphs.Add(noteAttachment)
            noteAttachment.AttachmentType = Aspose.Pdf.Generator.AttachmentType.Note
            noteAttachment.NoteContent = "This is a test for note"
            noteAttachment.NoteHeading = "this is a Note"
            noteAttachment.PositioningType = Aspose.Pdf.Generator.PositioningType.ParagraphRelative
            noteAttachment.ReferenceParagraphID = "text1"
            noteAttachment.Left = 200
            noteAttachment.Top = 0

            dataDir = dataDir & Convert.ToString("ParagraphsCustomPositioning_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:ParagraphsCustomPositioning           
        End Sub

    End Class
End Namespace