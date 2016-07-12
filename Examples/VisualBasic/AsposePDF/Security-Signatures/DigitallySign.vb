Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Collections
Imports Aspose.Pdf.Forms
Namespace AsposePDF.SecuritySignatures
    Public Class DigitallySign
        Public Shared Sub Run()
            Try
                ' ExStart:DigitallySign
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()
                Dim pbxFile As String = ""
                Dim inFile As String = dataDir & Convert.ToString("DigitallySign.pdf")
                Dim outFile As String = dataDir & Convert.ToString("DigitallySign_out_.pdf")
                Using document As New Document(inFile)
                    Using signature As New PdfFileSignature(document)
                        Dim pkcs As New PKCS7(pbxFile, "WebSales")
                        ' Use PKCS7/PKCS7Detached objects
                        Dim docMdpSignature As New DocMDPSignature(pkcs, DocMDPAccessPermissions.FillingInForms)
                        Dim rect As New System.Drawing.Rectangle(100, 100, 200, 100)
                        ' Set signature appearance
                        signature.SignatureAppearance = dataDir & Convert.ToString("aspose-logo.jpg")
                        ' Create any of the three signature types
                        signature.Certify(1, "Signature Reason", "Contact", "Location", True, rect, _
                            docMdpSignature)
                        ' Save output PDF file
                        signature.Save(outFile)
                    End Using
                End Using

                Using document As New Document(outFile)
                    Using signature As New PdfFileSignature(document)
                        Dim sigNames As IList = signature.GetSignNames()
                        If sigNames.Count > 0 Then
                            ' Any signatures?
                            If signature.VerifySigned(TryCast(sigNames(0), String)) Then
                                ' Verify first one
                                If signature.IsCertified Then
                                    ' Certified?
                                    If signature.GetAccessPermissions() = DocMDPAccessPermissions.FillingInForms Then
                                        ' Do something
                                        ' Get access permission
                                    End If
                                End If
                            End If
                        End If
                    End Using
                    ' ExEnd:DigitallySign
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace