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

Namespace AsposePDFFacades.StampsWatermarks
    Public Class ExtractImageImageStamp
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()
            'Instantiate PdfContentEditor Object
            Dim pdfContentEditor As New PdfContentEditor()

            '//bind input PDF file
            pdfContentEditor.BindPdf(dataDir & "ExtractImage-ImageStamp.pdf")

            'Get Stamp info for the first stamp
            Dim infos() As StampInfo = pdfContentEditor.GetStamps(1)

            'Get the image from Stamp Info

            Dim image As System.Drawing.Image = infos(0).Image

            'Save the extracted image
            image.Save(dataDir & "image.jpg")



        End Sub
    End Class
End Namespace