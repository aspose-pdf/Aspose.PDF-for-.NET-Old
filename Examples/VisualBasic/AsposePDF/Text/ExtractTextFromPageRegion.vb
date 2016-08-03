Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.Text
    Public Class ExtractTextFromPageRegion
        Public Shared Sub Run()
            ' ExStart:ExtractTextFromPageRegion
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ExtractTextAll.pdf"))

            ' Create TextAbsorber object to extract text
            Dim absorber As New TextAbsorber()
            absorber.TextSearchOptions.LimitToPageBounds = True
            absorber.TextSearchOptions.Rectangle = New Aspose.Pdf.Rectangle(100, 200, 250, 350)

            ' Accept the absorber for first page
            pdfDocument.Pages(1).Accept(absorber)

            ' Get the extracted text
            Dim extractedText As String = absorber.Text
            ' Create a writer and open the file
            Dim tw As TextWriter = New StreamWriter(dataDir & Convert.ToString("extracted-text.txt"))
            ' Write a line of text to the file
            tw.WriteLine(extractedText)
            ' Close the stream
            tw.Close()
            ' ExEnd:ExtractTextFromPageRegion          

        End Sub
    End Class
End Namespace
