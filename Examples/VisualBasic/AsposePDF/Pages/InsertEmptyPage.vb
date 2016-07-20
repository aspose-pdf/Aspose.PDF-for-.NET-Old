Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Pages
    Public Class InsertEmptyPage
        Public Shared Sub Run()
            ' ExStart:InsertEmptyPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Open document
            Dim pdfDocument1 As New Document(dataDir & Convert.ToString("InsertEmptyPage.pdf"))

            ' Insert a empty page in a PDF
            pdfDocument1.Pages.Insert(2)
            dataDir = dataDir & Convert.ToString("InsertEmptyPage_out_.pdf")
            ' Save output file
            pdfDocument1.Save(dataDir)
            ' ExEnd:InsertEmptyPage
            System.Console.WriteLine(Convert.ToString(vbLf & "Empty page inserted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
