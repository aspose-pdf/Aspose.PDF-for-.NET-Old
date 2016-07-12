Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDF.SecuritySignatures
    Public Class DetermineCorrectPassword
        Public Shared Sub Run()
            ' ExStart:DetermineCorrectPassword
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()
            ' Load source PDF file
            Dim info As New PdfFileInfo()
            info.BindPdf(dataDir & Convert.ToString("IsPasswordProtected.pdf"))
            ' Determine if the source PDF is encrypted
            Console.WriteLine("File is password protected " + info.IsEncrypted.ToString())
            Dim passwords As [String]() = New [String](4) {"test", "test1", "test2", "test3", "sample"}
            For passwordcount As Integer = 0 To passwords.Length - 1
                Try
                    Dim doc As New Document(dataDir & Convert.ToString("IsPasswordProtected.pdf"), passwords(passwordcount))
                    If doc.Pages.Count > 0 Then
                        Console.WriteLine("Number of Page in document are = " + doc.Pages.Count.ToString())
                    End If
                Catch generatedExceptionName As InvalidPasswordException
                    Console.WriteLine("Password = " + passwords(passwordcount) + "  is not correct")
                End Try
            Next
            ' ExEnd:DetermineCorrectPassword

        End Sub
    End Class
End Namespace
