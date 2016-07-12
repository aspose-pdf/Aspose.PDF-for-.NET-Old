Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Namespace AsposePDF.Text
    Public Class ExtractTextPage
        Public Shared Sub Run()
            ' ExStart:ExtractTextPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ExtractTextPage.pdf"))

            ' Create TextAbsorber object to extract text
            Dim textAbsorber As New TextAbsorber()

            ' Accept the absorber for a particular page
            pdfDocument.Pages(1).Accept(textAbsorber)

            ' Get the extracted text
            Dim extractedText As String = textAbsorber.Text

            dataDir = dataDir & Convert.ToString("extracted-text_out_.txt")
            ' Create a writer and open the file
            Dim tw As TextWriter = New StreamWriter(dataDir)

            ' Write a line of text to the file
            tw.WriteLine(extractedText)

            ' Close the stream
            tw.Close()
            ' ExEnd:ExtractTextPage            
            Console.WriteLine(Convert.ToString(vbLf & "Text extracted successfully from Pages of PDF Document." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace