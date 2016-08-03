Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.Text
    Public Class ExtractTextAll
        Public Shared Sub Run()
            ' ExStart:ExtractTextAll
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ExtractTextAll.pdf"))

            ' Create TextAbsorber object to extract text
            Dim textAbsorber As New TextAbsorber()
            ' Accept the absorber for all the pages
            pdfDocument.Pages.Accept(textAbsorber)
            ' Get the extracted text
            Dim extractedText As String = textAbsorber.Text
            ' Create a writer and open the file
            Dim tw As TextWriter = New StreamWriter(dataDir & Convert.ToString("extracted-text.txt"))
            ' Write a line of text to the file
            tw.WriteLine(extractedText)
            ' Close the stream
            tw.Close()
            ' ExEnd:ExtractTextAll   

        End Sub
    End Class
End Namespace
