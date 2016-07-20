Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class ImportDataFromXML
        Public Shared Sub Run()
            ' ExStart:ImportDataFromXML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            ' Open document
            Dim form As New Aspose.Pdf.Facades.Form()

            ' Open xml file.
            Dim xmlInputStream As System.IO.FileStream = New FileStream(dataDir & Convert.ToString("input.xml"), FileMode.Open)

            ' Import data
            form.ImportXml(xmlInputStream)

            ' Close file stream
            xmlInputStream.Close()

            ' Save updated document
            form.Save(dataDir & Convert.ToString("ImportDataFromXML_out_.pdf"))
            ' ExEnd:ImportDataFromXML
        End Sub
    End Class
End Namespace
