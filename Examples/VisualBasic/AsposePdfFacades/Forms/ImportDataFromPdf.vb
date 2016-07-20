Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class ImportDataFromPdf
        Public Shared Sub Run()
            ' ExStart:ImportDataFromPdf
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim form As New Aspose.Pdf.Facades.Form()
            ' Open Document
            form.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Open fdf file.
            Dim fdfInputStream As System.IO.FileStream = New FileStream(dataDir & Convert.ToString("student.fdf"), FileMode.Open)

            ' Import data
            form.ImportFdf(fdfInputStream)

            ' Close file stream
            fdfInputStream.Close()

            ' Save updated document
            form.Save(dataDir & Convert.ToString("ImportDataFromPdf_out_.pdf"))
            ' ExEnd:ImportDataFromPdf
        End Sub
    End Class
End Namespace
