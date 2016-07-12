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
    Public Class AddImageFooter
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()
            'open document
            Dim fileStamp As New PdfFileStamp(dataDir & "AddImage-Footer.pdf", dataDir & "AddImage-Footer_out.pdf")

            'add footer
            fileStamp.AddFooter(New FileStream(dataDir & "aspose-logo.jpg", FileMode.Open), 10)

            'save updated PDF file
            fileStamp.Close()


        End Sub
    End Class
End Namespace