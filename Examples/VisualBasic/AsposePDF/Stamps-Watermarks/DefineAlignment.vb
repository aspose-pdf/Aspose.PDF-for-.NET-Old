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
Imports Aspose.Pdf.Facades

Namespace VisualBasic.AsposePdf.StampsWatermarks
    Public Class DefineAlignment
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Instantiate Document object with input file
            Dim doc As New Document(dataDir & "DefineAlignment.pdf")
            ' instantiate FormattedText object with sample string
            Dim text As New FormattedText("This")
            ' add new text line to FormattedText
            text.AddNewLineText("is sample")
            text.AddNewLineText("Center Aligned")
            text.AddNewLineText("TextStamp")
            text.AddNewLineText("Object")
            ' create TextStamp object using FormattedText
            Dim stamp As New TextStamp(text)
            ' specify the Horizontal Alignment of text stamp as Center aligned
            stamp.HorizontalAlignment = HorizontalAlignment.Center
            ' specify the Vertical Alignment of text stamp as Center aligned
            stamp.VerticalAlignment = VerticalAlignment.Center
            ' specify the Text Horizontal Alignment of TextStamp as Center aligned
            stamp.TextAlignment = HorizontalAlignment.Center
            ' set top margin for stamp object
            stamp.TopMargin = 20
            ' add the stamp object over first page of document
            doc.Pages(1).AddStamp(stamp)
            ' save the udpated document
            doc.Save(dataDir & "StampedPDF.pdf")


        End Sub
    End Class
End Namespace