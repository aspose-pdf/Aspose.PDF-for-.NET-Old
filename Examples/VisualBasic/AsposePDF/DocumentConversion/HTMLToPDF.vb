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
Imports System

Namespace VisualBasic.AsposePdf.DocumentConversion
    Public Class HTMLToPDF
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Specify the The base path/url for the html file which serves as images database
            Dim basePath As String = "C:/temp/"
            Dim htmloptions As New HtmlLoadOptions(basePath)
            ' Load HTML file
            Dim doc As New Document(dataDir & "Input.html", htmloptions)
            ' Save HTML file
            doc.Save(dataDir & "HTMLToPDF_out.pdf")
        End Sub
    End Class
End Namespace