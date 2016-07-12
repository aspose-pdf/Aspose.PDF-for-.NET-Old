Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.WorkingDocuments
    Public Class SetFileInfo
        Public Shared Sub Run()
            ' ExStart:SetFileInfo
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("SetFileInfo.pdf"))

            ' Specify document information
            Dim docInfo As New DocumentInfo(pdfDocument)

            docInfo.Author = "Aspose"
            docInfo.CreationDate = DateTime.Now
            docInfo.Keywords = "Aspose.Pdf, DOM, API"
            docInfo.ModDate = DateTime.Now
            docInfo.Subject = "PDF Information"
            docInfo.Title = "Setting PDF Document Information"

            dataDir = dataDir & Convert.ToString("SetFileInfo_out_.pdf")
            ' Save output document
            pdfDocument.Save(dataDir)
            ' ExEnd:SetFileInfo
            Console.WriteLine(Convert.ToString(vbLf & "File informations setup successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace