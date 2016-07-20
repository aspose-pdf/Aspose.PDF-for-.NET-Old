Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.WorkingDocument
    Public Class GetXMPMetadata
        Public Shared Sub Run()
            ' ExStart:GetXMPMetadata
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments()

            ' Create PdfXmpMetadata object
            Dim xmpMetaData As New PdfXmpMetadata()

            ' Bind pdf file to the object
            xmpMetaData.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Get XMP Meta Data properties
            Console.WriteLine(": {0}", xmpMetaData(DefaultMetadataProperties.CreateDate).ToString())
            Console.WriteLine(": {0}", xmpMetaData(DefaultMetadataProperties.MetadataDate).ToString())
            Console.WriteLine(": {0}", xmpMetaData(DefaultMetadataProperties.CreatorTool).ToString())
            Console.WriteLine(": {0}", xmpMetaData("customNamespace:UserPropertyName").ToString())

            Console.ReadLine()
            ' ExEnd:GetXMPMetadata
        End Sub
    End Class
End Namespace