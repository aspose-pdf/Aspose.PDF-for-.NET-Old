Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.SecuritySignatures
    Public Class DecryptFile
        Public Shared Sub Run()
            ' ExStart:DecryptFile
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()
            ' Create PdfFileSecurity object 
            Dim fileSecurity As New PdfFileSecurity()
            fileSecurity.BindPdf(dataDir & Convert.ToString("Decrypt.pdf"))
            ' Decrypt PDF document
            fileSecurity.DecryptFile("owner")
            fileSecurity.Save(dataDir & Convert.ToString("DecryptFile_out_.pdf"))
            ' ExEnd:DecryptFile   
        End Sub
    End Class
End Namespace
