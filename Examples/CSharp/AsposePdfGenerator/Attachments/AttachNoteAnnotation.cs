using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Attachments
{
    public class AttachNoteAnnotation
    {
        public static void Run()
        {
            // ExStart:AttachNoteAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Attachments();

            // Instantiate Pdf document object 
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Create a section in the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Instantiate attachment instance
            Aspose.Pdf.Generator.Attachment noteAttachment = new Aspose.Pdf.Generator.Attachment();

            // Add the attachment in the paragraphs collection of the section
            sec1.Paragraphs.Add(noteAttachment);

            // Set the attachment type to note to make it a note annotation
            noteAttachment.AttachmentType = Aspose.Pdf.Generator.AttachmentType.Note;

            // Set the content of the note annotation
            noteAttachment.NoteContent = "This is a note.";

            // Set the title or heading of the note
            noteAttachment.NoteHeading = "The title";

            // Set the note to be opened when PDF document is opened
            noteAttachment.IsNoteOpen = true; 

            dataDir = dataDir + "AttachNoteAnnotation_out.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:AttachNoteAnnotation           
        }
    }
}