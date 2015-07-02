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

Namespace VisualBasic.AsposePdfGenerator.Text
    Public Class TextFormattingTags
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiate a pdf document
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            'Create a section in the pdf document
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            'Create string variables with text containing html tags
            Dim s As String = "<font face=""Times New Roman"" size=18><u>" & "This is a test </u><i> for <strong> HTML </<strong> support </i>" & "<s> in Text paragraph. </s></font>"

            Dim s1 As String = "<font color=""#800080"">This is a test for <b>HTML</b>" & "with colored text.</font>"

            Dim s2 As String = "<p><font face=""Verdana"" color=""#0033ff""> This is a test for" & "<strong>HTML</strong> in text paragraph.</font></p>"

            'Create text paragraphs containing HTML text
            Dim text1 As New Aspose.Pdf.Generator.Text(s)
            text1.IsHtmlTagSupported = True
            Dim text2 As New Aspose.Pdf.Generator.Text(s1)
            text2.IsHtmlTagSupported = True
            Dim text3 As New Aspose.Pdf.Generator.Text(s2)
            text3.IsHtmlTagSupported = True

            'Add the text paragraphs containing HTML text to the section
            sec1.Paragraphs.Add(text1)
            sec1.Paragraphs.Add(text2)
            sec1.Paragraphs.Add(text3)

            'Save the pdf document
            pdf1.Save(dataDir & "TestHtml.pdf")
        End Sub


    End Class
End Namespace
