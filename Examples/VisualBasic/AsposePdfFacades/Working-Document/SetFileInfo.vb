Imports Microsoft.VisualBasic
Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDFFacades.WorkingDocument
    Public Class SetFileInfo
        Public Shared Sub Run()
            ' ExStart:SetFileInfo
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments()
            ' Open document
            Dim fileInfo As New PdfFileInfo(dataDir & "SetFileInfo.pdf")
            ' Set PDF information
            fileInfo.Author = "Aspose"
            fileInfo.Title = "Hello World!"
            fileInfo.Keywords = "Peace and Development"
            fileInfo.Creator = "Aspose"
            ' Save updated file
            fileInfo.SaveNewInfo(dataDir & "SetFileInfo_out_.pdf")
            ' ExEnd:SetFileInfo

        End Sub
    End Class
End Namespace