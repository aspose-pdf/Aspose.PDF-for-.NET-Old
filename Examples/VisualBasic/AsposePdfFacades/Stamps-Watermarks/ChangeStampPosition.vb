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
    Public Class ChangeStampPosition
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()

            'Instantiate PdfContentEditor Object
            Dim pdfContentEditor As New PdfContentEditor()

            '//bind input PDF file
            pdfContentEditor.BindPdf(dataDir & "ChangeStampPosition.pdf")

            Dim pageId As Integer = 1
            Dim stampIndex As Integer = 1
            Dim x As Double = 200
            Dim y As Double = 200

            'Change the position of the stamp to new x and y position
            pdfContentEditor.MoveStamp(pageId, stampIndex, x, y)

            'Save the PDF file
            pdfContentEditor.Save(dataDir & "ChangeStampPosition_out.pdf")
        End Sub
    End Class
End Namespace