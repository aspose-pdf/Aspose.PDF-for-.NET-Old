Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.SecuritySignatures
    Public Class Encrypt
        Public Shared Sub Run()
            ' ExStart:Encrypt
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()
            ' Open document
            Dim document As New Document(dataDir & Convert.ToString("Encrypt.pdf"))
            ' Encrypt PDF
            document.Encrypt("user", "owner", 0, CryptoAlgorithm.RC4x128)
            dataDir = dataDir & Convert.ToString("Encrypt_out_.pdf")
            ' Save updated PDF
            document.Save(dataDir)
            ' ExEnd:Encrypt   
            Console.WriteLine(Convert.ToString(vbLf & "PDF file encrypted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace