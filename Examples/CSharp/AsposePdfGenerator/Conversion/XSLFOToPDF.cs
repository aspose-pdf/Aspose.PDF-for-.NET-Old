using System.IO;
using System.Xml;
using System.Xml.XPath;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Conversion
{
    public class XSLFOToPDF
    {
        public static void Run()
        {
            // ExStart:XSLFOToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Conversion();

            // Set up your product license.
            // If you just want to evaluate Aspose.Pdf, you can annotate these two lines.
            // License license = new License();
            // License.SetLicense(dataDir + "Aspose.Total.lic");

            // Create a Converter object..
            Aspose.Pdf.Generator.Pdf app;

            System.IO.Stream pdf;
            string name = "XSLFOToPDF";
            string fo = dataDir + name + ".fo";
            string xml = dataDir + name + ".xml";
            string xsl = dataDir + name + ".xsl";

            // Create the XmlDocument.
            XmlDocument doc_fo = new XmlDocument();
            doc_fo.Load(new StreamReader(fo));
            
            XPathDocument doc_xml = new XPathDocument(xml);
            
            XmlDocument doc_xsl = new XmlDocument();
            doc_xsl.Load(new StreamReader(xsl));

            // 1. fo:string2string
            app = new Aspose.Pdf.Generator.Pdf();
            app.BindFO(fo);
            app.Save(dataDir + name + "_fo_sring2string.pdf");

            // 2. fo:string2stream
            app = new Aspose.Pdf.Generator.Pdf();
            app.BindFO(fo);
            pdf = new System.IO.FileStream(name + "_fo_string2stream.pdf", System.IO.FileMode.Create);
            app.Save(pdf);

            // 3. fo:stream2string
            app = new Aspose.Pdf.Generator.Pdf();
            app.BindFO(doc_fo, doc_xsl);           
            app.Save(dataDir + name + "_fo_stream2string.pdf");

            // 4. fo:stream2stream 
            app = new Aspose.Pdf.Generator.Pdf();
            app.BindFO(doc_fo, doc_xsl);
            pdf = new System.IO.FileStream(name + "_fo_stream2stream.pdf", System.IO.FileMode.Create);
            app.Save(pdf);

            // 5. fo:doc2string
            app = new Aspose.Pdf.Generator.Pdf();
            app.BindFO(doc_fo);
            app.Save(dataDir + name + "_fo_doc2string.pdf");

            // 6. fo:doc2stream
            app = new Aspose.Pdf.Generator.Pdf();
            app.BindFO(doc_fo);
            pdf = new System.IO.FileStream(name + "_fo_doc2stream.pdf", System.IO.FileMode.Create);
            app.Save(pdf);

            // 7. xml:string2string
            app = new Aspose.Pdf.Generator.Pdf();            
            app.BindFO(xml);
            app.Save(dataDir + name + "_xml_string2string.pdf");

            // 8. xml:string2stream
            app = new Aspose.Pdf.Generator.Pdf();
            app.BindFO(xml);//, xsl);
            pdf = new System.IO.FileStream(name + "_xml_string2stream.pdf", System.IO.FileMode.Create);
            app.Save(pdf);

            // 9. xml:doc2string
            app = new Aspose.Pdf.Generator.Pdf();
            app.BindFO(xml);
            app.Save(dataDir + name + "_xml_doc2string.pdf");

            // 10. xml:doc2stream
            app = new Aspose.Pdf.Generator.Pdf();
            app.BindFO(xml);
            pdf = new System.IO.FileStream(name + "_xml_doc2stream.pdf", System.IO.FileMode.Create);
            app.Save(pdf);

            // 0. An example of how to set the metadata of your generated pdf document
            // If you do not want to set these tedious metadata of pdf, you can set the
            // Second parameter of Save method to be "null" simply, as shown in above.

            // At first create a IDictionary to contain your metadata.
            System.Collections.IDictionary metadata = new System.Collections.Hashtable();

            // Then set the various items.
            // If you don't set them, Aspose.Pdf.Fo will set default value.
            // A. title of your pdf doc:
            metadata.Add("Title", "New Title");
            // B. author of your pdf doc:
            metadata.Add("Author", "New Author");
            // C. subject of your pdf doc:
            metadata.Add("Subject", "New Subject");
            // D. keywords of your pdf doc:
            metadata.Add("Keywords", "New Key Words");
            // E. creator of your pdf doc:
            metadata.Add("Creator", "New Creator");
            // F. producer of your pdf doc:
            metadata.Add("Producer", "New Producer");

            // Make this IDictionary be the parameter of Save method, and start converting.
            app = new Aspose.Pdf.Generator.Pdf();
            // App.FoMetaData = metadata;
            app.BindFO(fo);
            app.Save(dataDir + "Test_out.pdf");
            // ExEnd:XSLFOToPDF
        }
        public static void XSLFOToPDFUsingBind()
        {
            // ExStart:XSLFOToPDFUsingBind
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Conversion();
            // Create pdf document
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Bind FO document with Pdf object
            pdf.BindFO( dataDir + "XSLFOToPDF.fo");
            // Save the PDF document
            pdf.Save(dataDir + "XSLFOToPDFUsingBind_out.pdf");
            // ExEnd:XSLFOToPDFUsingBind
        }
       
    }
}
