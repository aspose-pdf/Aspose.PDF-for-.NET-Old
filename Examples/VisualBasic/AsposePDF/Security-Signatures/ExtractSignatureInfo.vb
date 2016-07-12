Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf
Namespace AsposePDF.SecuritySignatures
    Public Class ExtractSignatureInfo
        Public Shared Sub Run()
            Try
                ' ExStart:ExtractSignatureInfo
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()

                Dim input As String = dataDir & Convert.ToString("ExtractSignatureInfo.pdf")
                Using pdfDocument As New Document(input)
                    For Each field As Field In pdfDocument.Form
                        Dim sf As SignatureField = TryCast(field, SignatureField)
                        If sf IsNot Nothing Then
                            Dim cerStream As Stream = sf.ExtractCertificate()
                            If cerStream IsNot Nothing Then
                                Using cerStream
                                    Dim bytes As Byte() = New Byte(cerStream.Length - 1) {}
                                    Using fs As New FileStream(dataDir & Convert.ToString("input.cer"), FileMode.CreateNew)
                                        cerStream.Read(bytes, 0, bytes.Length)
                                        fs.Write(bytes, 0, bytes.Length)
                                    End Using
                                End Using
                            End If
                        End If
                    Next
                    ' ExEnd:ExtractSignatureInfo
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
