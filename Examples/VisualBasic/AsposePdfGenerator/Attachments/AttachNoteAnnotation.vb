Imports System.IO
Imports System
Imports Aspose.Pdf
Namespace AsposePdfGenerator.Attachments
    Public Class AttachNoteAnnotation
        Public Shared Sub Run()
            ' ExStart:AttachNoteAnnotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Attachments()

            ' Instantiate Pdf document object 
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Instantiate attachment instance
            Dim noteAttachment As New Aspose.Pdf.Generator.Attachment()

            ' Add the attachment in the paragraphs collection of the section
            sec1.Paragraphs.Add(noteAttachment)

            ' Set the attachment type to note to make it a note annotation
            noteAttachment.AttachmentType = Aspose.Pdf.Generator.AttachmentType.Note

            ' Set the content of the note annotation
            noteAttachment.NoteContent = "This is a note."

            ' Set the title or heading of the note
            noteAttachment.NoteHeading = "The title"

            ' Set the note to be opened when PDF document is opened
            noteAttachment.IsNoteOpen = True

            dataDir = dataDir & Convert.ToString("AttachNoteAnnotation_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:AttachNoteAnnotation           
        End Sub
    End Class
End Namespace