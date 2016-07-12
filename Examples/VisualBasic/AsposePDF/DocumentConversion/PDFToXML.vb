Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.DocumentConversion
    Public Class PDFToXML
        Public Shared Sub Run()
            ' ExStart:PDFToXML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()
            ' Load source PDF file
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
            ' Save output in XML format
            doc.Save(dataDir & Convert.ToString("PDFToXML_out_.xml"), SaveFormat.MobiXml)
            ' ExEnd:PDFToXML
        End Sub
    End Class
End Namespace
