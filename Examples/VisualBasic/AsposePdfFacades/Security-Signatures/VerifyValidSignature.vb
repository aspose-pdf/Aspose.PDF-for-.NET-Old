Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Collections
Imports Aspose.Pdf.Forms

Namespace AsposePDFFacades.SecuritySignatures
    Public Class VerifyValidSignature
        Public Shared Sub Run()
            Try
                ' ExStart:VerifyValidSignature               
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()
                Dim pdfSign As New PdfFileSignature()
                pdfSign.BindPdf(dataDir & Convert.ToString("DigitallySign.pdf"))
                If pdfSign.VerifySignature("Signature1") Then
                    Console.WriteLine("Signature Verified")
                    ' ExEnd:VerifyValidSignature
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace

