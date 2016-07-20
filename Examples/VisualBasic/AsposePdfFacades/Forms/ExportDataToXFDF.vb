Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class ExportDataToXFDF
        Public Shared Sub Run()
            ' ExStart:ExportDataToXFDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim form As New Aspose.Pdf.Facades.Form()
            ' Open Document
            form.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Create xfdf file.
            Dim xfdfOutputStream As System.IO.FileStream = New FileStream("student1.xfdf", FileMode.Create)

            ' Export data
            form.ExportXfdf(xfdfOutputStream)

            ' Close file stream
            xfdfOutputStream.Close()

            ' Save updated document
            form.Save(dataDir & Convert.ToString("ExportDataToXFDF_out_.pdf"))
            ' ExEnd:ExportDataToXFDF
        End Sub
    End Class
End Namespace

