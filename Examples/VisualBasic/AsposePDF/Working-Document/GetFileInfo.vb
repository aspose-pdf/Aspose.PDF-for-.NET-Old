Imports System.IO
Imports System
Imports Aspose.Pdf
Namespace AsposePDF.WorkingDocuments
    Public Class GetFileInfo
        Public Shared Sub Run()
            ' ExStart:GetFileInfo
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetFileInfo.pdf"))
            ' Get document information
            Dim docInfo As DocumentInfo = pdfDocument.Info
            ' Show document information
            Console.WriteLine("Author: {0}", docInfo.Author)
            Console.WriteLine("Creation Date: {0}", docInfo.CreationDate)
            Console.WriteLine("Keywords: {0}", docInfo.Keywords)
            Console.WriteLine("Modify Date: {0}", docInfo.ModDate)
            Console.WriteLine("Subject: {0}", docInfo.Subject)
            Console.WriteLine("Title: {0}", docInfo.Title)
            ' ExEnd:GetFileInfo
        End Sub
    End Class
End Namespace
