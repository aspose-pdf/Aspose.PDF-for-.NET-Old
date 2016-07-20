Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.WorkingDocuments
    Public Class ValidatePDFAStandard
        Public Shared Sub Run()
            ' ExStart:ValidatePDFAStandard
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ValidatePDFAStandard.pdf"))

            ' Validate PDF for PDF/A-1a
            pdfDocument.Validate(dataDir & Convert.ToString("validation-result-A1A.xml"), PdfFormat.PDF_A_1A)
            ' ExEnd:ValidatePDFAStandard
        End Sub
    End Class
End Namespace
