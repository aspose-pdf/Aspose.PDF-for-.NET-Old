Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Attachments
    Public Class CustomizeNotePosition
        Public Shared Sub Run()
            ' ExStart:CustomizeNotePosition
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Attachments()

            ' Instantiate Pdf document object 
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Instantiate attachment instance by calling its empty constructor
            Dim noteAttachment As New Aspose.Pdf.Generator.Attachment()

            ' Add the attachment in the paragraphs collection of the section
            sec1.Paragraphs.Add(noteAttachment)

            ' Set the attachment type to Note
            noteAttachment.AttachmentType = Aspose.Pdf.Generator.AttachmentType.Note

            ' Store some content for the note to display
            noteAttachment.NoteContent = "This is a test for note popup window positioning."

            ' Set the heading or title of the note
            noteAttachment.NoteHeading = "Test"

            ' Set the note to be opened when PDF document is opened
            noteAttachment.IsNoteOpen = True

            ' Set the positioning type of the note's popup window to Absolute
            noteAttachment.NoteWindowPositioningType = Aspose.Pdf.Generator.NoteWindowPositioningType.Absolute

            ' Set the position of the note's popup window
            noteAttachment.NoteWindowPosition = New Aspose.Pdf.Generator.RectangleArea(100, 100, 160, 100)

            dataDir = dataDir & Convert.ToString("CustomizeNotePosition_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:CustomizeNotePosition           
        End Sub
    End Class
End Namespace