Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class GetFieldValue
        Public Shared Sub Run()
            ' ExStart:GetFieldValue
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim pdfForm As New Aspose.Pdf.Facades.Form()
            ' Open Document
            pdfForm.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Get field value
            Console.WriteLine("Field Value : {0} ", pdfForm.GetField("textfield"))
            ' ExEnd:GetFieldValue
        End Sub
    End Class
End Namespace
