Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.Text
    Public Class ReplaceTextPage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ReplaceTextPage.pdf"))

            ' Create TextAbsorber object to find all instances of the input search phrase
            Dim textFragmentAbsorber As New TextFragmentAbsorber("text")

            ' ExStart: SearchInsideText
            ' Accept the absorber for a particular page
            pdfDocument.Pages(2).Accept(textFragmentAbsorber)
            ' ExEnd: SearchInsideText

            ' Get the extracted text fragments
            Dim textFragmentCollection As TextFragmentCollection = textFragmentAbsorber.TextFragments

            ' Loop through the fragments
            For Each textFragment As TextFragment In textFragmentCollection
                ' Update text and other properties
                textFragment.Text = "New Phrase"
                textFragment.TextState.Font = FontRepository.FindFont("Verdana")
                textFragment.TextState.FontSize = 22
                textFragment.TextState.ForegroundColor = Color.FromRgb(System.Drawing.Color.Blue)
                textFragment.TextState.BackgroundColor = Color.FromRgb(System.Drawing.Color.Green)
            Next

            pdfDocument.Save(dataDir & Convert.ToString("ReplaceTextPage_out.pdf"))
        End Sub
    End Class
End Namespace
