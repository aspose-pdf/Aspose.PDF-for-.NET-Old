Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.SecuritySignatures
    Public Class ChangePassword
        Public Shared Sub Run()
            ' ExStart:ChangePassword
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()

            ' Open document
            Dim document As New Document(dataDir & Convert.ToString("ChangePassword.pdf"), "owner")
            ' Change password
            document.ChangePasswords("owner", "newuser", "newowner")
            dataDir = dataDir & Convert.ToString("ChangePassword_out_.pdf")
            ' Save updated PDF
            document.Save(dataDir)
            ' ExEnd:ChangePassword  
            Console.WriteLine(Convert.ToString(vbLf & "PDF file password changed successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace