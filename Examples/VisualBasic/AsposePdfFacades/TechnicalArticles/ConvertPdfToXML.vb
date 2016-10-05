Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class ConvertPdfToXML
        Public Shared Sub Run()
            ' ExStart:ConvertPdfToXML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create a file stream for FDF file - input file
            Dim fdfInputStream As System.IO.FileStream = New FileStream(dataDir & Convert.ToString("inFile.pdf"), FileMode.Open)
            ' Create a file stream for XML file - output file
            Dim xmlOutputStream As System.IO.FileStream = New FileStream(dataDir & Convert.ToString("ConvertPdfToXML_out_.xml"), FileMode.Create)
            ' Create a file stream for XML file - output file
            FormDataConverter.ConvertFdfToXml(fdfInputStream, xmlOutputStream)
            ' ExEnd:ConvertPdfToXML                      
        End Sub
    End Class
End Namespace
