Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf.Text

Namespace AsposePDF.WorkingDocuments
    Public Class EmbedFontWhileDocCreation
        Public Shared Sub Run()
            ' ExStart:EmbedFontWhileDocCreation 
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Instantiate Pdf object by calling its empty constructor
            Dim doc As New Document()

            ' Create a section in the Pdf object
            Dim page As Page = doc.Pages.Add()

            Dim fragment As New TextFragment("")

            Dim segment As New TextSegment(" This is a sample text using Custom font.")
            Dim ts As New TextState()
            ts.Font = FontRepository.FindFont("Arial")
            ts.Font.IsEmbedded = True
            segment.TextState = ts
            fragment.Segments.Add(segment)
            page.Paragraphs.Add(fragment)

            dataDir = dataDir & Convert.ToString("EmbedFontWhileDocCreation_out_.pdf")
            ' Save PDF Document
            doc.Save(dataDir)
            ' ExEnd:EmbedFontWhileDocCreation 
            Console.WriteLine(Convert.ToString(vbLf & "Font embedded successfully in a PDF file." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
