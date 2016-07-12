using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Attachments
{
    public class CustomizeNotePosition
    {
        public static void Run()
        {
            // ExStart:CustomizeNotePosition
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Attachments();

            // Instantiate Pdf document object 
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Create a section in the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Instantiate attachment instance by calling its empty constructor
            Aspose.Pdf.Generator.Attachment noteAttachment = new Aspose.Pdf.Generator.Attachment();

            // Add the attachment in the paragraphs collection of the section
            sec1.Paragraphs.Add(noteAttachment);

            // Set the attachment type to Note
            noteAttachment.AttachmentType = Aspose.Pdf.Generator.AttachmentType.Note;

            // Store some content for the note to display
            noteAttachment.NoteContent =
                   "This is a test for note popup window positioning.";

            // Set the heading or title of the note
            noteAttachment.NoteHeading = "Test";

            // Set the note to be opened when PDF document is opened
            noteAttachment.IsNoteOpen = true;

            // Set the positioning type of the note's popup window to Absolute
            noteAttachment.NoteWindowPositioningType = Aspose.Pdf.Generator.NoteWindowPositioningType.Absolute;

            // Set the position of the note's popup window
            noteAttachment.NoteWindowPosition = new Aspose.Pdf.Generator.RectangleArea(100, 100, 160, 100); 

            dataDir = dataDir + "CustomizeNotePosition_out_.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:CustomizeNotePosition           
        }
    }
}