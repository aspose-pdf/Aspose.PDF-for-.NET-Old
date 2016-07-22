Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.ManipulatePageProperties
    Public Class ResizePageContents
        Public Shared Sub Run()
            ' ExStart:ResizePageContents
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor Object
            Dim fileEditor As New PdfFileEditor()

            ' Open PDF Document
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

            ' Specify Parameter to be used for resizing
            ' Left margin = 10% of page width
            ' New contents width calculated automatically as width - left margin - right margin (100% - 10% - 10% = 80%)
            ' Right margin is 10% of page
            ' Top margin = 10% of height
            ' New contents height is calculated automatically (similar to width)
            ' Bottom margin is 10%
            Dim parameters As New PdfFileEditor.ContentsResizeParameters(PdfFileEditor.ContentsResizeValue.Percents(10), Nothing, PdfFileEditor.ContentsResizeValue.Percents(10), PdfFileEditor.ContentsResizeValue.Percents(10), Nothing, PdfFileEditor.ContentsResizeValue.Percents(10))

            ' Resize Page Contents
            fileEditor.ResizeContents(doc, New Integer() {1, 2}, parameters)

            ' Save document into new location.
            doc.Save(dataDir & Convert.ToString("ResizePageContents_out_.pdf"))
            ' ExEnd:ResizePageContents
        End Sub
    End Class
End Namespace
