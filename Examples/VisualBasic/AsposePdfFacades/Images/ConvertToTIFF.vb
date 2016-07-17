Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Devices

Namespace AsposePDFFacades.Images
    Public Class ConvertToTIFF
        Public Shared Sub Run()
            ' ExStart:ConvertToTIFF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            ' Create PdfConverter object and bind input PDF file
            Dim pdfConverter As New PdfConverter()
            ' Bind the source PDF file
            pdfConverter.BindPdf(dataDir & Convert.ToString("ConvertToTIFF-Settings.pdf"))
            ' Start the conversion process
            pdfConverter.DoConvert()
            ' Convert to TIFF image
            pdfConverter.SaveAsTIFF(dataDir & Convert.ToString("output_out_.tif"))
            ' Close Converter object
            pdfConverter.Close()
            ' ExStart:ConvertToTIFF
        End Sub
    End Class
End Namespace