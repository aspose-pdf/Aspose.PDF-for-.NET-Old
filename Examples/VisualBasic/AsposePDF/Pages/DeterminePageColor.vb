Imports System.IO
Imports System
Imports Aspose.Pdf
Namespace AsposePDF.Pages
    Public Class DeterminePageColor
        Public Shared Sub Run()
            ' ExStart:DeterminePageColor
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Open source PDF file
            Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))
            ' Iterate through all the page of PDF file
            For pageCount As Integer = 1 To pdfDocument.Pages.Count
                ' Get the color type information for particular PDF page
                Dim pageColorType As ColorType = pdfDocument.Pages(pageCount).ColorType
                Select Case pageColorType
                    Case ColorType.BlackAndWhite
                        Console.WriteLine("Page # -" + pageCount.ToString() + " is Black and white..")
                        Exit Select
                    Case ColorType.Grayscale
                        Console.WriteLine("Page # -" + pageCount.ToString() + " is Gray Scale...")
                        Exit Select
                    Case ColorType.Rgb
                        Console.WriteLine("Page # -" + pageCount.ToString() + " is RGB..", pageCount)
                        Exit Select
                    Case ColorType.Undefined
                        Console.WriteLine("Page # -" + pageCount.ToString() + " Color is undefined..")
                        Exit Select
                End Select
            Next
            ' ExEnd:DeterminePageColor
        End Sub
    End Class
End Namespace
