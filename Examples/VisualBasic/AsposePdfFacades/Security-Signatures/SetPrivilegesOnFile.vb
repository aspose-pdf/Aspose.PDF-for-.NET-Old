Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.SecuritySignatures
    Public Class SetPrivilegesOnFile
        Public Shared Sub Run()
            ' ExStart:SetPrivilegesOnFile
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()

            ' Create DocumentPrivileges object
            Dim privilege As DocumentPrivilege = DocumentPrivilege.ForbidAll
            privilege.ChangeAllowLevel = 1
            privilege.AllowPrint = True
            privilege.AllowCopy = True

            ' Create PdfFileSecurity object 
            Dim fileSecurity As New PdfFileSecurity()
            fileSecurity.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Set document privileges
            fileSecurity.SetPrivilege(privilege)
            fileSecurity.Save(dataDir & Convert.ToString("SetPrivilegesOnFile_out_.pdf"))
            ' ExEnd:SetPrivilegesOnFile   

        End Sub
    End Class
End Namespace
