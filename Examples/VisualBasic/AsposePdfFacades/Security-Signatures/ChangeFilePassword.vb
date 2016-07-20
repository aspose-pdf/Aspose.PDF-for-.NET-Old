Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.SecuritySignatures
    Public Class ChangeFilePassword
        Public Shared Sub Run()
            ' ExStart:ChangeFilePassword
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()
            ' Create PdfFileSecurity object 
            Dim fileSecurity As New PdfFileSecurity()
            fileSecurity.BindPdf(dataDir & Convert.ToString("ChangePassword.pdf"))

            ' Change password
            fileSecurity.ChangePassword("owner", "newuserpassword", "newownerpassword")
            fileSecurity.Save(dataDir & Convert.ToString("ChangeFilePassword_out_.pdf"))
            ' ExEnd:ChangeFilePassword   
        End Sub
    End Class
End Namespace

