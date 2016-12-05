using System;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.AdvanceFeatures
{
    public class XSLToPdf
    {
        public static void Run()
        {
            try
            {
                // ExStart:XSLToPdf
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures();

                XmlDocument xmlDoc = new XmlDocument();
                MemoryStream ms = new MemoryStream();

                XslCompiledTransform xsl = new XslCompiledTransform();
                xsl.Load(dataDir + "test.xsl");
                xsl.Transform(xmlDoc, null, ms);

                ms.Position = 0;
                xmlDoc.Load(ms);
                ms.Close();

                // Instantiate the Pdf instance 
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
                // Bind the XML file
                pdf1.BindXML(xmlDoc, null);
                // Save the resultant PDF
                pdf1.Save(dataDir + "XSLToPdf_out.pdf");
                // ExEnd:XSLToPdf    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}