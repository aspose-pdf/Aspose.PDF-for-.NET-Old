Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDF.Pages
    Public Class ZoomToPageContents
        Public Shared Sub Run()
            ' ExStart:ZoomToPageContents
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Load source PDF file
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
            ' Get rectangular region of first page of PDF
            Dim rect As Rectangle = doc.Pages(1).Rect
            ' Instantiate PdfPageEditor instance
            Dim ppe As New PdfPageEditor()
            ' Bind source PDF
            ppe.BindPdf(dataDir & Convert.ToString("input.pdf"))
            ' Set zoom coefficient
            ppe.Zoom = CSng(rect.Width / rect.Height)
            ' Update page size
            ppe.PageSize = New PageSize(CSng(rect.Height), CSng(rect.Width))

            dataDir = dataDir & Convert.ToString("ZoomToPageContents_out_.pdf")
            ' Save output file
            doc.Save(dataDir)
            ' ExEnd:ZoomToPageContents
            System.Console.WriteLine(Convert.ToString(vbLf & "Zoom to page contents applied successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
