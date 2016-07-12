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
Imports System.Drawing

Namespace AsposePDFFacades.StampsWatermarks
    Public Class AddHeader
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()

            'open document
            Dim fileStamp As New PdfFileStamp(dataDir & "AddHeader.pdf", dataDir & "AddHeader_out.pdf")

            'create formatted text for page number
            Dim formattedText As New FormattedText("Aspose - Your File Format Experts!", System.Drawing.Color.Blue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, False, 14)

            'add header
            fileStamp.AddHeader(formattedText, 10)

            'save updated PDF file
            fileStamp.Close()

        End Sub
    End Class
End Namespace