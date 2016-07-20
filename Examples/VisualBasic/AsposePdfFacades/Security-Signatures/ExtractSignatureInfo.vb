Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Collections
Imports Aspose.Pdf.Forms

Namespace AsposePDFFacades.SecuritySignatures
    Public Class ExtractSignatureInfo
        Public Shared Sub Run()
            Try
                ' ExStart:ExtractSignatureInfo               
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()
                Dim input As String = dataDir & Convert.ToString("DigitallySign.pdf")
                Dim pkcs1File As String = ""
                Using pdfFileSignature As New PdfFileSignature()
                    pdfFileSignature.BindPdf(input)
                    Dim sigNames As IList = pdfFileSignature.GetSignNames()
                    If sigNames.Count > 0 Then
                        Dim sigName As String = TryCast(sigNames(0), String)
                        If String.IsNullOrEmpty(sigName) Then
                            Dim cerStream As Stream = pdfFileSignature.ExtractCertificate(sigName)
                            If cerStream IsNot Nothing Then
                                Using cerStream
                                    Dim bytes As Byte() = New Byte(Convert.ToInt32(cerStream.Length - 1)) {}
                                    Using fs As New FileStream(dataDir & pkcs1File, FileMode.CreateNew)
                                        cerStream.Read(bytes, 0, bytes.Length)
                                        fs.Write(bytes, 0, bytes.Length)
                                    End Using
                                End Using
                            End If
                        End If
                    End If
                    ' ExEnd:ExtractSignatureInfo
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
