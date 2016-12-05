using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.AdvanceFeatures
{
    public class MergeXMLFiles
    {
        public static void Run()
        {
            // ExStart:MergeXMLFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures();

            FileStream fs1 = new FileStream(dataDir + "XSLFOToPDF.xml", FileMode.Open);
            FileStream fs2 = new FileStream(dataDir + "XSLFOToPDF.xsl", FileMode.Open);

            // Instantiate the Pdf instance 
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Bind the XML and XSLT file
            pdf1.BindXML(fs1, fs2);
            // Save the resultant PDF
            pdf1.Save(dataDir  + "XMlXSLTMERGE_out.pdf");

            fs1.Close();
            fs2.Close();
            // ExEnd:MergeXMLFiles           
        }
    }
}