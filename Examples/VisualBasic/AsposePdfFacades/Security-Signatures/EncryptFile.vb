Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.SecuritySignatures
    Public Class EncryptFile
        Public Shared Sub Run()
            ' ExStart:EncryptFile
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()
            ' Create PdfFileSecurity object 
            Dim fileSecurity As New PdfFileSecurity()
            fileSecurity.BindPdf(dataDir & Convert.ToString("Encrypt.pdf"))
            ' Encrypt file using 256-bit encryption
            fileSecurity.EncryptFile("user", "owner", DocumentPrivilege.Print, KeySize.x256, Algorithm.AES)
            fileSecurity.Save(dataDir & Convert.ToString("Encrypt_out_.pdf"))
            ' ExEnd:EncryptFile 
        End Sub
    End Class
End Namespace
