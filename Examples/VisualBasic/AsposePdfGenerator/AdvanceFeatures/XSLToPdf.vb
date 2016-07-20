Imports System.IO
Imports System
Imports System.Xml
Imports System.Xml.Xsl
Imports Aspose.Pdf

Namespace AsposePdfGenerator.AdvanceFeatures
    Public Class XSLToPdf
        Public Shared Sub Run()
            Try
                ' ExStart:XSLToPdf
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures()

                Dim xmlDoc As New XmlDocument()
                Dim ms As New MemoryStream()

                Dim xsl As New XslCompiledTransform()
                xsl.Load(dataDir & Convert.ToString("test.xsl"))
                xsl.Transform(xmlDoc, Nothing, ms)

                ms.Position = 0
                xmlDoc.Load(ms)
                ms.Close()

                ' Instantiate the Pdf instance 
                Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
                ' Bind the XML file
                pdf1.BindXML(xmlDoc, Nothing)
                ' Save the resultant PDF
                ' ExEnd:XSLToPdf    
                pdf1.Save(dataDir & Convert.ToString("XSLToPdf_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace