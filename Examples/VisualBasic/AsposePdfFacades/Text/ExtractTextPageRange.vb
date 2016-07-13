Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Text
Namespace AsposePDFFacades.Text
    Public Class ExtractTextPageRange
        Public Shared Sub Run()
            ' ExStart:ExtractTextPageRange
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Text()
            ' Open input PDF
            Dim pdfExtractor As New PdfExtractor()
            pdfExtractor.BindPdf(dataDir & Convert.ToString("ExtractText-PageRange.pdf"))

            ' Specify start and end pages
            pdfExtractor.StartPage = 1
            pdfExtractor.EndPage = 1

            ' Use parameterless ExtractText method
            pdfExtractor.ExtractText()

            Dim tempMemoryStream As New MemoryStream()
            pdfExtractor.GetText(tempMemoryStream)

            Dim text As String = ""
            ' Specify Unicode encoding type in StreamReader constructor
            Using sr As New StreamReader(tempMemoryStream, Encoding.Unicode)
                sr.BaseStream.Seek(0, SeekOrigin.Begin)
                text = sr.ReadToEnd()
            End Using

            File.WriteAllText(dataDir & Convert.ToString("output_out_.txt"), text)
            ' ExEnd:ExtractTextPageRange
        End Sub
    End Class
End Namespace
