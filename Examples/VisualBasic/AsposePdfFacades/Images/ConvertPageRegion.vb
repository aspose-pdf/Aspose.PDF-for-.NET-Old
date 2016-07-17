Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Images
    Public Class ConvertPageRegion
        Public Shared Sub Run()
            ' ExStart:ConvertPageRegion
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            ' Instantiate PdfPageEditor class to get particular page region
            Dim editor As New Aspose.Pdf.Facades.PdfPageEditor()
            ' Bind the source PDF file
            editor.BindPdf(dataDir & Convert.ToString("Convert-PageRegion.pdf"))
            ' Move the origin of PDF file to particular point
            editor.MovePosition(0, 700)
            ' Create a memory stream object
            Dim ms As New MemoryStream()
            ' Save the updated document to stream object
            editor.Save(ms)
            ' Create PdfConverter object
            Dim objConverter As New PdfConverter()
            ' Bind input pdf file
            objConverter.BindPdf(ms)
            ' Set StartPage and EndPage properties to the page number to
            ' You want to convert images from
            objConverter.StartPage = 1
            objConverter.EndPage = 1
            ' Counter
            Dim page As Integer = 1
            ' Initialize the converting process
            objConverter.DoConvert()
            ' Check if pages exist and then convert to image one by one
            While objConverter.HasNextImage()
                objConverter.GetNextImage((dataDir & Convert.ToString("Specific_Region-Image")) + System.Math.Max(System.Threading.Interlocked.Increment(page), page - 1).ToString() + "_out_.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
            End While
            ' Close the PdfConverter object
            objConverter.Close()
            ' Close MemoryStream object holding the updated document
            ms.Close()
            ' ExEnd:ConvertPageRegion

        End Sub
    End Class
End Namespace
