'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Devices

Namespace VisualBasic.AsposePdf.Images
    Public Class ConvertAllPagesToPNG
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            'Open document
            Dim pdfDocument As New Document(dataDir & "ConvertAllPagesToPNG.pdf")


            For pageCount As Integer = 1 To pdfDocument.Pages.Count
                Using imageStream As New FileStream(dataDir & "image" & pageCount & ".png", FileMode.Create)
                    'create PNG device with specified attributes
                    'Width, Height, Resolution, Quality
                    'Quality [0-100], 100 is Maximum
                    'Create Resolution object
                    Dim resolution As New Resolution(300)
                    Dim pngDevice As New PngDevice(resolution)

                    'Convert a particular page and save the image to stream
                    pngDevice.Process(pdfDocument.Pages(pageCount), imageStream)

                    'Close stream
                    imageStream.Close()

                End Using
            Next pageCount

        End Sub
    End Class
End Namespace