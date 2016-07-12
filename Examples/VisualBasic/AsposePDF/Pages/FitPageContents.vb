
Imports System.IO
Imports Aspose.Pdf
Namespace AsposePDF.Pages
    Public Class FitPageContents
        Public Shared Sub Run()
            ' ExStart:FitPageContents
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            Dim doc As New Document(dataDir & "input.pdf")
            For Each page As Page In doc.Pages
                Dim r As Rectangle = page.MediaBox
                ' New height the same
                Dim newHeight As Double = r.Height
                ' New width is expanded proportionally to make orientation landscape
                ' (we assume that previous orientation is portrait)

                Dim newWidth As Double = r.Height * r.Height / r.Width
            Next
            ' ExEnd:FitPageContents
        End Sub
    End Class
End Namespace