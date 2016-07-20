Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Attachments
    Public Class DisableFilesCompression
        Public Shared Sub Run()
            ' ExStart:DisableFilesCompression
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Attachments()

            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetAlltheAttachments.pdf"))
            ' Setup new file to be added as attachment
            Dim fileSpecification As New FileSpecification("test_out_.txt", "Sample text file")
            ' Specify Encoding proparty setting it to FileEncoding.None
            fileSpecification.Encoding = FileEncoding.None
            ' Add attachment to document's attachment collection
            pdfDocument.EmbeddedFiles.Add(fileSpecification)
            dataDir = dataDir & Convert.ToString("DisableFilesCompression_out_.pdf")
            ' Save new output
            pdfDocument.Save(dataDir)
            ' ExEnd:DisableFilesCompression
            Console.WriteLine(Convert.ToString(vbLf & "File compression disabled successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
