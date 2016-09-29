Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class MHTToPDF
        Public Shared Sub Run()
            ' ExStart:MHTToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()
            Dim options As New MhtLoadOptions()
            ' Load document
            Dim document As New Document(dataDir & Convert.ToString("samplevb.mht"), options)
            ' Save the output as PDF document
            document.Save(dataDir & Convert.ToString("MHTToPDF_out_.pdf"))
            ' ExEnd:MHTToPDF
        End Sub
    End Class
End Namespace
