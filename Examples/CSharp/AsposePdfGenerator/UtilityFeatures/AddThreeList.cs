using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.UtilityFeatures
{
    public class AddThreeList
    {
        public static void Run()
        {
            // ExStart:AddThreeList
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a list section
            Aspose.Pdf.Generator.ListSection tocSection = new Aspose.Pdf.Generator.ListSection("Table Of Contents");

            // Set its list type as table of of contents
            tocSection.ListType = Aspose.Pdf.Generator.ListType.TableOfContents;

            // Add the list section to the sections collection of the Pdf document
            pdf1.Sections.Add(tocSection);

            // Create a list section
            Aspose.Pdf.Generator.ListSection lotSection = new Aspose.Pdf.Generator.ListSection("List of Tables");

           
            // Set its list type as list of tables
            lotSection.ListType = Aspose.Pdf.Generator.ListType.ListOfTables;

            // Add the list section to the sections collection of the Pdf document
            pdf1.Sections.Add(lotSection);

            // Create a list section
            Aspose.Pdf.Generator.ListSection lofSection = new Aspose.Pdf.Generator.ListSection("List of Figures");

            // Set its list type as list of figures
            lofSection.ListType = Aspose.Pdf.Generator.ListType.ListOfFigures;

            // Add the list section to the sections collection of the Pdf document
            pdf1.Sections.Add(lofSection); 

            dataDir = dataDir + "AddThreeList_out.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:AddThreeList           
        }
       
    }
}