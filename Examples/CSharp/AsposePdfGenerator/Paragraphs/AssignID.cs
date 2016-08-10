using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Paragraphs
{
    public class AssignID
    {
        public static void Run()
        {
            // ExStart:AssignID
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Paragraphs();

            // Instantiate Pdf object by calling its empty constructor and add a new section to the Pdf object
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();             
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a text paragraph with the reference of a section, sec1 and add the text paragraph in the section
            Aspose.Pdf.Generator.Text text3 = new Aspose.Pdf.Generator.Text(sec1, "product 1 info ...");    
            sec1.Paragraphs.Add(text3);

            // Set the text paragraph to be the first paragraph among the other ones
            text3.IsFirstParagraph = true;

            // Assign and ID to the text paragraph
            text3.ID = "product1";

            dataDir = dataDir + "AssignID_out_.pdf";
            // Save the resultant PDF
            pdf1.Save(dataDir);
            // ExEnd:AssignID   
            Console.WriteLine("\nAn id assigned successfully to a paragraph.\nFile saved at " + dataDir);
        }
    }
}