Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Pages
    Public Class GetDimensions
        Public Shared Sub Run()
            ' ExStart:GetDimensions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("UpdateDimensions.pdf"))

            ' Adds a blank page to pdf document
            Dim page As Page = If(pdfDocument.Pages.Count > 0, pdfDocument.Pages(1), pdfDocument.Pages.Add())
            ' Get page height and width information
            Console.WriteLine(page.GetPageRect(True).Width.ToString() + ":" + page.GetPageRect(True).Height.ToString())
            ' Rotate page at 90 degree angle
            page.Rotate = Rotation.on90
            ' Get page height and width information
            Console.WriteLine(page.GetPageRect(True).Width.ToString() + ":" + page.GetPageRect(True).Height.ToString())
            ' ExEnd:GetDimensions          
        End Sub
    End Class
End Namespace
