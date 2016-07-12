Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDF.SecuritySignatures
    Public Class IsPasswordProtected
        Public Shared Sub Run()
            ' ExStart:IsPasswordProtected
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()

            ' Load the source PDF doucment
            Dim fileInfo As New PdfFileInfo(dataDir & Convert.ToString("IsPasswordProtected.pdf"))
            ' Determine that source PDF file is Encrypted with password
            Dim encrypted As Boolean = fileInfo.IsEncrypted
            ' MessageBox displays the current status related to PDf encryption
            Console.WriteLine(encrypted.ToString())
            ' ExEnd:IsPasswordProtected

        End Sub
    End Class
End Namespace
