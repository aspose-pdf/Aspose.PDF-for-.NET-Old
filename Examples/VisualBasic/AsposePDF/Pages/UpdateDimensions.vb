Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Pages
    Public Class UpdateDimensions
        Public Shared Sub Run()
            ' ExStart:UpdateDimensions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("UpdateDimensions.pdf"))

            ' Get page collection
            Dim pageCollection As PageCollection = pdfDocument.Pages

            ' Get particular page
            Dim pdfPage As Page = pageCollection(1)

            ' Set the page size as A4 (11.7 x 8.3 in) and in Aspose.Pdf, 1 inch = 72 points
            ' So A4 dimensions in points will be (842.4, 597.6)
            pdfPage.SetPageSize(597.6, 842.4)

            dataDir = dataDir & Convert.ToString("UpdateDimensions_out_.pdf")
            ' Save the updated document
            pdfDocument.Save(dataDir)
            ' ExEnd:UpdateDimensions
            System.Console.WriteLine(Convert.ToString(vbLf & "Page dimensions updated successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
