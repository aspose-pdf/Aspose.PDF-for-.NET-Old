Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Collections
Imports Aspose.Pdf.Forms

Namespace AsposePDFFacades.SecuritySignatures
    Public Class VerifySignature
        Public Shared Sub Run()
            Try
                ' ExStart:VerifySignature               
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()
                Dim pdfSign As New PdfFileSignature()
                pdfSign.BindPdf(dataDir & Convert.ToString("DigitallySign.pdf"))
                If pdfSign.VerifySigned("Signature1") Then
                    Console.WriteLine("PDF Signed")
                    ' ExEnd:VerifySignature
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        Public Shared Sub VerifyPDFSigned()
            ' ExStart:VerifyPDFSigned               
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()

            Dim pdfSign As New PdfFileSignature()
            pdfSign.BindPdf(dataDir & Convert.ToString("DigitallySign.pdf"))
            pdfSign.ContainsSignature()
            ' Any signatures?
            pdfSign.Close()
            ' ExEnd:VerifyPDFSigned  
        End Sub
    End Class
End Namespace
