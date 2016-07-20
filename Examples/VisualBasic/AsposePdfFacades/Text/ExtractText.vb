Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Text

Namespace AsposePDFFacades.Text
    Public Class ExtractText
        Public Shared Sub Run()
            ' ExStart:ExtractText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Text()
            ' Open input PDF
            Dim pdfExtractor As New PdfExtractor()
            pdfExtractor.BindPdf(dataDir & Convert.ToString("ExtractText.pdf"))

            ' Use parameterless ExtractText method
            pdfExtractor.ExtractText()

            Dim tempMemoryStream As New MemoryStream()
            pdfExtractor.GetText(tempMemoryStream)

            Dim text As String = ""
            ' Specify Unicode encoding type in StreamReader constructor
            Using streamReader As New StreamReader(tempMemoryStream, Encoding.Unicode)
                streamReader.BaseStream.Seek(0, SeekOrigin.Begin)
                text = streamReader.ReadToEnd()
            End Using

            File.WriteAllText(dataDir & Convert.ToString("output_out_.txt"), text)
            ' ExEnd:ExtractText
        End Sub
    End Class
End Namespace