Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePDF.WorkingDocuments
    Public Class GetXMPMetadata
        Public Shared Sub Run()
            ' ExStart:GetXMPMetadata
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetXMPMetadata.pdf"))

            ' Get properties
            Console.WriteLine(pdfDocument.Metadata("xmp:CreateDate"))
            Console.WriteLine(pdfDocument.Metadata("xmp:Nickname"))
            Console.WriteLine(pdfDocument.Metadata("xmp:CustomProperty"))
            ' ExEnd:GetXMPMetadata
        End Sub
    End Class
End Namespace
