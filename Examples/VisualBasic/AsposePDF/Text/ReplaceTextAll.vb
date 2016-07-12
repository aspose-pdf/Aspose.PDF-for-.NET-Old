Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.Text
    Public Class ReplaceTextAll
        Public Shared Sub Run()
            ' ExStart:ReplaceTextAll
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ReplaceTextAll.pdf"))

            ' Create TextAbsorber object to find all instances of the input search phrase
            Dim textFragmentAbsorber As New TextFragmentAbsorber("text")

            ' Accept the absorber for all the pages
            pdfDocument.Pages.Accept(textFragmentAbsorber)

            ' Get the extracted text fragments
            Dim textFragmentCollection As TextFragmentCollection = textFragmentAbsorber.TextFragments

            ' Loop through the fragments
            For Each textFragment As TextFragment In textFragmentCollection
                ' Update text and other properties
                textFragment.Text = "TEXT"
                textFragment.TextState.Font = FontRepository.FindFont("Verdana")
                textFragment.TextState.FontSize = 22
                textFragment.TextState.ForegroundColor = Color.FromRgb(System.Drawing.Color.Blue)
                textFragment.TextState.BackgroundColor = Color.FromRgb(System.Drawing.Color.Green)
            Next

            dataDir = dataDir & Convert.ToString("ReplaceTextAll_out_.pdf")
            ' Save resulting PDF document.
            pdfDocument.Save(dataDir)
            ' ExEnd:ReplaceTextAll
            Console.WriteLine(Convert.ToString(vbLf & "Text replaced  successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace