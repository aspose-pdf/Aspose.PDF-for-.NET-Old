Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Text.TextOptions
Imports Aspose.Pdf.Facades

Namespace AsposePDF.Text
    Public Class TextAndImageAsParagraph
        Public Shared Sub Run()
            ' ExStart:TextAndImageAsParagraph
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()
            ' Instantiate Document instance
            Dim doc As New Document()
            ' Add page to pages collection of Document instance
            Dim page As Page = doc.Pages.Add()
            ' Create TextFragmnet
            Dim text As New TextFragment("Hello World.. ")
            ' Add text fragment to paragraphs collection of Page object
            page.Paragraphs.Add(text)
            ' Create an image instance
            Dim image As New Image()
            ' Set image as inline paragraph so that it appears right after 
            ' The previous paragraph object (TextFragment)
            image.IsInLineParagraph = True
            ' Specify image file path 
            image.File = dataDir & Convert.ToString("aspose-logo.jpg")
            ' Set image Height (optional)
            image.FixHeight = 30
            ' Set Image Width (optional)
            image.FixWidth = 100
            ' Add image to paragraphs collection of page object
            page.Paragraphs.Add(image)
            ' Re-initialize TextFragment object with different contents
            text = New TextFragment(" Hello Again..")
            ' Set TextFragment as inline paragraph
            text.IsInLineParagraph = True
            ' Add newly created TextFragment to paragraphs collection of page
            page.Paragraphs.Add(text)

            dataDir = dataDir & Convert.ToString("TextAndImageAsParagraph_out_.pdf")
            doc.Save(dataDir)
            ' ExEnd:TextAndImageAsParagraph
            Console.WriteLine(Convert.ToString(vbLf & "Text and image added successfully as an inline paragraphs." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace