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

Namespace VisualBasic.AsposePdf.StampsWatermarks
    Public Class ImageinHeader
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            'open document
            Dim pdfDocument As New Document(dataDir & "ImageinHeader.pdf")

            'create header
            Dim imageStamp As New ImageStamp(dataDir & "aspose-logo.jpg")
            'set properties of the stamp
            imageStamp.TopMargin = 10
            imageStamp.HorizontalAlignment = HorizontalAlignment.Center
            imageStamp.VerticalAlignment = VerticalAlignment.Top
            'add header on all pages
            For Each page As Page In pdfDocument.Pages
                page.AddStamp(imageStamp)
            Next page

            'save updated document
            pdfDocument.Save(dataDir & "ImageinHeader_out.pdf")


        End Sub
    End Class
End Namespace