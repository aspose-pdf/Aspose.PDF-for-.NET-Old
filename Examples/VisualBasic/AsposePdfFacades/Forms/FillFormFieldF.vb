Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class FillFormFieldF
        Public Shared Sub Run()
            ' ExStart:FillFormFieldF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            ' Create Form Object
            Dim pdfForm As New Aspose.Pdf.Facades.Form()

            ' Open Document
            pdfForm.BindPdf(dataDir & Convert.ToString("FormField.pdf"))

            ' Fill the field "textfield" with "Mike".
            pdfForm.FillField("textfield", "Mike")

            ' Save updated file
            pdfForm.Save(dataDir & Convert.ToString("FillFormFieldF_out_.pdf"))
            ' ExEnd:FillFormFieldF
        End Sub
    End Class
End Namespace
