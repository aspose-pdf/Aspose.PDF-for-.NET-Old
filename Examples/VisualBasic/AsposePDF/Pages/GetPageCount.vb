
Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Namespace AsposePDF.Pages
    Public Class GetPageCount
        Public Shared Sub Run()
            ' ExStart:GetPageCount
            ' Instantiate Document instance
            Dim doc As New Document()
            ' Add page to pages collection of PDF file
            Dim page As Page = doc.Pages.Add()
            ' Create loop instance
            For i As Integer = 0 To 299
                ' Add TextFragment to paragraphs collection of page object
                page.Paragraphs.Add(New TextFragment("Pages count test"))
            Next
            ' Process the paragraphs in PDF file to get accurate page count
            doc.ProcessParagraphs()
            ' Print number of pages in document
            Console.WriteLine("Number of pages in document = " + doc.Pages.Count.ToString())
            ' ExEnd:GetPageCount
        End Sub
    End Class
End Namespace