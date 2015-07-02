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
    Public Class PDFPageStamps
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            'open document
            Dim pdfDocument As New Document(dataDir & "PDFPageStamp.pdf")

            'create page stamp
            Dim pageStamp As New PDFPageStamp(pdfDocument.Pages(1))
            pageStamp.Background = True
            pageStamp.XIndent = 100
            pageStamp.YIndent = 100
            pageStamp.Rotate = Rotation.on180


            'add stamp to particular page
            pdfDocument.Pages(1).AddStamp(pageStamp)

            'save output document
            pdfDocument.Save(dataDir & "PDFPageStamp_out.pdf")

        End Sub
    End Class
End Namespace