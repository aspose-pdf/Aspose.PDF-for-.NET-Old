'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Xml
Imports System.Xml.XPath

Imports Aspose.Pdf

Namespace VisualBasic.AsposePdfGenerator.Conversion
    Public Class XSLFOToPDF
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Conversion()

            'Set up your product license.
            'If you just want to evaluate Aspose.Pdf, you can annotate these two lines.
            'License license = new License();
            'license.SetLicense(dataDir + "Aspose.Total.lic");

            'Create a Converter object..
            Dim app As Aspose.Pdf.Generator.Pdf

            Dim pdf As System.IO.Stream
            Dim name As String = "test"
            Dim fo As String = dataDir & name & ".fo"
            Dim xml As String = dataDir & name & ".xml"
            Dim xsl As String = dataDir & name & ".xsl"

            ' Create the XmlDocument.
            Dim doc_fo As New XmlDocument()
            doc_fo.Load(New StreamReader(fo))

            Dim doc_xml As New XPathDocument(xml)

            Dim doc_xsl As New XmlDocument()
            doc_xsl.Load(New StreamReader(xsl))


            '1. fo:string2string
            app = New Aspose.Pdf.Generator.Pdf()
            app.BindFO(fo)
            app.Save(dataDir & name & "_fo_sring2string.pdf")

            '2. fo:string2stream
            app = New Aspose.Pdf.Generator.Pdf()
            app.BindFO(fo)
            pdf = New System.IO.FileStream(name & "_fo_string2stream.pdf", System.IO.FileMode.Create)
            app.Save(pdf)

            '3. fo:stream2string
            app = New Aspose.Pdf.Generator.Pdf()
            app.BindFO(doc_fo, doc_xsl)
            'app.BindFO(new System.IO.FileStream(fo, System.IO.FileMode.Open, System.IO.FileAccess.Read));
            app.Save(dataDir & name & "_fo_stream2string.pdf")

            '4. fo:stream2stream 
            app = New Aspose.Pdf.Generator.Pdf()
            'app.BindFO(new System.IO.FileStream(fo, System.IO.FileMode.Open, System.IO.FileAccess.Read));
            'pdf = new System.IO.FileStream(name + "_fo_stream2stream.pdf", System.IO.FileMode.Create);
            'app.Save(pdf);


            '5. fo:doc2string
            app = New Aspose.Pdf.Generator.Pdf()
            app.BindFO(doc_fo)
            app.Save(dataDir & name & "_fo_doc2string.pdf")

            '6. fo:doc2stream
            app = New Aspose.Pdf.Generator.Pdf()
            app.BindFO(doc_fo)
            pdf = New System.IO.FileStream(name & "_fo_doc2stream.pdf", System.IO.FileMode.Create)
            app.Save(pdf)

            '7. xml:string2string
            app = New Aspose.Pdf.Generator.Pdf()
            'app.BindFO(xml, xsl);
            app.BindFO(xml)
            app.Save(dataDir & name & "_xml_string2string.pdf")

            '8. xml:string2stream
            app = New Aspose.Pdf.Generator.Pdf()
            app.BindFO(xml) ', xsl);
            pdf = New System.IO.FileStream(name & "_xml_string2stream.pdf", System.IO.FileMode.Create)
            app.Save(pdf)

            '9. xml:doc2string
            'app = new Aspose.Pdf.Generator.Pdf();
            'app.BindFO(doc_xml, xsl);
            'app.Save(dataDir + name + "_xml_doc2string.pdf");

            '10. xml:doc2stream
            app = New Aspose.Pdf.Generator.Pdf()
            'app.BindFO(doc_xml, xsl);
            pdf = New System.IO.FileStream(name & "_xml_doc2stream.pdf", System.IO.FileMode.Create)
            app.Save(pdf)

            '0. An example of how to set the metadata of your generated pdf document
            'If you do not want to set these tedious metadata of pdf, you can set the
            'second parameter of Save method to be "null" simply, as shown in above.

            'At first create a IDictionary to contain your metadata.
            Dim metadata As System.Collections.IDictionary = New System.Collections.Hashtable()

            'Then set the various items.
            'If you don't set them, Aspose.Pdf.Fo will set default value.
            'a. title of your pdf doc:
            metadata.Add("Title", "New Title")
            'b. author of your pdf doc:
            metadata.Add("Author", "New Author")
            'c. subject of your pdf doc:
            metadata.Add("Subject", "New Subject")
            'd. keywords of your pdf doc:
            metadata.Add("Keywords", "New Key Words")
            'e. creator of your pdf doc:
            metadata.Add("Creator", "New Creator")
            'f. producer of your pdf doc:
            metadata.Add("Producer", "New Producer")

            'Make this IDictionary be the parameter of Save method, and start converting.
            app = New Aspose.Pdf.Generator.Pdf()
            'app.FoMetaData = metadata;
            app.BindFO(fo)

            app.Save(dataDir & "Test.pdf")
        End Sub
    End Class
End Namespace
