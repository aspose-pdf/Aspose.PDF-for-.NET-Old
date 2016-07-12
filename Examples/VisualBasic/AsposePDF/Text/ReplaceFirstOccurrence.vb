Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.Text
    Public Class ReplaceFirstOccurrence
        Public Shared Sub Run()
            ' ExStart:ReplaceFirstOccurrence 
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ReplaceTextPage.pdf"))

            ' Create TextAbsorber object to find all instances of the input search phrase
            Dim textFragmentAbsorber As New TextFragmentAbsorber("text")
            ' Accept the absorber for all the pages
            pdfDocument.Pages.Accept(textFragmentAbsorber)
            ' Get the extracted text fragments
            Dim textFragmentCollection As TextFragmentCollection = textFragmentAbsorber.TextFragments
            If textFragmentCollection.Count > 0 Then
                ' Get first occurance of text and replace
                Dim textFragment As TextFragment = textFragmentCollection(1)
                ' Update text and other properties
                textFragment.Text = "New Phrase"
                textFragment.TextState.Font = FontRepository.FindFont("Verdana")
                textFragment.TextState.FontSize = 22
                textFragment.TextState.ForegroundColor = Color.FromRgb(System.Drawing.Color.Blue)

                dataDir = dataDir & Convert.ToString("ReplaceFirstOccurrence_out_.pdf")
                pdfDocument.Save(dataDir)

                Console.WriteLine(Convert.ToString(vbLf & "Text replaced successfully." & vbLf & "File saved at ") & dataDir)
            End If
            ' ExEnd:ReplaceFirstOccurrence 
        End Sub
    End Class
End Namespace