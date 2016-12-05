using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.UtilityFeatures
{
    public class ManipulatingColumns
    {
        public static void Run()
        {
            // ExStart:ManipulatingColumns
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Instantiate a Pdf object
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Add a section to the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Set the number of columns in the section to 3
            sec1.ColumnInfo.ColumnCount = 3;

            dataDir = dataDir + "ManipulatingColumns_out.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:ManipulatingColumns           
        }
        public static void MultipleColumnsWithDefaultSpacing()
        {
            // ExStart:MultipleColumnsWithDefaultSpacing
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Instantiate a Pdf object
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Add a section to the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Add two columns in the section
            sec1.ColumnInfo.ColumnCount = 2;

            // Set the spacing between the columns
            sec1.ColumnInfo.ColumnSpacing = "15";

            // Set the widths of the columns
            sec1.ColumnInfo.ColumnWidths = "250 150";

            dataDir = dataDir + "MultipleColumnsWithDefaultSpacing_out.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:MultipleColumnsWithDefaultSpacing           
        }
        public static void ParagraphsCustomPositioning()
        {
            // ExStart:ParagraphsCustomPositioning
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Instantiate the Pdf object
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Add a section to the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a text paragraph
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text("This is a text paragraph.");

            // Set the id of the paragraph to "text1" so that it can referenced uniquely
            text1.ID = "text1";

            // Add the paragraph to the section
            sec1.Paragraphs.Add(text1);

            // Create a graph with specified left and top position settings. Set its
            // Poition relative to the page. Add a rectangle to its shapes collection and
            // Then add the graph to the paragraph collection of the section
            Aspose.Pdf.Generator.Graph graph1 = new Aspose.Pdf.Generator.Graph(200, 50);
            graph1.Left = 200;
            graph1.Top = 10;
            graph1.PositioningType = Aspose.Pdf.Generator.PositioningType.PageRelative;
            graph1.Shapes.Add(new Aspose.Pdf.Generator.Rectangle(0, 0, 200, 50));
            sec1.Paragraphs.Add(graph1);

            // Create an attachment as note annotation and add it to the section as a
            // Pragraph. Set the content and heading for the note. Set its position relative
            // To the paragraph. Assign a unique id to this note annotation for the
            // Reference purposes and then customize its left and top position
            Aspose.Pdf.Generator.Attachment noteAttachment = new Aspose.Pdf.Generator.Attachment();
            sec1.Paragraphs.Add(noteAttachment);
            noteAttachment.AttachmentType = Aspose.Pdf.Generator.AttachmentType.Note;
            noteAttachment.NoteContent = "This is a test for note";
            noteAttachment.NoteHeading = "this is a Note";
            noteAttachment.PositioningType = Aspose.Pdf.Generator.PositioningType.ParagraphRelative;
            noteAttachment.ReferenceParagraphID = "text1";
            noteAttachment.Left = 200;
            noteAttachment.Top = 0; 

            dataDir = dataDir + "ParagraphsCustomPositioning_out.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:ParagraphsCustomPositioning           
        }
       
    }
}