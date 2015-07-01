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
Imports Aspose.Pdf.Text

Namespace VisualBasic.AsposePdf.StampsWatermarks
    Public Class PageNumberStamps
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            'open document
            Dim pdfDocument As New Document(dataDir & "PageNumberStamp.pdf")

            'create page number stamp
            Dim pageNumberStamp As New PageNumberStamp()
            'whether the stamp is background
            pageNumberStamp.Background = False
            pageNumberStamp.Format = "Page # of " & pdfDocument.Pages.Count
            pageNumberStamp.BottomMargin = 10
            pageNumberStamp.HorizontalAlignment = HorizontalAlignment.Center
            pageNumberStamp.StartingNumber = 1
            'set text properties
            pageNumberStamp.TextState.Font = FontRepository.FindFont("Arial")
            pageNumberStamp.TextState.FontSize = 14.0F
            pageNumberStamp.TextState.FontStyle = FontStyles.Bold
            pageNumberStamp.TextState.FontStyle = FontStyles.Italic
            pageNumberStamp.TextState.ForegroundColor = Color.Aqua

            'add stamp to particular page
            pdfDocument.Pages(1).AddStamp(pageNumberStamp)

            'save output document
            pdfDocument.Save(dataDir & "PageNumberStamp_out.pdf")



        End Sub
    End Class
End Namespace