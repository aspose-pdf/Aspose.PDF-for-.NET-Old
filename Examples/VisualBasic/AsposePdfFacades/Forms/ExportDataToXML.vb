Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class ExportDataToXML
        Public Shared Sub Run()
            ' ExStart:ExportDataToXML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            ' Open document
            Dim form As New Aspose.Pdf.Facades.Form()

            form.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Create xml file.
            Dim xmlOutputStream As System.IO.FileStream = New FileStream(dataDir & Convert.ToString("input.xml"), FileMode.Create)

            ' Export data
            form.ExportXml(xmlOutputStream)

            ' Close file stream
            xmlOutputStream.Close()

            ' Close the document
            form.Dispose()
            ' ExEnd:ExportDataToXML
        End Sub
    End Class
End Namespace
