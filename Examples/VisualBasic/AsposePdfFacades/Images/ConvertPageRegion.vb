'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace VisualBasic.AsposePDFFacades.Images
    Public Class ConvertPageRegion
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            ' instantiate PdfPageEditor class to get particular page region
            Dim editor As New Aspose.Pdf.Facades.PdfPageEditor()
            ' bind the source PDF file
            editor.BindPdf(dataDir & "SampleInput.pdf")
            ' move the origin of PDF file to particular point
            editor.MovePosition(0, 700)
            ' create a memory stream object
            Dim ms As New MemoryStream()
            ' save the updated document to stream object
            editor.Save(ms)
            'create PdfConverter object
            Dim objConverter As New PdfConverter()
            'bind input pdf file
            objConverter.BindPdf(ms)
            'set StartPage and EndPage properties to the page number to
            'you want to convert images from
            objConverter.StartPage = 1
            objConverter.EndPage = 1
            'Counter
            Dim page As Integer = 1
            'initialize the converting process
            objConverter.DoConvert()
            'check if pages exist and then convert to image one by one
            Do While objConverter.HasNextImage()
                objConverter.GetNextImage(dataDir & "Specific_Region-Image" & page & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                page += 1
            Loop
            'close the PdfConverter object
            objConverter.Close()
            ' close MemoryStream object holding the updated document
            ms.Close()


        End Sub
    End Class
End Namespace