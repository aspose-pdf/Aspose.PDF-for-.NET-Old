Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Images
    Public Class ConvertPDFPages
        Public Shared Sub Run()
            ' ExStart:ConvertPDFPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()

            ' Create PdfConverter object
            Dim objConverter As New PdfConverter()

            ' Bind input pdf file
            objConverter.BindPdf(dataDir & Convert.ToString("ConvertPDFPages.pdf"))

            ' Initialize the converting process
            objConverter.DoConvert()

            objConverter.CoordinateType = PageCoordinateType.CropBox

            ' Check if pages exist and then convert to image one by one
            While objConverter.HasNextImage()
                objConverter.GetNextImage((dataDir & DateTime.Now.Ticks.ToString()) + "_out_.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            End While

            ' Close the PdfConverter object
            objConverter.Close()
            ' ExEnd:ConvertPDFPages

        End Sub
    End Class
End Namespace
