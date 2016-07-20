Imports Aspose.Pdf
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Text.TextOptions

Namespace AsposePDF.Text
    Public Class SearchRegularExpression
        Public Shared Sub Run()
            ' ExStart:SearchRegularExpression
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("SearchRegularExpressionAll.pdf"))

            ' Create TextAbsorber object to find all the phrases matching the regular expression
            Dim textFragmentAbsorber As New TextFragmentAbsorber("\d{4}-\d{4}")
            'like 1999-2000
            ' Set text search option to specify regular expression usage
            Dim textSearchOptions As New TextSearchOptions(True)

            textFragmentAbsorber.TextSearchOptions = textSearchOptions

            ' Accept the absorber for all the pages
            pdfDocument.Pages.Accept(textFragmentAbsorber)

            ' Get the extracted text fragments
            Dim textFragmentCollection As TextFragmentCollection = textFragmentAbsorber.TextFragments

            ' Loop through the fragments
            For Each textFragment As TextFragment In textFragmentCollection
                Console.WriteLine("Text : {0} ", textFragment.Text)
                Console.WriteLine("Position : {0} ", textFragment.Position)
                Console.WriteLine("XIndent : {0} ", textFragment.Position.XIndent)
                Console.WriteLine("YIndent : {0} ", textFragment.Position.YIndent)
                Console.WriteLine("Font - Name : {0}", textFragment.TextState.Font.FontName)
                Console.WriteLine("Font - IsAccessible : {0} ", textFragment.TextState.Font.IsAccessible)
                Console.WriteLine("Font - IsEmbedded : {0} ", textFragment.TextState.Font.IsEmbedded)
                Console.WriteLine("Font - IsSubset : {0} ", textFragment.TextState.Font.IsSubset)
                Console.WriteLine("Font Size : {0} ", textFragment.TextState.FontSize)
                Console.WriteLine("Foreground Color : {0} ", textFragment.TextState.ForegroundColor)
            Next
            ' ExEnd:SearchRegularExpression
        End Sub
    End Class
End Namespace
