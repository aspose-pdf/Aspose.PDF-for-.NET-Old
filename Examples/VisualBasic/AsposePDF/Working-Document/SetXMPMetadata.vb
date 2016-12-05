Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.WorkingDocuments
    Public Class SetXMPMetadata
        Public Shared Sub Run()
            ' ExStart:SetXMPMetadata
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("SetXMPMetadata.pdf"))

            ' Set properties
            pdfDocument.Metadata("xmp:CreateDate") = DateTime.Now
            pdfDocument.Metadata("xmp:Nickname") = "Nickname"
            pdfDocument.Metadata("xmp:CustomProperty") = "Custom Value"

            dataDir = dataDir & Convert.ToString("SetXMPMetadata_out_.pdf")
            ' Save document
            pdfDocument.Save(dataDir)
            ' ExEnd:SetXMPMetadata
            Console.WriteLine(Convert.ToString(vbLf & "XMP metadata in a pdf file setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub SetPrefixMetadata()
            ' ExStart:SetPrefixMetadata
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("SetXMPMetadata.pdf"))
            pdfDocument.Metadata.RegisterNamespaceUri("xmp", "http://ns.adobe.com/xap/1.0/")
            ' Xmlns prefix was removed
            pdfDocument.Metadata("xmp:ModifyDate") = DateTime.Now

            dataDir = dataDir & Convert.ToString("SetPrefixMetadata_out_.pdf")
            ' Save document
            pdfDocument.Save(dataDir)
            ' ExEnd:SetPrefixMetadata

        End Sub
    End Class
End Namespace
