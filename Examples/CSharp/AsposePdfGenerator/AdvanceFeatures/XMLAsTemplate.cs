using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.AdvanceFeatures
{
    public class XMLAsTemplate
    {
        public static void Run()
        {
            // ExStart:XMLAsTemplate
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures();

            // Create a Pdf instance and bind the XML template file to Pdf instance
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            pdf1.BindXML( dataDir + "Template.xml", null);

            // Get the section and then table from the obtained section of the Pdf that
            // is built from the XML template
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections["Section1"];
            Aspose.Pdf.Generator.Table table1 = sec1.Paragraphs["Table1"] as Aspose.Pdf.Generator.Table;

            // Clone a new table 
            Aspose.Pdf.Generator.Table table2 = table1.CompleteClone() as Aspose.Pdf.Generator.Table;

            // Change the ID of table2 to "Table2" to make it different from table1 
            table2.ID = "Table2";

            // Add table2 into the section
            sec1.Paragraphs.Add(table2);

            // Now there are 2 segments with ID "Item",
            // We change the IDs to make sure they are different 
            Aspose.Pdf.Generator.Segment item = sec1.GetObjectByID("Item") as Aspose.Pdf.Generator.Segment;
            item.ID = "Item1";
            item = sec1.GetObjectByID("Item") as Aspose.Pdf.Generator.Segment;
            item.ID = "Item2";

            // Change the content 
            item.Content = "item 2";

            // Now clone section1 
            Aspose.Pdf.Generator.Section sec2 = sec1.CompleteClone() as Aspose.Pdf.Generator.Section;

            // Add a cloned section to the Pdf and change the contents of the text segments
            // in the section2 of the Pdf object        
            pdf1.Sections.Add(sec2);
            item = sec2.GetObjectByID("Item1") as Aspose.Pdf.Generator.Segment;
            item.Content = "item1 sec2";
            item = sec2.GetObjectByID("Item2") as Aspose.Pdf.Generator.Segment;
            item.Content = "item2 sec2";

            // Save the Pdf
            pdf1.Save( dataDir + "XmlTemp_out_.pdf");   
            // ExEnd:XMLAsTemplate           
        }
    }
}