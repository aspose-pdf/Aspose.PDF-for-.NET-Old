Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class ImportDataFromXFDF
        Public Shared Sub Run()
            ' ExStart:ImportDataFromXFDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim form As New Aspose.Pdf.Facades.Form()
            ' Open Document
            form.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Open xfdf file.
            Dim xfdfInputStream As System.IO.FileStream = New FileStream("student1.xfdf", FileMode.Open)

            ' Import data
            form.ImportXfdf(xfdfInputStream)

            ' Close file stream
            xfdfInputStream.Close()

            ' Save updated document
            form.Save(dataDir & Convert.ToString("ImportDataFromXFDF_out_.pdf"))
            ' ExEnd:ImportDataFromXFDF
        End Sub
    End Class
End Namespace
