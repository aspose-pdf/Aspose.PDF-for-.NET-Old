Imports System.IO
Imports System
Imports Aspose.Pdf
Namespace AsposePdfGenerator.AdvanceFeatures
    Public Class MergeXMLFiles
        Public Shared Sub Run()
            ' ExStart:MergeXMLFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures()

            Dim fs1 As New FileStream(dataDir & Convert.ToString("XSLFOToPDF.xml"), FileMode.Open)
            Dim fs2 As New FileStream(dataDir & Convert.ToString("XSLFOToPDF.xsl"), FileMode.Open)

            ' Instantiate the Pdf instance 
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Bind the XML and XSLT file
            pdf1.BindXML(fs1, fs2)
            ' Save the resultant PDF
            pdf1.Save(dataDir & Convert.ToString("XMlXSLTMERGE_out_.pdf"))

            fs1.Close()
            fs2.Close()
            ' ExEnd:MergeXMLFiles           
        End Sub
    End Class
End Namespace