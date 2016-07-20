Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class ExportDataToPdf
        Public Shared Sub Run()
            ' ExStart:ExportDataToPdf
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim form As New Aspose.Pdf.Facades.Form()
            ' Open Document
            form.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Create fdf file.
            Dim fdfOutputStream As System.IO.FileStream = New FileStream(dataDir & Convert.ToString("student.fdf"), FileMode.Create)

            ' Export data
            form.ExportFdf(fdfOutputStream)

            ' Close file stream
            fdfOutputStream.Close()

            ' Save updated document
            form.Save(dataDir & Convert.ToString("ExportDataToPdf_out_.pdf"))
            ' ExEnd:ExportDataToPdf
        End Sub
    End Class
End Namespace
