Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Collections
Imports Aspose.Pdf.Forms

Namespace AsposePDFFacades.SecuritySignatures
    Public Class DigitallySignature
        Public Shared Sub Run()
            Try
                ' ExStart:DigitallySignature
                Dim pbxFile As String = ""
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()
                ' Create PdfFileSignature object and bind input and output PDF files
                Dim pdfSign As New PdfFileSignature()
                pdfSign.BindPdf(dataDir & Convert.ToString("DigitallySign.pdf"))
                ' Create a rectangle for signature location
                Dim rect As New System.Drawing.Rectangle(100, 100, 200, 100)
                ' Set signature appearance
                pdfSign.SignatureAppearance = dataDir & Convert.ToString("aspose-logo.jpg")
                ' Create any of the three signature types
                Dim signature As New PKCS1(pbxFile, "password")
                ' PKCS#1 or
                pdfSign.Sign(1, "Signature Reason", "Contact", "Location", True, rect, _
                    signature)
                ' Save output PDF file
                ' ExEnd:DigitallySignature
                pdfSign.Save(dataDir & Convert.ToString("DigitallySignature_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
