Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Namespace AsposePDF.Text
    Public Class SearchAndGetTextPage
        Public Shared Sub Run()
            ' ExStart:SearchAndGetTextPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("SearchAndGetTextPage.pdf"))

            ' Create TextAbsorber object to find all instances of the input search phrase
            Dim textFragmentAbsorber As New TextFragmentAbsorber("Figure")
            ' Accept the absorber for all the pages
            pdfDocument.Pages.Accept(textFragmentAbsorber)
            ' Get the extracted text fragments
            Dim textFragmentCollection As TextFragmentCollection = textFragmentAbsorber.TextFragments
            ' Loop through the fragments
            For Each textFragment As TextFragment In textFragmentCollection
                For Each textSegment As TextSegment In textFragment.Segments
                    Console.WriteLine("Text : {0} ", textSegment.Text)
                    Console.WriteLine("Position : {0} ", textSegment.Position)
                    Console.WriteLine("XIndent : {0} ", textSegment.Position.XIndent)
                    Console.WriteLine("YIndent : {0} ", textSegment.Position.YIndent)
                    Console.WriteLine("Font - Name : {0}", textSegment.TextState.Font.FontName)
                    Console.WriteLine("Font - IsAccessible : {0} ", textSegment.TextState.Font.IsAccessible)
                    Console.WriteLine("Font - IsEmbedded : {0} ", textSegment.TextState.Font.IsEmbedded)
                    Console.WriteLine("Font - IsSubset : {0} ", textSegment.TextState.Font.IsSubset)
                    Console.WriteLine("Font Size : {0} ", textSegment.TextState.FontSize)
                    Console.WriteLine("Foreground Color : {0} ", textSegment.TextState.ForegroundColor)
                Next
            Next
            ' ExEnd:SearchAndGetTextPage            
        End Sub
    End Class
End Namespace
