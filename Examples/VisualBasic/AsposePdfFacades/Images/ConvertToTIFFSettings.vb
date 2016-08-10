Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Devices

Namespace AsposePDFFacades.Images
    Public Class ConvertToTIFFSettings
        Public Shared Sub Run()
            ' ExStart:ConvertToTIFFSettings
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            ' Create PdfConverter object and bind input PDF file
            Dim pdfConverter As New PdfConverter()
            ' Create Resolution object with 300 as an argument
            Dim resolution As New Aspose.Pdf.Devices.Resolution(300)
            ' Specify the resolution value for PdfConverter object
            pdfConverter.Resolution = resolution
            ' Bind the source PDF file
            pdfConverter.BindPdf(dataDir & Convert.ToString("ConvertToTIFF-Settings.pdf"))
            ' Start the conversion process
            pdfConverter.DoConvert()
            ' Create TiffSettings object and set ColorDepth
            Dim tiffSettings As New TiffSettings()
            tiffSettings.Depth = Aspose.Pdf.Devices.ColorDepth.Format1bpp
            ' Convert to TIFF image
            pdfConverter.SaveAsTIFF(dataDir & Convert.ToString("output_out_.tif"), 300, 300, tiffSettings)
            ' Close Converter object
            pdfConverter.Close()
            ' ExEnd:ConvertToTIFFSettings
        End Sub
    End Class
End Namespace