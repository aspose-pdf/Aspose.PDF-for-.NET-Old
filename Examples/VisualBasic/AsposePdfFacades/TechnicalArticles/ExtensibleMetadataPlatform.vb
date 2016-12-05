Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class ExtensibleMetadataPlatform
        Public Shared Sub Run()
            ' ExStart:ExtensibleMetadataPlatform
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create an object of PdfXmpMetadata class
            Dim xmpMetaData As New Aspose.Pdf.Facades.PdfXmpMetadata()

            ' Create input and output file streams
            Dim input As New FileStream(dataDir & Convert.ToString("FilledForm.pdf"), FileMode.Open)

            Dim output As New FileStream(dataDir & Convert.ToString("xmp_out_.pdf"), FileMode.Create)

            ' Set input file stream
            xmpMetaData.BindPdf(input)

            ' Add base URL property to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.BaseURL, "xmlns:pdf=http://ns.adobe.com/pdf/1.3/")

            ' Add creation date property to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.CreateDate, System.DateTime.Now.ToString())

            ' Add Metadata Date property to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.MetadataDate, System.DateTime.Now.ToString())

            ' Add Creator Tool property to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.CreatorTool, "Creator Tool Name")

            ' Add Modify Date to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.ModifyDate, System.DateTime.Now.ToString())

            ' Add Nick Name to xmp metadata
            xmpMetaData.Add(DefaultMetadataProperties.Nickname, "Test")

            ' Save xmp meta data in the pdf file
            xmpMetaData.Save(output)

            ' Close input and output file streams
            input.Close()
            output.Close()
            ' ExEnd:ExtensibleMetadataPlatform                      
        End Sub
    End Class
End Namespace
