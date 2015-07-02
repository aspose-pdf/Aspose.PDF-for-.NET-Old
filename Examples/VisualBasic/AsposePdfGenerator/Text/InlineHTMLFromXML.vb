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
Imports System.Text
Imports System.Xml

Namespace VisualBasic.AsposePdfGenerator.Text
    Public Class InlineHTMLFromXML
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            'Create pdf document
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            'Bind XML into the document
            pdf1.BindXML(dataDir & "TEST.xml", Nothing)

            'Save the document
            pdf1.Save(dataDir & "test.pdf")
        End Sub
    End Class
End Namespace

