Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Drawing

Namespace AsposePDFFacades.Annotations
    Public Class AddFreeTextAnnotation
        Public Shared Sub Run()
            ' ExStart:AddFreeTextAnnotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()
            ' Open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & Convert.ToString("AddFreeTextAnnotation.pdf"))
            ' Create rectangle
            Dim rect As New System.Drawing.Rectangle(50, 50, 100, 100)
            ' Create annotation
            contentEditor.CreateFreeText(rect, "Sample content", 1)
            ' Save updated PDF file
            contentEditor.Save(dataDir & Convert.ToString("AddFreeTextAnnotation_out_.pdf"))
            ' ExEnd:AddFreeTextAnnotation            
        End Sub
    End Class
End Namespace
