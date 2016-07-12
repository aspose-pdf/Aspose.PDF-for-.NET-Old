Imports System.IO
Imports System
Imports Aspose.Pdf
Namespace AsposePDF.Pages
    Public Class GetNumberofPages
        Public Shared Sub Run()
            ' ExStart:GetNumberofPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetNumberofPages.pdf"))

            ' Get page count
            Console.WriteLine("Page Count : {0}", pdfDocument.Pages.Count)
            ' ExEnd:GetNumberofPages
        End Sub
    End Class
End Namespace

