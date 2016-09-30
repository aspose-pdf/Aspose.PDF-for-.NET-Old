Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class PdfContainsTextOrImages
        Public Shared Sub Run()
            ' ExStart:PdfContainsTextOrImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Instantiate a memoryStream object to hold the extracted text from Document
            Dim ms As New MemoryStream()
            ' Instantiate PdfExtractor object
            Dim extractor As New PdfExtractor()

            ' Bind the input PDF document to extractor
            extractor.BindPdf(dataDir & Convert.ToString("FilledForm.pdf"))
            ' Extract text from the input PDF document
            extractor.ExtractText()

            Dim containsText As Boolean = False
            Dim containsImage As Boolean = False
            ' Save the extracted text to a text file
            extractor.GetText(ms)
            ' Check if the MemoryStream length is greater than or equal to 1
            If ms.Length >= 1 Then
                containsText = True
            End If

            ' Extract images from the input PDF document
            extractor.ExtractImage()

            ' Calling HasNextImage method in while loop. When images will finish, loop will exit
            If extractor.HasNextImage() Then
                containsImage = True
            End If

            ' Now find out whether this PDF is text only or image only
            If containsText = True AndAlso containsImage = False Then
                Console.WriteLine("PDF contains text only")
            ElseIf containsText = False AndAlso containsImage = True Then
                Console.WriteLine("PDF contains image only")
            ElseIf containsText = True AndAlso containsImage = True Then
                Console.WriteLine("PDF contains both text and image")
            ElseIf containsText = False AndAlso containsImage = False Then
                Console.WriteLine("PDF contains neither text or nor image")
            End If
            ' ExEnd:PdfContainsTextOrImages                      
        End Sub
    End Class
End Namespace
