Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Text.TextOptions

Namespace AsposePDF.Text
    Public Class ReplaceTextonRegularExpression
        Public Shared Sub Run()
            ' ExStart:ReplaceTextonRegularExpression
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("SearchRegularExpressionPage.pdf"))

            ' Create TextAbsorber object to find all the phrases matching the regular expression
            Dim textFragmentAbsorber As New TextFragmentAbsorber("\d{4}-\d{4}")
            'like 1999-2000
            ' Set text search option to specify regular expression usage
            Dim textSearchOptions As New TextSearchOptions(True)
            textFragmentAbsorber.TextSearchOptions = textSearchOptions

            ' Accept the absorber for a single page
            pdfDocument.Pages(1).Accept(textFragmentAbsorber)

            ' Get the extracted text fragments
            Dim textFragmentCollection As TextFragmentCollection = textFragmentAbsorber.TextFragments

            ' Loop through the fragments
            For Each textFragment As TextFragment In textFragmentCollection
                ' Update text and other properties
                textFragment.Text = "New Phrase"
                ' Set to an instance of an object.
                textFragment.TextState.Font = FontRepository.FindFont("Verdana")
                textFragment.TextState.FontSize = 22
                textFragment.TextState.ForegroundColor = Color.FromRgb(System.Drawing.Color.Blue)
                textFragment.TextState.BackgroundColor = Color.FromRgb(System.Drawing.Color.Green)
            Next
            dataDir = dataDir & Convert.ToString("ReplaceTextonRegularExpression_out_.pdf")
            pdfDocument.Save(dataDir)
            ' ExEnd:ReplaceTextonRegularExpression
            Console.WriteLine(Convert.ToString(vbLf & "Text replaced successfully based on a regular expression." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace