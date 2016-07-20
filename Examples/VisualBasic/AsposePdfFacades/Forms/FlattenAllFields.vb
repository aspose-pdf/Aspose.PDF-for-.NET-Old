Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class FlattenAllFields
        Public Shared Sub Run()
            ' ExStart:FlattenAllFields
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim pdfForm As New Aspose.Pdf.Facades.Form()
            ' Open Document
            pdfForm.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Flatten fields
            pdfForm.FlattenAllFields()

            ' Save output
            pdfForm.Save(dataDir & Convert.ToString("FlattenAllFields_out_.pdf"))
            ' ExEnd:FlattenAllFields
        End Sub
    End Class
End Namespace
