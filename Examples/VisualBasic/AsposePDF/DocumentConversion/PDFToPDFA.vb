Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.DocumentConversion
    Public Class PDFToPDFA
        Public Shared Sub Run()
            ' ExStart:PDFToPDFA
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PDFToPDFA.pdf"))

            ' Convert to PDF/A compliant document
            ' During conversion process, the validation is also performed
            pdfDocument.Convert(dataDir & Convert.ToString("log.xml"), PdfFormat.PDF_A_1B, ConvertErrorAction.Delete)

            dataDir = dataDir & Convert.ToString("PDFToPDFA_out_.pdf")
            ' Save output document
            pdfDocument.Save(dataDir)
            ' ExEnd:PDFToPDFA
            Console.WriteLine(Convert.ToString(vbLf & "PDF file converted to PDF/A-1b compliant PDF." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace