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
    Public Class ExtractImagesStream
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Images()
            'open input PDF
            Dim pdfExtractor As New PdfExtractor()
            pdfExtractor.BindPdf(dataDir & "ExtractImages-Stream.pdf")

            'extract images
            pdfExtractor.ExtractImage()
            'get all the extracted images
            Do While pdfExtractor.HasNextImage()
                'read image into memory stream
                Dim memoryStream As New MemoryStream()
                pdfExtractor.GetNextImage(memoryStream)

                'write to disk, if you like, or use it otherwise.
                Dim fileStream As New FileStream(dataDir & DateTime.Now.Ticks.ToString() & ".jpg", FileMode.Create)
                memoryStream.WriteTo(fileStream)
                fileStream.Close()
            Loop

        End Sub
    End Class
End Namespace