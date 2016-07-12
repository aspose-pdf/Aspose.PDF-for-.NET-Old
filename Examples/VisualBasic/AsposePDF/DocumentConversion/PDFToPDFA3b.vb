Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.DocumentConversion
    Public Class PDFToPDFA3b
        Public Shared Sub Run()
            ' ExStart:PDFToPDFA3b
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))

            pdfDocument.Convert(New MemoryStream(), PdfFormat.PDF_A_3B, ConvertErrorAction.Delete)

            dataDir = dataDir & Convert.ToString("PDFToPDFA3b_out_.pdf")
            ' Save output document
            pdfDocument.Save(dataDir)
            ' ExEnd:PDFToPDFA3b
            Console.WriteLine(Convert.ToString(vbLf & "PDF file converted to PDF/A-3B format." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace