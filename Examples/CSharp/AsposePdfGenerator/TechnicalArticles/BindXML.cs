using System;
using System.IO;
using Aspose.Pdf;
using System.Xml;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class BindXML
    {
        public static void Run()
        {
            // ExStart:BindXML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(dataDir + "Sample.xml");

            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            // Object xmlDoc contains all contents from original word document in XML format defined in Aspose.PDF XML Schema. 
            pdf.BindXML(xmlDoc, null);

            // Before saving, to add bookmarks from headings. 
            pdf.IsBookmarked = true;

            foreach (Aspose.Pdf.Generator.Section sec in pdf.Sections)
            {
                foreach (Aspose.Pdf.Generator.Paragraph para in sec.Paragraphs)
                {
                    if (para is Aspose.Pdf.Generator.Heading)
                    {
                        Aspose.Pdf.Generator.Heading h = para as Aspose.Pdf.Generator.Heading;
                        h.IsInList = true;
                    }
                }
            }
            pdf.Save(dataDir + "BindXML_out.pdf");
            // ExEnd:BindXML           
        }
    }
}