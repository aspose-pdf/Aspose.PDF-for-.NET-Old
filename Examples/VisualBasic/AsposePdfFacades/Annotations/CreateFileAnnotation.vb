Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDFFacades.Annotations
    Public Class CreateFileAnnotation
        Public Shared Sub Run()
            ' ExStart:CreateFileAnnotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()

            ' Instantiate PdfContentEditor object
            Dim editor As New PdfContentEditor()
            ' Bind input PDF file
            editor.BindPdf(dataDir & Convert.ToString("CreateFileAnnotation.pdf"))
            ' The last argumnet is for transparency of icon
            editor.CreateFileAttachment(New System.Drawing.Rectangle(50, 50, 10, 10), "here", dataDir & Convert.ToString("AddFreeTextAnnotation.pdf"), 1, "Paperclip", 0.005)
            ' Save the updated PDF file
            editor.Save(dataDir & Convert.ToString("PdfWith_Transparent_Annotation_out_.pdf"))
            ' ExEnd:CreateFileAnnotation
        End Sub
    End Class
End Namespace
