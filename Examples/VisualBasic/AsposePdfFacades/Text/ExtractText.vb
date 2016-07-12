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
Imports System.Text

Namespace AsposePDFFacades.Text
    Public Class ExtractText
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Text()
            'open input PDF
            Dim pdfExtractor As New PdfExtractor()
            pdfExtractor.BindPdf(dataDir & "ExtractText.pdf")

            'use parameterless ExtractText method
            pdfExtractor.ExtractText()

            Dim tempMemoryStream As New MemoryStream()
            pdfExtractor.GetText(tempMemoryStream)

            Dim text As String = ""
            'specify Unicode encoding type in StreamReader constructor
            Using streamReader As New StreamReader(tempMemoryStream, Encoding.Unicode)
                streamReader.BaseStream.Seek(0, SeekOrigin.Begin)
                text = streamReader.ReadToEnd()
            End Using

            File.WriteAllText(dataDir & "output.txt", text)


        End Sub
    End Class
End Namespace