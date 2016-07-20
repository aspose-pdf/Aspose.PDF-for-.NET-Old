Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.Text
    Public Class ExtractColumnsText
        Public Shared Sub Run()
            ' ExStart:ExtractColumnsText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ExtractTextPage.pdf"))

            Dim tfa As New TextFragmentAbsorber()
            pdfDocument.Pages.Accept(tfa)
            Dim tfc As TextFragmentCollection = tfa.TextFragments
            For Each tf As TextFragment In tfc
                ' Need to reduce font size at least for 70%
                tf.TextState.FontSize = tf.TextState.FontSize * 0.7F
            Next
            Dim st As Stream = New MemoryStream()
            pdfDocument.Save(st)
            pdfDocument = New Document(st)
            Dim textAbsorber As New TextAbsorber()
            pdfDocument.Pages.Accept(textAbsorber)
            Dim extractedText As [String] = textAbsorber.Text
            textAbsorber.Visit(pdfDocument)

            dataDir = dataDir & Convert.ToString("ExtractColumnsText_out_.txt")

            System.IO.File.WriteAllText(dataDir, extractedText)
            ' ExEnd:ExtractColumnsText            
            Console.WriteLine(Convert.ToString(vbLf & "Columns text extracted successfully from Pages of PDF Document." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
