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
Imports System

Namespace VisualBasic.AsposePDFFacades.Images
    Public Class ConvertPDFPages
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            'create PdfConverter object
            Dim objConverter As New PdfConverter()

            'bind input pdf file
            objConverter.BindPdf(dataDir & "ConvertPDFPages.pdf")

            'initialize the converting process
            objConverter.DoConvert()
            objConverter.ShowHiddenAreas = True

            'check if pages exist and then convert to image one by one
            Do While objConverter.HasNextImage()
                objConverter.GetNextImage(dataDir & DateTime.Now.Ticks.ToString() & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Loop

            'close the PdfConverter object
            objConverter.Close()


        End Sub
    End Class
End Namespace