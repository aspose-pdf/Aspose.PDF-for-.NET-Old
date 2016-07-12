Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Attachments
    Public Class DeleteAllAttachments
        Public Shared Sub Run()
            ' ExStart:DeleteAllAttachments
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Attachments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("DeleteAllAttachments.pdf"))

            ' Delete all attachments
            pdfDocument.EmbeddedFiles.Delete()

            dataDir = dataDir & Convert.ToString("DeleteAllAttachments_out_.pdf")

            ' Save updated file
            pdfDocument.Save(dataDir)
            ' ExEnd:DeleteAllAttachments
            Console.WriteLine(Convert.ToString(vbLf & "All attachments deleted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
