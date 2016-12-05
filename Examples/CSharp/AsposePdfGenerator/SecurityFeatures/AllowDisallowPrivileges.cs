using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.SecurityFeatures
{
    public class AllowDisallowPrivileges
    {
        public static void Run()
        {
            // ExStart:AllowDisallowPrivileges
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_SecurityFeatures();

            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Assign a security instance to Pdf object            
            pdf1.Security = new Aspose.Pdf.Generator.Security();

            // Restrict annotation modification
            pdf1.Security.IsAnnotationsModifyingAllowed = false;

            // Restrict contents modification
            pdf1.Security.IsContentsModifyingAllowed = false;

            // Restrict copying the data
            pdf1.Security.IsCopyingAllowed = false;

            // Allow to print the document
            pdf1.Security.IsPrintingAllowed = true;

            // Restrict form filling
            pdf1.Security.IsFormFillingAllowed = false;

            // Add a section in the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a text paragraph                           
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1, "this is text content");

            // Set the top maring of text paragraph to 30
            text1.Margin.Top = 30;

            // Add the text paragraph to the section
            sec1.Paragraphs.Add(text1);

            dataDir = dataDir + "AllowDisallowPrivileges_out.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:AllowDisallowPrivileges           
        }
    }
}