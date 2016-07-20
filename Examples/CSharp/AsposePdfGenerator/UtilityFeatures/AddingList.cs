using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.UtilityFeatures
{
    public class AddingList
    {
        public static void Run()
        {
            // ExStart:AddingList
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

            dataDir = dataDir + "AddingList_out_.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:AddingList           
        }
        public static void DefineFormat()
        {
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a list section 
            Aspose.Pdf.Generator.ListSection tocSection = new Aspose.Pdf.Generator.ListSection("Table Of Contents");

            // Set its list type as table of of contents
            tocSection.ListType = Aspose.Pdf.Generator.ListType.TableOfContents;

            // ExStart:DefineFormat
            // Set the length of list levels to 3 and set their left margins and text formats 
            tocSection.ListFormatArray.Length = 3;
            tocSection.ListFormatArray[0].LeftMargin = 0;
            tocSection.ListFormatArray[0].TextInfo.FontSize = 16;
            tocSection.ListFormatArray[0].TextInfo.IsTrueTypeFontBold = true;
            tocSection.ListFormatArray[1].LeftMargin = 16;
            tocSection.ListFormatArray[1].TextInfo.FontSize = 14;
            tocSection.ListFormatArray[2].LeftMargin = 32;
            tocSection.ListFormatArray[2].TextInfo.FontSize = 12;
            // ExEnd:DefineFormat  

            // Add the list section to the sections collection of the Pdf document
            pdf1.Sections.Add(tocSection);

            dataDir = dataDir + "DefineFormat_out_.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
                     
        }
        public static void DefineOwnFormat()
        {

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a list section 
            Aspose.Pdf.Generator.ListSection tocSection = new Aspose.Pdf.Generator.ListSection("Table Of Contents");

            // Set its list type as table of of contents
            tocSection.ListType = Aspose.Pdf.Generator.ListType.TableOfContents;

            // ExStart:DefineOwnFormat
            // Define the format of the four levels list by setting the left margins and
            // text format settings of each level
            tocSection.ListFormatArray.Length = 4;
            tocSection.ListFormatArray[0].LeftMargin = 0;
            tocSection.ListFormatArray[0].TextInfo.IsTrueTypeFontBold = true;
            tocSection.ListFormatArray[0].TextInfo.IsTrueTypeFontItalic = true;
            tocSection.ListFormatArray[1].LeftMargin = 10;
            tocSection.ListFormatArray[1].TextInfo.IsUnderline = true;
            tocSection.ListFormatArray[1].TextInfo.FontSize = 10;
            tocSection.ListFormatArray[2].LeftMargin = 20;
            tocSection.ListFormatArray[2].TextInfo.IsTrueTypeFontBold = true;
            tocSection.ListFormatArray[3].LeftMargin = 30;
            tocSection.ListFormatArray[3].TextInfo.IsTrueTypeFontBold = true; 
            // ExEnd:DefineOwnFormat  

            // Add the list section to the sections collection of the Pdf document
            pdf1.Sections.Add(tocSection);

            dataDir = dataDir + "DefineOwnFormat_out_.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);

        }

    }
}