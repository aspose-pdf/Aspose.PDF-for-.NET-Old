Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.SecuritySignatures
    Public Class Decrypt
        Public Shared Sub Run()
            ' ExStart:Decrypt
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()
            ' Open document
            Dim document As New Document(dataDir & Convert.ToString("Decrypt.pdf"), "password")
            ' Decrypt PDF
            document.Decrypt()
            dataDir = dataDir & Convert.ToString("Decrypt_out_.pdf")
            ' Save updated PDF
            document.Save(dataDir)
            ' ExEnd:Decrypt
            Console.WriteLine(Convert.ToString(vbLf & "PDF file decrypted successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
