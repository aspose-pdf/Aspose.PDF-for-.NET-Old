Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Pages
    Public Class InsertEmptyPageAtEnd
        Public Shared Sub Run()
            ' ExStart:InsertEmptyPageAtEnd
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Open document
            Dim pdfDocument1 As New Document(dataDir & Convert.ToString("InsertEmptyPageAtEnd.pdf"))

            ' Insert an empty page at the end of a PDF file
            pdfDocument1.Pages.Add()

            dataDir = dataDir & Convert.ToString("InsertEmptyPageAtEnd_out_.pdf")
            ' Save output file
            pdfDocument1.Save(dataDir)
            ' ExEnd:InsertEmptyPageAtEnd
            System.Console.WriteLine(Convert.ToString(vbLf & "Empty page inserted successfully at the end of document." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
