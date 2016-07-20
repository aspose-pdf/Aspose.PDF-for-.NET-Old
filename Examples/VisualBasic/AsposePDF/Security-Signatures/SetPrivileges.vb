Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf

Namespace AsposePDF.SecuritySignatures
    Public Class SetPrivileges
        Public Shared Sub Run()
            ' ExStart:SetPrivileges
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()
            ' Load a source PDF file
            Using document As New Document(dataDir & Convert.ToString("input.pdf"))
                ' Instantiate Document Privileges object
                ' Apply restrictions on all privileges
                Dim documentPrivilege__1 As DocumentPrivilege = DocumentPrivilege.ForbidAll
                ' Only allow screen reading
                documentPrivilege__1.AllowScreenReaders = True
                ' Encrypt the file with User and Owner password.
                ' Need to set the password, so that once the user views the file with user password,
                ' Only screen reading option is enabled
                document.Encrypt("user", "owner", documentPrivilege__1, CryptoAlgorithm.AESx128, False)
                ' Save updated document
                document.Save(dataDir & Convert.ToString("SetPrivileges_out_.pdf"))
            End Using
            ' ExEnd:SetPrivileges   

        End Sub
    End Class
End Namespace