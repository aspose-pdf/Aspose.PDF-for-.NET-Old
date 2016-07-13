Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Text
Namespace AsposePDFFacades.Text
    Public Class ExtractTextPage
        Public Shared Sub Run()
            ' ExStart:ExtractTextPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Text()
            ' Open input PDF
            Dim pdfExtractor As New PdfExtractor()
            pdfExtractor.BindPdf(dataDir & Convert.ToString("ExtractText-Page.pdf"))

            ' Use parameterless ExtractText method
            pdfExtractor.ExtractText()

            Dim pageNumber As Integer = 1

            While pdfExtractor.HasNextPageText()
                Dim tempMemoryStream As New MemoryStream()
                pdfExtractor.GetNextPageText(tempMemoryStream)
                Dim text As String = ""
                ' Specify Unicode encoding type in StreamReader constructor
                Using streamReader As New StreamReader(tempMemoryStream, Encoding.Unicode)
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin)
                    text = streamReader.ReadToEnd()
                End Using
                File.WriteAllText((dataDir & Convert.ToString("output")) + pageNumber.ToString() + "_out_.txt", text)
                pageNumber += 1
            End While
            ' ExEnd:ExtractTextPage
        End Sub
    End Class
End Namespace